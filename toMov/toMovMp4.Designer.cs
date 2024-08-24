using System;

namespace toMov
{
    partial class toMovMp4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioBtn_mov = new System.Windows.Forms.RadioButton();
            this.radioBtn_mp4 = new System.Windows.Forms.RadioButton();
            this.chboxSoundOff = new System.Windows.Forms.CheckBox();
            this.btnSelConvert = new System.Windows.Forms.Button();
            this.upDownFps = new System.Windows.Forms.NumericUpDown();
            this.radioBtn_png = new System.Windows.Forms.RadioButton();
            this.chboxResize2 = new System.Windows.Forms.CheckBox();
            this.chboxFps = new System.Windows.Forms.CheckBox();
            this.chboxTrim = new System.Windows.Forms.CheckBox();
            this.chboxTo = new System.Windows.Forms.CheckBox();
            this.mtxtTrim = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTo = new System.Windows.Forms.MaskedTextBox();
            this.chboxSpeedM2 = new System.Windows.Forms.CheckBox();
            this.chboxSpeedD2 = new System.Windows.Forms.CheckBox();
            this.radioBtn_gif = new System.Windows.Forms.RadioButton();
            this.btnFastConvert = new System.Windows.Forms.Button();
            this.labelCopy = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.toolTipRename = new System.Windows.Forms.ToolTip(this.components);
            this.btnRenameLast4 = new System.Windows.Forms.Button();
            this.toolTipFast = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelect = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnRectRecord = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTipGif = new System.Windows.Forms.ToolTip(this.components);
            this.chboxSound64k = new System.Windows.Forms.CheckBox();
            this.LblSound = new System.Windows.Forms.Label();
            this.radioBtn_mp3 = new System.Windows.Forms.RadioButton();
            this.lbl_Parametres = new System.Windows.Forms.Label();
            this.lbl_ext = new System.Windows.Forms.Label();
            this.lbl_RecordDesktop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPathSelectFolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtn_mov
            // 
            this.radioBtn_mov.AutoSize = true;
            this.radioBtn_mov.Checked = true;
            this.radioBtn_mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_mov.Location = new System.Drawing.Point(162, 54);
            this.radioBtn_mov.Name = "radioBtn_mov";
            this.radioBtn_mov.Size = new System.Drawing.Size(52, 21);
            this.radioBtn_mov.TabIndex = 0;
            this.radioBtn_mov.TabStop = true;
            this.radioBtn_mov.Text = "mov";
            this.radioBtn_mov.UseVisualStyleBackColor = true;
            this.radioBtn_mov.CheckedChanged += new System.EventHandler(this.radioBtn_mov_CheckedChanged);
            // 
            // radioBtn_mp4
            // 
            this.radioBtn_mp4.AutoSize = true;
            this.radioBtn_mp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_mp4.Location = new System.Drawing.Point(162, 136);
            this.radioBtn_mp4.Name = "radioBtn_mp4";
            this.radioBtn_mp4.Size = new System.Drawing.Size(53, 21);
            this.radioBtn_mp4.TabIndex = 1;
            this.radioBtn_mp4.Text = "mp4";
            this.radioBtn_mp4.UseVisualStyleBackColor = true;
            this.radioBtn_mp4.CheckedChanged += new System.EventHandler(this.radioBtn_mp4_CheckedChanged);
            // 
            // chboxSoundOff
            // 
            this.chboxSoundOff.AutoSize = true;
            this.chboxSoundOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chboxSoundOff.Location = new System.Drawing.Point(63, 83);
            this.chboxSoundOff.Name = "chboxSoundOff";
            this.chboxSoundOff.Size = new System.Drawing.Size(43, 21);
            this.chboxSoundOff.TabIndex = 4;
            this.chboxSoundOff.Text = "off";
            this.chboxSoundOff.UseVisualStyleBackColor = true;
            this.chboxSoundOff.CheckedChanged += new System.EventHandler(this.chboxSound_CheckedChanged);
            // 
            // btnSelConvert
            // 
            this.btnSelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelConvert.Location = new System.Drawing.Point(12, 217);
            this.btnSelConvert.Name = "btnSelConvert";
            this.btnSelConvert.Size = new System.Drawing.Size(129, 23);
            this.btnSelConvert.TabIndex = 5;
            this.btnSelConvert.Text = "Select Convert";
            this.toolTipSelect.SetToolTip(this.btnSelConvert, "You can select multiple files");
            this.btnSelConvert.UseVisualStyleBackColor = true;
            this.btnSelConvert.Click += new System.EventHandler(this.btnSelConvert_Click);
            // 
            // upDownFps
            // 
            this.upDownFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upDownFps.Location = new System.Drawing.Point(99, 54);
            this.upDownFps.Name = "upDownFps";
            this.upDownFps.Size = new System.Drawing.Size(42, 23);
            this.upDownFps.TabIndex = 7;
            this.upDownFps.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.upDownFps.ValueChanged += new System.EventHandler(this.upDownFps_ValueChanged);
            // 
            // radioBtn_png
            // 
            this.radioBtn_png.AutoSize = true;
            this.radioBtn_png.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_png.Location = new System.Drawing.Point(162, 163);
            this.radioBtn_png.Name = "radioBtn_png";
            this.radioBtn_png.Size = new System.Drawing.Size(50, 21);
            this.radioBtn_png.TabIndex = 9;
            this.radioBtn_png.TabStop = true;
            this.radioBtn_png.Text = "png";
            this.radioBtn_png.UseVisualStyleBackColor = true;
            // 
            // chboxResize2
            // 
            this.chboxResize2.AutoSize = true;
            this.chboxResize2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxResize2.Location = new System.Drawing.Point(17, 110);
            this.chboxResize2.Name = "chboxResize2";
            this.chboxResize2.Size = new System.Drawing.Size(77, 21);
            this.chboxResize2.TabIndex = 10;
            this.chboxResize2.Text = "resize\\2";
            this.chboxResize2.UseVisualStyleBackColor = true;
            this.chboxResize2.CheckedChanged += new System.EventHandler(this.chboxResize2_CheckedChanged);
            // 
            // chboxFps
            // 
            this.chboxFps.AutoSize = true;
            this.chboxFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxFps.Location = new System.Drawing.Point(17, 56);
            this.chboxFps.Name = "chboxFps";
            this.chboxFps.Size = new System.Drawing.Size(76, 21);
            this.chboxFps.TabIndex = 11;
            this.chboxFps.Text = "final fps";
            this.chboxFps.UseVisualStyleBackColor = true;
            this.chboxFps.CheckedChanged += new System.EventHandler(this.chboxFps_CheckedChanged);
            // 
            // chboxTrim
            // 
            this.chboxTrim.AutoSize = true;
            this.chboxTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxTrim.Location = new System.Drawing.Point(17, 164);
            this.chboxTrim.Name = "chboxTrim";
            this.chboxTrim.Size = new System.Drawing.Size(82, 21);
            this.chboxTrim.TabIndex = 12;
            this.chboxTrim.Text = "trim from";
            this.chboxTrim.UseVisualStyleBackColor = true;
            this.chboxTrim.CheckedChanged += new System.EventHandler(this.chboxTrim_CheckedChanged);
            // 
            // chboxTo
            // 
            this.chboxTo.AutoSize = true;
            this.chboxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxTo.Location = new System.Drawing.Point(55, 191);
            this.chboxTo.Name = "chboxTo";
            this.chboxTo.Size = new System.Drawing.Size(39, 21);
            this.chboxTo.TabIndex = 18;
            this.chboxTo.Text = "to";
            this.chboxTo.UseVisualStyleBackColor = true;
            this.chboxTo.CheckedChanged += new System.EventHandler(this.chboxTo_CheckedChanged);
            // 
            // mtxtTrim
            // 
            this.mtxtTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtTrim.Location = new System.Drawing.Point(96, 164);
            this.mtxtTrim.Mask = "00:00:00";
            this.mtxtTrim.Name = "mtxtTrim";
            this.mtxtTrim.Size = new System.Drawing.Size(50, 20);
            this.mtxtTrim.TabIndex = 19;
            this.mtxtTrim.Text = "000000";
            this.mtxtTrim.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtTo
            // 
            this.mtxtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtTo.Location = new System.Drawing.Point(96, 191);
            this.mtxtTo.Mask = "00:00:00";
            this.mtxtTo.Name = "mtxtTo";
            this.mtxtTo.Size = new System.Drawing.Size(50, 20);
            this.mtxtTo.TabIndex = 20;
            this.mtxtTo.Text = "000000";
            this.mtxtTo.ValidatingType = typeof(System.DateTime);
            // 
            // chboxSpeedM2
            // 
            this.chboxSpeedM2.AutoSize = true;
            this.chboxSpeedM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxSpeedM2.Location = new System.Drawing.Point(17, 137);
            this.chboxSpeedM2.Name = "chboxSpeedM2";
            this.chboxSpeedM2.Size = new System.Drawing.Size(96, 21);
            this.chboxSpeedM2.TabIndex = 21;
            this.chboxSpeedM2.Text = "speed*2 or";
            this.chboxSpeedM2.UseVisualStyleBackColor = true;
            this.chboxSpeedM2.CheckedChanged += new System.EventHandler(this.chboxSpeedM2_CheckedChanged);
            // 
            // chboxSpeedD2
            // 
            this.chboxSpeedD2.AutoSize = true;
            this.chboxSpeedD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxSpeedD2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chboxSpeedD2.Location = new System.Drawing.Point(107, 137);
            this.chboxSpeedD2.Name = "chboxSpeedD2";
            this.chboxSpeedD2.Size = new System.Drawing.Size(39, 21);
            this.chboxSpeedD2.TabIndex = 22;
            this.chboxSpeedD2.Text = "/2";
            this.chboxSpeedD2.UseVisualStyleBackColor = true;
            this.chboxSpeedD2.CheckedChanged += new System.EventHandler(this.chboxSpeedD2_CheckedChanged);
            // 
            // radioBtn_gif
            // 
            this.radioBtn_gif.AutoSize = true;
            this.radioBtn_gif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtn_gif.Location = new System.Drawing.Point(162, 109);
            this.radioBtn_gif.Name = "radioBtn_gif";
            this.radioBtn_gif.Size = new System.Drawing.Size(41, 21);
            this.radioBtn_gif.TabIndex = 23;
            this.radioBtn_gif.TabStop = true;
            this.radioBtn_gif.Text = "gif";
            this.toolTipGif.SetToolTip(this.radioBtn_gif, "scale weight 640:-1");
            this.radioBtn_gif.UseVisualStyleBackColor = true;
            this.radioBtn_gif.CheckedChanged += new System.EventHandler(this.radioBtn_gif_CheckedChanged);
            // 
            // btnFastConvert
            // 
            this.btnFastConvert.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFastConvert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastConvert.Location = new System.Drawing.Point(12, 246);
            this.btnFastConvert.Name = "btnFastConvert";
            this.btnFastConvert.Size = new System.Drawing.Size(52, 23);
            this.btnFastConvert.TabIndex = 24;
            this.btnFastConvert.Text = "Fast";
            this.toolTipFast.SetToolTip(this.btnFastConvert, "Copy all parameters(any chkbox not working)");
            this.btnFastConvert.UseVisualStyleBackColor = false;
            this.btnFastConvert.Click += new System.EventHandler(this.btnFastConvert_Click);
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.Location = new System.Drawing.Point(65, 251);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(76, 13);
            this.labelCopy.TabIndex = 25;
            this.labelCopy.Text = "(copy param-s)";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(207, 163);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(17, 20);
            this.btnRename.TabIndex = 26;
            this.btnRename.Text = "r";
            this.toolTipRename.SetToolTip(this.btnRename, "Rename selected png to 0001,0002...Need if convert from png");
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnRenameLast4
            // 
            this.btnRenameLast4.Location = new System.Drawing.Point(162, 217);
            this.btnRenameLast4.Name = "btnRenameLast4";
            this.btnRenameLast4.Size = new System.Drawing.Size(79, 23);
            this.btnRenameLast4.TabIndex = 28;
            this.btnRenameLast4.Text = "Last4delete";
            this.toolTipRename.SetToolTip(this.btnRenameLast4, "Rename - delete last 4 symbols (file6953->file).");
            this.btnRenameLast4.UseVisualStyleBackColor = true;
            this.btnRenameLast4.Click += new System.EventHandler(this.btnRenameLast4_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 296);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(112, 23);
            this.btnSelectFolder.TabIndex = 34;
            this.btnSelectFolder.Text = "1) Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnRectRecord
            // 
            this.btnRectRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRectRecord.Location = new System.Drawing.Point(12, 342);
            this.btnRectRecord.Name = "btnRectRecord";
            this.btnRectRecord.Size = new System.Drawing.Size(112, 29);
            this.btnRectRecord.TabIndex = 35;
            this.btnRectRecord.Text = "2) Rectangle";
            this.btnRectRecord.UseVisualStyleBackColor = true;
            this.btnRectRecord.Click += new System.EventHandler(this.btnRectRecord_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(179, 342);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 34);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chboxSound64k
            // 
            this.chboxSound64k.AutoSize = true;
            this.chboxSound64k.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chboxSound64k.Location = new System.Drawing.Point(101, 83);
            this.chboxSound64k.Name = "chboxSound64k";
            this.chboxSound64k.Size = new System.Drawing.Size(50, 21);
            this.chboxSound64k.TabIndex = 4;
            this.chboxSound64k.Text = "64k";
            this.chboxSound64k.UseVisualStyleBackColor = true;
            this.chboxSound64k.CheckedChanged += new System.EventHandler(this.chboxSound_CheckedChanged);
            // 
            // LblSound
            // 
            this.LblSound.AutoSize = true;
            this.LblSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSound.Location = new System.Drawing.Point(14, 84);
            this.LblSound.Name = "LblSound";
            this.LblSound.Size = new System.Drawing.Size(49, 17);
            this.LblSound.TabIndex = 27;
            this.LblSound.Text = "Sound";
            // 
            // radioBtn_mp3
            // 
            this.radioBtn_mp3.AutoSize = true;
            this.radioBtn_mp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_mp3.Location = new System.Drawing.Point(162, 82);
            this.radioBtn_mp3.Name = "radioBtn_mp3";
            this.radioBtn_mp3.Size = new System.Drawing.Size(53, 21);
            this.radioBtn_mp3.TabIndex = 29;
            this.radioBtn_mp3.Text = "mp3";
            this.radioBtn_mp3.UseVisualStyleBackColor = true;
            // 
            // lbl_Parametres
            // 
            this.lbl_Parametres.AutoSize = true;
            this.lbl_Parametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Parametres.Location = new System.Drawing.Point(12, 34);
            this.lbl_Parametres.Name = "lbl_Parametres";
            this.lbl_Parametres.Size = new System.Drawing.Size(71, 15);
            this.lbl_Parametres.TabIndex = 30;
            this.lbl_Parametres.Text = "Parametres";
            // 
            // lbl_ext
            // 
            this.lbl_ext.AutoSize = true;
            this.lbl_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ext.Location = new System.Drawing.Point(159, 34);
            this.lbl_ext.Name = "lbl_ext";
            this.lbl_ext.Size = new System.Drawing.Size(26, 15);
            this.lbl_ext.TabIndex = 31;
            this.lbl_ext.Text = "Out";
            // 
            // lbl_RecordDesktop
            // 
            this.lbl_RecordDesktop.AutoSize = true;
            this.lbl_RecordDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_RecordDesktop.Location = new System.Drawing.Point(17, 276);
            this.lbl_RecordDesktop.Name = "lbl_RecordDesktop";
            this.lbl_RecordDesktop.Size = new System.Drawing.Size(233, 17);
            this.lbl_RecordDesktop.TabIndex = 32;
            this.lbl_RecordDesktop.Text = "===== RECORD DESKTOP ======";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "======= CONVERT FILES ========";
            // 
            // lblPathSelectFolder
            // 
            this.lblPathSelectFolder.AutoSize = true;
            this.lblPathSelectFolder.Location = new System.Drawing.Point(14, 322);
            this.lblPathSelectFolder.Name = "lblPathSelectFolder";
            this.lblPathSelectFolder.Size = new System.Drawing.Size(32, 13);
            this.lblPathSelectFolder.TabIndex = 36;
            this.lblPathSelectFolder.Text = "Path:";
            // 
            // toMovMp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 388);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPathSelectFolder);
            this.Controls.Add(this.btnRectRecord);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_RecordDesktop);
            this.Controls.Add(this.lbl_ext);
            this.Controls.Add(this.lbl_Parametres);
            this.Controls.Add(this.radioBtn_mp3);
            this.Controls.Add(this.btnRenameLast4);
            this.Controls.Add(this.LblSound);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.btnFastConvert);
            this.Controls.Add(this.radioBtn_gif);
            this.Controls.Add(this.chboxSpeedD2);
            this.Controls.Add(this.chboxSpeedM2);
            this.Controls.Add(this.mtxtTo);
            this.Controls.Add(this.mtxtTrim);
            this.Controls.Add(this.chboxTo);
            this.Controls.Add(this.chboxTrim);
            this.Controls.Add(this.chboxFps);
            this.Controls.Add(this.chboxResize2);
            this.Controls.Add(this.radioBtn_png);
            this.Controls.Add(this.upDownFps);
            this.Controls.Add(this.btnSelConvert);
            this.Controls.Add(this.chboxSound64k);
            this.Controls.Add(this.chboxSoundOff);
            this.Controls.Add(this.radioBtn_mp4);
            this.Controls.Add(this.radioBtn_mov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "toMovMp4";
            this.Text = "xl_toMovMp4";
            this.toolTipSelect.SetToolTip(this, "Install https://www.ffmpeg.org/");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_mov;
        private System.Windows.Forms.RadioButton radioBtn_mp4;
        private System.Windows.Forms.CheckBox chboxSoundOff;
        private System.Windows.Forms.Button btnSelConvert;
        private System.Windows.Forms.NumericUpDown upDownFps;
        private System.Windows.Forms.RadioButton radioBtn_png;
        private System.Windows.Forms.CheckBox chboxResize2;
        private System.Windows.Forms.CheckBox chboxFps;
        private System.Windows.Forms.CheckBox chboxTrim;
        private System.Windows.Forms.CheckBox chboxTo;
        private System.Windows.Forms.MaskedTextBox mtxtTrim;
        private System.Windows.Forms.MaskedTextBox mtxtTo;
        private System.Windows.Forms.CheckBox chboxSpeedM2;
        private System.Windows.Forms.CheckBox chboxSpeedD2;
        private System.Windows.Forms.RadioButton radioBtn_gif;
        private System.Windows.Forms.Button btnFastConvert;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ToolTip toolTipRename;
        private System.Windows.Forms.ToolTip toolTipFast;
        private System.Windows.Forms.ToolTip toolTipSelect;
        private System.Windows.Forms.ToolTip toolTipGif;
        private System.Windows.Forms.CheckBox chboxSound64k;
        private System.Windows.Forms.Label LblSound;
        private System.Windows.Forms.Button btnRenameLast4;
        private System.Windows.Forms.RadioButton radioBtn_mp3;
        private System.Windows.Forms.Label lbl_Parametres;
        private System.Windows.Forms.Label lbl_ext;
        private System.Windows.Forms.Label lbl_RecordDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnRectRecord;
        private System.Windows.Forms.Label lblPathSelectFolder;
        private System.Windows.Forms.Button btnStart;
    }
}

