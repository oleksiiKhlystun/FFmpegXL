using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Globalization;

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
        private string finalFormat;
        private string removeSound;
        private string resize2;
        private string selectFile;
        private string outFile;
        private string outFps;
        private string finalCommand;
        private string fast;
        private string trimSS;
        private string trimTo;

        public toMovMp4()
        {
            InitializeComponent();
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
            CheckBox chboxFps = (CheckBox)sender;
            if (chboxFps.Checked)
            {
                chboxFast.Checked = false;              
            }
        }
       
        private void chboxSound_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void chboxResize2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxResize2 = (CheckBox)sender;
            if (chboxResize2.Checked)
            {
                chboxFast.Checked = false;
            }
        }
        private void chboxTrim_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxTrim = (CheckBox)sender;
            if (chboxTrim.Checked)
            {
                chboxFast.Checked = false;
            }
            else if(chboxTrim.Checked == false)
            {
                chboxTo.Checked = false;
            }
        }
        private void chboxTo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxTo = (CheckBox)sender;
            if (chboxTo.Checked)
            {

                chboxFast.Checked = false;
            }
        }
        private void chboxFast_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxFast = (CheckBox)sender;
            if (chboxFast.Checked)
            {
                chboxResize2.Checked = false;
                chboxFps.Checked = false;
                chboxTrim.Checked = false;
            }
        }

        private void radioBtn_mov_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioBtn_avi_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioBtn_mp4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnSelConvert_Click(object sender, EventArgs e)
        {
            outFps = chboxFps.Checked ? $" -r {upDownFps.Value} " : "";
            removeSound = chboxSound.Checked ? " -an " : "";
            resize2 = chboxResize2.Checked ? @" -vf scale=""iw/2:ih/2"" " : "";
            fast = chboxFast.Checked ? " -c:v copy -c:a copy " : "";
            trimSS = chboxTrim.Checked ? $"-ss {mtxtTrim.Text} " : "";
            trimTo = chboxTo.Checked ? $" -to {mtxtTo.Text} " : "";
            

            //foreach (var ch in Controls.OfType<CheckBox>())
            foreach (var rb in Controls.OfType<RadioButton>())
                if (rb.Checked)
                {
                    finalFormat = rb.Text != "png" ? (finalFormat = "." + rb.Text) : (finalFormat = "%04d." + rb.Text);
                    // Configure open file dialog box
                    OpenFileDialog selectFileDialog = new OpenFileDialog();
                    selectFileDialog.Multiselect = true;
                    selectFileDialog.Filter = "Videos(avi,mp4,mov,mkv,3gp,flv,mpg,ogg,wmv,webm,png)|*.avi;*.mp4;*.mov;*.mkv;*.3gp;*.flv;*.mpg;*.ogg;*.wmv;*.webm;*.png;"; // Filter files by extension
                    if (selectFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in selectFileDialog.FileNames)
                        {
                            DateTime date = DateTime.Now;
                            CultureInfo ci = CultureInfo.InvariantCulture;
                            string fileName = Path.GetFileNameWithoutExtension(file).Replace(" ", "_");
                            //MessageBox.Show(Path.GetExtension(file));
                            selectFile = Path.GetExtension(file) != ".png" ? $" \"{Path.GetFileName(file)}\" " : $" {fileName.Remove(fileName.Length - 4, 4)}%04d.png ";
                            outFile = $" {fileName}{date.ToString("mmss", ci)}{finalFormat}";                           
                            finalCommand = "/c ffmpeg -i" + selectFile + outFps + resize2 + removeSound + trimSS + trimTo + fast + "-pix_fmt yuv420p" + outFile;
                 
                           // MessageBox.Show(finalCommand); // testing final command
                            // Converting
                            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
                            procStartInfo.WorkingDirectory = Path.GetDirectoryName(file);
                           // procStartInfo.Arguments = "/c FOR /F \"tokens = *\" %G IN ('dir /b 1.avi,gun_reload.mp4') DO ffmpeg -i \" % G\" -acodec copy \" % ~nG.mkv\" "; //trying batch
                            procStartInfo.Arguments = finalCommand;
                            Process.Start(procStartInfo);
                            if (Path.GetExtension(file) == ".png")
                            {
                                break; 
                            }
                        }
                       
                    }  
                }
        }

       
    }
    
}
