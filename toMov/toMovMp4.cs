using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

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
        
        public toMovMp4()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label_Click(object sender, EventArgs e)
        {
        }
        private void upDownFps_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown upDownFps = (NumericUpDown)sender;
        }
        private void chboxSound_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxSound = (CheckBox)sender;
            if (chboxSound.Checked)
            {
                removeSound = " -an ";
            }
            else
            {
                 removeSound = "";
            }
        }
        private void chboxResize2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chboxSound = (CheckBox)sender;
            if (chboxResize2.Checked)
            {
                resize2 = @" -vf scale=""iw/2:ih/2"" ";
                //  format640x480 = " -s 640x480 ";
            }
            else
            {
                resize2 = "";
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
            // select file from computer         
            foreach (var rb in Controls.OfType<RadioButton>())
                if (rb.Checked)
                {
                    finalFormat = rb.Text != "png" ? (finalFormat = "." + rb.Text) : (finalFormat = "-%03d." + rb.Text);
                      //  finalFormat = "." + rb.Text;
                }
                // Configure open file dialog box
                OpenFileDialog selectFileDialog = new OpenFileDialog();
                selectFileDialog.Filter = "Videos(avi,mp4,mov,mkv,3gp,flv,mpg,ogg,wmv,webm)|*.avi;*.mp4;*.mov;*.mkv;*.3gp;*.flv;*.mpg;*.ogg;*.wmv;*.webm"; // Filter files by extension
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectFile = $" \"{selectFileDialog.FileName}\" ";
                    outFile = $"{selectFile.Remove(selectFile.Length - 6)}{finalFormat}\"";
                    outFps = $" -r {upDownFps.Value} ";
                    
                    finalCommand = "/c ffmpeg -i" + selectFile + outFps + resize2 + removeSound + outFile;
                //   MessageBox.Show(finalCommand); // testing final command
                // Converting
                    ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
                    procStartInfo.Arguments = finalCommand;
                    Process.Start(procStartInfo);
            }
        }

       
    }
}
