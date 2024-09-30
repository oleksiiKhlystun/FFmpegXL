using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace toMov
{
    public partial class toMovMp4 : Form
    {
        //The whole point of this program is to turn the menu into a text command that will run on the command line
        // Весь смысл этой программы - превратить менюшку в текстовую команду, которая запустится в командной строке
        // ffmpeg -i test.avi testConvert.mov.
        //If you are not in the native directory, then you need to completely specify the path in quotation marks
        //Если находишься не в родной директории, то нужно полностью прописать путь в кавычках
        //ffmpeg -i test.avi testConvert.mov.
        private Process ffmpegProcess; //это для ffmpeg
        private string finalFormat;
        private string soundOff;
        private string sound64k;
        private string convertAudio;
        private string selectFile;
        private string outFile;
        private string outFps;
        private string finalCommand;
        private string trimSS;
        private string trimTo;
        private string yuv420p;
        private string finscale;
        private string finspeed;
        private string atempo;
        private string selectedFolderPath = "D:\\";
        private Form recordF2;

        public toMovMp4()
        {
            InitializeComponent();
            LoadDevices(); // Заполняем ComboBox при загрузке формы
        }
        private void LoadDevices()
        {
            // Запуск команды ffmpeg для получения списка устройств
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = "/c ffmpeg -list_devices true -f dshow -i dummy"
            };

            Process process = new Process
            {
                StartInfo = procStartInfo
            };

            process.Start();

            // Чтение вывода команды
            string output = process.StandardError.ReadToEnd();
            process.WaitForExit();

            // Парсинг вывода для получения списка устройств
            Regex regex = new Regex(@"\""(.*?)\"" \((.*?)\)");
            MatchCollection matches = regex.Matches(output);

            foreach (Match match in matches)
            {// Добавление устройства в ComboBox
                string deviceName = match.Groups[1].Value;
                cmbBoxRecordAudio.Items.Add(deviceName);
            }

            if (cmbBoxRecordAudio.Items.Count > 0)
            {// Выбираем первый элемент по умолчанию
                cmbBoxRecordAudio.SelectedIndex = 1; 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void upDownFps_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown upDownFps = (NumericUpDown)sender;
        }
        private void chboxFps_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chboxResize2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void chboxSpeedM2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxSpeedM2 = (CheckBox)sender;
            if (chboxSpeedM2.Checked)
            {                
                chboxSpeedD2.Checked = false;
            }
       
        }

        private void chboxSpeedD2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxSpeedD2 = (CheckBox)sender;
            if (chboxSpeedD2.Checked)
            {
                chboxSpeedM2.Checked = false;
            }
   
        }
        private void chboxTrim_CheckedChanged(object sender, EventArgs e)
        {
         }
        private void chboxTo_CheckedChanged(object sender, EventArgs e)
        {    
        }
        private void btnSelConvert_Click(object sender, EventArgs e)
        {
            outFps = chboxFps.Checked ? $" -r {upDownFps.Value}" : "";
            convertAudio = cmbBoxConvertAudio.Text=="off" ? " -an" : $" -b:a {cmbBoxConvertAudio.Text}";
            trimSS = chboxTrim.Checked ? $" -ss {mtxtTrim.Text}" : "";
            trimTo = chboxTo.Checked ? $" -to {mtxtTo.Text}" : "";

            if (chboxResize2.Checked)
            {
                finscale = "scale=trunc(iw/4)*2:trunc(ih/4)*2";
            }
            else
            {
                finscale = "scale=trunc(iw/2)*2:trunc(ih/2)*2";
            }

            if (chboxSpeedM2.Checked)
            {
                finspeed = "setpts=0.5*PTS";
                atempo = "atempo=2.0";
            }
            else if (chboxSpeedD2.Checked)
            {
                finspeed = "setpts=2.0*PTS";
                atempo = "atempo=0.5";
            }
            else
            {
                finspeed = "setpts=1.0*PTS";
                atempo = "atempo=1.0";
            }

            finalFormat = cmbBoxOut.Text != "png" ? "." + cmbBoxOut.Text : "%04d." + cmbBoxOut.Text;
            yuv420p = (cmbBoxOut.Text == "mp4" || cmbBoxOut.Text == "mov") ? " -pix_fmt yuv420p" : "";
            string outGif = cmbBoxOut.Text == "gif" ? ":flags=lanczos,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse" : "";
            string filter0aAtempo = cmbBoxConvertAudio.Text == "off" ? $"" : $";[0:a]{atempo}[a]";
            string filterMapA = cmbBoxConvertAudio.Text == "off" ? $"" : $" -map \'[a]\'";
            string filterComplex = $" -filter_complex \'[0:v]{finscale}{outGif},{finspeed}[v]{filter0aAtempo}\' -map \'[v]\'{filterMapA}";

            OpenFileDialog selectFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                //Filter = "Videos(avi,mp4,mov,mkv,3gp,flv,mpg,ogg,wmv,webm,png)|*.avi;*.mp4;*.mov;*.mkv;*.3gp;*.flv;*.mpg;*.ogg;*.wmv;*.webm;*.png;"
            };

            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in selectFileDialog.FileNames)
                {
                    DateTime date = DateTime.Now;
                    CultureInfo ci = CultureInfo.InvariantCulture;
                    string fileName = Path.GetFileNameWithoutExtension(file).Replace(" ", "");

                    
                    selectFile = $"\'{Path.GetFullPath(file)}\'";

                    outFile = cmbBoxOut.Text != "png"
                        ? $"\"{Path.GetDirectoryName(file)}\\{fileName}{date.ToString("mmss", ci)}{finalFormat}\""
                        : $"\"{Path.GetDirectoryName(file)}\\{fileName}{finalFormat}\"";

                    finalCommand = $"ffmpeg -i {selectFile}{outFps}{trimSS}{trimTo}{filterComplex}{convertAudio}{yuv420p} {outFile}";
                    //MessageBox.Show(finalCommand);
                    ProcessStartInfo procStartInfo = new ProcessStartInfo("powershell.exe")
                    {
                        WorkingDirectory = Path.GetDirectoryName(file),
                        Arguments = finalCommand
                    };

                    var process = Process.Start(procStartInfo);
                    process.WaitForExit();

                    if (Path.GetExtension(file) == ".png")
                    {
                        break;
                    }
                }
            }
        }

        private void btnRenameLast4_Click(object sender, EventArgs e)
        {
            // Открытие диалога для выбора файлов
            OpenFileDialog selectFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "All files|*.*" // Позволяет выбирать все файлы
            };

            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in selectFileDialog.FileNames)
                {
                    string directory = Path.GetDirectoryName(file);
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string extension = Path.GetExtension(file);

                    // Проверка, что длина имени файла больше 4 символов
                    if (fileName.Length > 4)
                    {
                        string newFileName = fileName.Substring(0, fileName.Length - 4) + extension;
                        string newFilePath = Path.Combine(directory, newFileName);

                        try
                        {
                            File.Move(file, newFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error renaming file: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"File name is too short to remove 4 characters: {fileName}{extension}");
                    }                    
                }
                MessageBox.Show("Files renamed successfully!");
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;                  
                    lblPathSelectFolder.Text = selectedFolderPath;
                }               
            }
        }

        private void btnRectRecord_Click(object sender, EventArgs e)
        {
            if (recordF2 == null || recordF2.IsDisposed)
            {
                recordF2 = new Form();
                recordF2.Show();
                recordF2.Opacity = 0.5;
            }
            else { }
        }
        //Это нужно для изменения размера появляющегося окна PowerSHell
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        const uint SWP_NOMOVE = 0x0002;
        const uint SWP_NOZORDER = 0x0004;

        private void btnStart_Click(object sender, EventArgs e)
        {
            string rect = "";
            if (chboxVideo.Checked)
            {
                if (recordF2 != null && !recordF2.IsDisposed)
                {
                    int width = ((recordF2.Width) / 2) * 2;//делаем четное количество пикселей
                    int height = ((recordF2.Height) / 2) * 2;
                    rect = $"-offset_x {recordF2.Left} -offset_y {recordF2.Top} -video_size {width}x{height}";
                    recordF2.Hide();
                }

                string outputFilePath = Path.Combine(selectedFolderPath, DateTime.Now.ToString("yyyyMMdd-HHmmss", CultureInfo.InvariantCulture) + ".mp4");

                string captureCommand;

                if (chboxAudio.Checked)
                {
                    captureCommand = $"ffmpeg -rtbufsize 150M -thread_queue_size 512 -f gdigrab {rect} -i desktop " +
                        $"-f dshow -i audio=\"{cmbBoxRecordAudio.Text}\" -framerate 30 -c:v libx264 -r 30 -preset ultrafast " +
                        $"-tune zerolatency -crf 18 -pix_fmt yuv420p -c:a aac -strict -2 -ac 2 -b:a 128k \"{outputFilePath}\"";
                }
                else
                {
                    captureCommand = $"ffmpeg -f gdigrab -framerate 30 -thread_queue_size 512 {rect} -i desktop " +
                        $"-c:v libx264 -preset ultrafast -crf 18 -pix_fmt yuv420p \"{outputFilePath}\"";
                }

                ProcessStartInfo procStartInfo = new ProcessStartInfo("powershell.exe");
                procStartInfo.Arguments = $"-NoExit -Command \"{captureCommand}\"";
                var process = Process.Start(procStartInfo);
                Thread.Sleep(100);
                SetWindowPos(process.MainWindowHandle, IntPtr.Zero, 0, 0, 400, 200, SWP_NOMOVE | SWP_NOZORDER);
                process.WaitForExit();

                // Проверяем, существует ли форма и не была ли она уничтожена до вызова Show
                if (recordF2 != null && !recordF2.IsDisposed)
                {
                    recordF2.Show();
                }
            }
            else if (!chboxVideo.Checked && chboxAudio.Checked)
            {
                string outputFilePath = Path.Combine(selectedFolderPath, DateTime.Now.ToString("yyyyMMdd-HHmmss", CultureInfo.InvariantCulture) + ".mp3");
                string captureCommand = $"ffmpeg -f dshow -i audio=\"{cmbBoxRecordAudio.Text}\" -acodec libmp3lame \"{outputFilePath}\"";
                ProcessStartInfo procStartInfo = new ProcessStartInfo("powershell.exe");
                procStartInfo.Arguments = $"-NoExit -Command \"{captureCommand}\"";
                var process = Process.Start(procStartInfo);
                Thread.Sleep(100);
                SetWindowPos(process.MainWindowHandle, IntPtr.Zero, 0, 0, 400, 200, SWP_NOMOVE | SWP_NOZORDER);
                process.WaitForExit();
            }
        }

    }
}
