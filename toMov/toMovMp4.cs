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
        private string soundOff;
        private string sound64k;
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

        }
    
        private void chboxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxSoundOff.Checked)
            {
                chboxSound64k.Checked = false;
            }
        }

        private void chboxResize2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxResize2 = (CheckBox)sender;
            if (chboxResize2.Checked)
            {
                radioBtn_gif.Checked = false;
            }
        }
        private void chboxSpeedM2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxSpeedM2 = (CheckBox)sender;
            if (chboxSpeedM2.Checked)
            {
                //chboxSoundOff.Checked = true;                
                chboxSpeedD2.Checked = false;
            }
       
        }

        private void chboxSpeedD2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxSpeedD2 = (CheckBox)sender;
            if (chboxSpeedD2.Checked)
            {
                //chboxSoundOff.Checked = true;
                chboxSpeedM2.Checked = false;
            }
   
        }
        private void chboxTrim_CheckedChanged(object sender, EventArgs e)
        {
         }
        private void chboxTo_CheckedChanged(object sender, EventArgs e)
        {    
        }

        private void radioBtn_mov_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioBtn_mp4_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioBtn_gif_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn_gif = (RadioButton)sender;
            if (radioBtn_gif.Checked)
            {
                chboxResize2.Checked = false;               
            }
        }
        private void btnSelConvert_Click(object sender, EventArgs e)
        {
            outFps = chboxFps.Checked ? $"fps={upDownFps.Value}," : "";
            soundOff = chboxSoundOff.Checked ? " -an " : "";
            sound64k = chboxSound64k.Checked ? " -b:a 64k " : "";
            trimSS = chboxTrim.Checked ? $" -ss {mtxtTrim.Text} " : "";
            trimTo = chboxTo.Checked ? $" -to {mtxtTo.Text} " : "";
            if (chboxResize2.Checked){ finscale = "scale=trunc(iw/4)*2:trunc(ih/4)*2"; }
            else if (radioBtn_gif.Checked) { finscale = "scale = 640:-1:flags = lanczos,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse"; }
            else { finscale = "scale = trunc(iw/2)*2:trunc(ih/2)*2"; }

            if (chboxSpeedM2.Checked) { finspeed = "setpts = 0.5 * PTS"; atempo = "atempo=2.0"; }
            else if (chboxSpeedD2.Checked) { finspeed = "setpts = 2.0 * PTS"; atempo = "atempo=0.5"; }
            else { finspeed = "setpts = 1.0 * PTS"; atempo = "atempo=1.0"; }

            //foreach (var ch in Controls.OfType<CheckBox>())
            foreach (var rb in Controls.OfType<RadioButton>())
                if (rb.Checked)
                {
                    finalFormat = rb.Text != "png" ? (finalFormat = "." + rb.Text) : (finalFormat = "%04d." + rb.Text);
                    yuv420p = (rb.Text == "mp4")||(rb.Text == "mov") ? " -pix_fmt yuv420p " : "";
                    
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
                            outFile = rb.Text != "png" ? $" {fileName}{date.ToString("mmss", ci)}{finalFormat}": $" {fileName}{finalFormat}";                           
                            //finalCommand = "/c ffmpeg -i" +selectFile + soundOff + trimSS + trimTo + $" -vf \"[0:v]{outFps}{finscale},{finspeed}[v];[0:a]{atempo}[a]\" " + sound64k + yuv420p + outFile; // + togif  + speedM2 + speedD2 + resize2+ outFps"-pix_fmt yuv420p"
                            finalCommand = $"/c ffmpeg -i {selectFile} {soundOff} {trimSS} {trimTo} -filter_complex \"[0:v]{outFps}{finscale},{finspeed}[v];[0:a]{atempo}[a]\" -map \"[v]\" -map \"[a]\" {sound64k} {yuv420p} {outFile}";
                            //MessageBox.Show(finalCommand); // testing final command
                            // Converting
                            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
                            procStartInfo.WorkingDirectory = Path.GetDirectoryName(file);
                            // procStartInfo.Arguments = "/c FOR /F \"tokens = *\" %G IN ('dir /b 1.avi,gun_reload.mp4') DO ffmpeg -i \" % G\" -acodec copy \" % ~nG.mkv\" "; //this batch not needed
                            procStartInfo.Arguments = finalCommand;
                            var process = Process.Start(procStartInfo);
                            process.WaitForExit();//Instructs the Process component to wait indefinitely for the associated process to exit.
                            if (Path.GetExtension(file) == ".png")
                            {
                                break;
                            }
                        }
                       
                    }  
                }
        }

        private void btnFastConvert_Click(object sender, EventArgs e)
        {
             foreach (var rb in Controls.OfType<RadioButton>())
                if (rb.Checked)
                {
                
                    OpenFileDialog selectFileDialog2 = new OpenFileDialog();
                    selectFileDialog2.Multiselect = true;
                    selectFileDialog2.Filter = "Videos(avi,mp4,mov,mkv,3gp,flv,mpg,ogg,wmv,webm)|*.avi;*.mp4;*.mov;*.mkv;*.3gp;*.flv;*.mpg;*.ogg;*.wmv;*.webm;"; // Filter files by extension
                    if (selectFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in selectFileDialog2.FileNames)
                        {
                            DateTime date = DateTime.Now;
                            CultureInfo ci = CultureInfo.InvariantCulture;
                            string fileName = Path.GetFileNameWithoutExtension(file).Replace(" ", "_");
                            finalCommand = $"/c ffmpeg -i \"{Path.GetFileName(file)}\" -c:v copy -c:a copy {fileName}2.{rb.Text}";
                            
                            //MessageBox.Show(finalCommand); // testing final command
                            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
                            procStartInfo.WorkingDirectory = Path.GetDirectoryName(file);
                            // procStartInfo.Arguments = "/c FOR /F \"tokens = *\" %G IN ('dir /b 1.avi,gun_reload.mp4') DO ffmpeg -i \" % G\" -acodec copy \" % ~nG.mkv\" "; //trying batch
                            procStartInfo.Arguments = finalCommand;
                            var process = Process.Start(procStartInfo);
                            process.WaitForExit();//Instructs the Process component to wait indefinitely for the associated process to exit.
                        }
                    }
                }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFileDialog3 = new OpenFileDialog();
           // selectFileDialog3.Title = "Copy file parametres";
            selectFileDialog3.Multiselect = true;
            selectFileDialog3.Filter = "png|*.png;"; // Filter files by extension
            if (selectFileDialog3.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                foreach (string file in selectFileDialog3.FileNames)
                {
                    i++;
                    string fileName =  Path.GetFileNameWithoutExtension(file).Remove(Path.GetFileNameWithoutExtension(file).Length - 4, 4)   + i.ToString("0000") +".png";
                    string renameCommand = $"/c ren {Path.GetFileName(file)} {fileName}";

                    //MessageBox.Show(renameCommand); // testing final command
                    ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
                    procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    procStartInfo.WorkingDirectory = Path.GetDirectoryName(file);
                    // procStartInfo.Arguments = "/c FOR /F \"tokens = *\" %G IN ('dir /b 1.avi,gun_reload.mp4') DO ffmpeg -i \" % G\" -acodec copy \" % ~nG.mkv\" "; //trying batch
                    procStartInfo.Arguments = renameCommand;
                    var process = Process.Start(procStartInfo);
                    process.WaitForExit(); //Instructs the Process component to wait indefinitely for the associated process to exit.

                }
                MessageBox.Show("rename success!");
            }
            
        }


    }
    
}
