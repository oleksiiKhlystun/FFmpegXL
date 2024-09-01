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
            this.btnSelConvert = new System.Windows.Forms.Button();
            this.upDownFps = new System.Windows.Forms.NumericUpDown();
            this.chboxResize2 = new System.Windows.Forms.CheckBox();
            this.chboxFps = new System.Windows.Forms.CheckBox();
            this.chboxTrim = new System.Windows.Forms.CheckBox();
            this.chboxTo = new System.Windows.Forms.CheckBox();
            this.mtxtTrim = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTo = new System.Windows.Forms.MaskedTextBox();
            this.chboxSpeedM2 = new System.Windows.Forms.CheckBox();
            this.chboxSpeedD2 = new System.Windows.Forms.CheckBox();
            this.toolTipRename = new System.Windows.Forms.ToolTip(this.components);
            this.btnRenameLast4 = new System.Windows.Forms.Button();
            this.toolTipFast = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelect = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnRectRecord = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTipGif = new System.Windows.Forms.ToolTip(this.components);
            this.LblAudio = new System.Windows.Forms.Label();
            this.lbl_Parametres = new System.Windows.Forms.Label();
            this.lbl_ext = new System.Windows.Forms.Label();
            this.lbl_RecordDesktop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPathSelectFolder = new System.Windows.Forms.Label();
            this.chboxVideo = new System.Windows.Forms.CheckBox();
            this.chboxAudio = new System.Windows.Forms.CheckBox();
            this.cmbBoxRecordAudio = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxOut = new System.Windows.Forms.ComboBox();
            this.cmbBoxConvertAudio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelConvert
            // 
            this.btnSelConvert.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelConvert.Location = new System.Drawing.Point(12, 217);
            this.btnSelConvert.Name = "btnSelConvert";
            this.btnSelConvert.Size = new System.Drawing.Size(134, 23);
            this.btnSelConvert.TabIndex = 5;
            this.btnSelConvert.Text = "Select Convert";
            this.toolTipSelect.SetToolTip(this.btnSelConvert, "You can select multiple files");
            this.btnSelConvert.UseVisualStyleBackColor = false;
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
            this.btnSelectFolder.Location = new System.Drawing.Point(8, 325);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(112, 26);
            this.btnSelectFolder.TabIndex = 34;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnRectRecord
            // 
            this.btnRectRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRectRecord.Location = new System.Drawing.Point(8, 370);
            this.btnRectRecord.Name = "btnRectRecord";
            this.btnRectRecord.Size = new System.Drawing.Size(112, 26);
            this.btnRectRecord.TabIndex = 35;
            this.btnRectRecord.Text = "Set Rectangle";
            this.btnRectRecord.UseVisualStyleBackColor = true;
            this.btnRectRecord.Click += new System.EventHandler(this.btnRectRecord_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(159, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 26);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // LblAudio
            // 
            this.LblAudio.AutoSize = true;
            this.LblAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblAudio.Location = new System.Drawing.Point(14, 84);
            this.LblAudio.Name = "LblAudio";
            this.LblAudio.Size = new System.Drawing.Size(44, 17);
            this.LblAudio.TabIndex = 27;
            this.LblAudio.Text = "Audio";
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
            this.lbl_RecordDesktop.Location = new System.Drawing.Point(14, 254);
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
            this.lblPathSelectFolder.Location = new System.Drawing.Point(9, 354);
            this.lblPathSelectFolder.Name = "lblPathSelectFolder";
            this.lblPathSelectFolder.Size = new System.Drawing.Size(51, 13);
            this.lblPathSelectFolder.TabIndex = 36;
            this.lblPathSelectFolder.Text = "Path: D:\\";
            // 
            // chboxVideo
            // 
            this.chboxVideo.AutoSize = true;
            this.chboxVideo.Checked = true;
            this.chboxVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxVideo.Location = new System.Drawing.Point(9, 274);
            this.chboxVideo.Name = "chboxVideo";
            this.chboxVideo.Size = new System.Drawing.Size(61, 21);
            this.chboxVideo.TabIndex = 38;
            this.chboxVideo.Text = "video";
            this.chboxVideo.UseVisualStyleBackColor = true;
            // 
            // chboxAudio
            // 
            this.chboxAudio.AutoSize = true;
            this.chboxAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxAudio.Location = new System.Drawing.Point(8, 301);
            this.chboxAudio.Name = "chboxAudio";
            this.chboxAudio.Size = new System.Drawing.Size(62, 21);
            this.chboxAudio.TabIndex = 39;
            this.chboxAudio.Text = "audio";
            this.chboxAudio.UseVisualStyleBackColor = true;
            // 
            // cmbBoxRecordAudio
            // 
            this.cmbBoxRecordAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbBoxRecordAudio.FormattingEnabled = true;
            this.cmbBoxRecordAudio.Location = new System.Drawing.Point(76, 298);
            this.cmbBoxRecordAudio.Name = "cmbBoxRecordAudio";
            this.cmbBoxRecordAudio.Size = new System.Drawing.Size(162, 21);
            this.cmbBoxRecordAudio.TabIndex = 40;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStop.Location = new System.Drawing.Point(6, 406);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(226, 13);
            this.lblStop.TabIndex = 41;
            this.lblStop.Text = "Stop Record: \"q\" in PowerShell, close window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "OR";
            // 
            // cmbBoxOut
            // 
            this.cmbBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxOut.FormattingEnabled = true;
            this.cmbBoxOut.Items.AddRange(new object[] {
            "mov",
            "mp4",
            "mp3",
            "gif",
            "png"});
            this.cmbBoxOut.Location = new System.Drawing.Point(157, 56);
            this.cmbBoxOut.Name = "cmbBoxOut";
            this.cmbBoxOut.Size = new System.Drawing.Size(79, 24);
            this.cmbBoxOut.TabIndex = 43;
            this.cmbBoxOut.Text = "mov";
            // 
            // cmbBoxConvertAudio
            // 
            this.cmbBoxConvertAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxConvertAudio.FormattingEnabled = true;
            this.cmbBoxConvertAudio.Items.AddRange(new object[] {
            "off",
            "64k",
            "128k"});
            this.cmbBoxConvertAudio.Location = new System.Drawing.Point(76, 81);
            this.cmbBoxConvertAudio.Name = "cmbBoxConvertAudio";
            this.cmbBoxConvertAudio.Size = new System.Drawing.Size(65, 24);
            this.cmbBoxConvertAudio.TabIndex = 44;
            this.cmbBoxConvertAudio.Text = "off";
            // 
            // toMovMp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 426);
            this.Controls.Add(this.cmbBoxConvertAudio);
            this.Controls.Add(this.cmbBoxOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.cmbBoxRecordAudio);
            this.Controls.Add(this.chboxAudio);
            this.Controls.Add(this.chboxVideo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPathSelectFolder);
            this.Controls.Add(this.btnRectRecord);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_RecordDesktop);
            this.Controls.Add(this.lbl_ext);
            this.Controls.Add(this.lbl_Parametres);
            this.Controls.Add(this.btnRenameLast4);
            this.Controls.Add(this.LblAudio);
            this.Controls.Add(this.chboxSpeedD2);
            this.Controls.Add(this.chboxSpeedM2);
            this.Controls.Add(this.mtxtTo);
            this.Controls.Add(this.mtxtTrim);
            this.Controls.Add(this.chboxTo);
            this.Controls.Add(this.chboxTrim);
            this.Controls.Add(this.chboxFps);
            this.Controls.Add(this.chboxResize2);
            this.Controls.Add(this.upDownFps);
            this.Controls.Add(this.btnSelConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "toMovMp4";
            this.Text = "toMov_XL";
            this.toolTipSelect.SetToolTip(this, "Install https://www.ffmpeg.org/");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelConvert;
        private System.Windows.Forms.NumericUpDown upDownFps;
        private System.Windows.Forms.CheckBox chboxResize2;
        private System.Windows.Forms.CheckBox chboxFps;
        private System.Windows.Forms.CheckBox chboxTrim;
        private System.Windows.Forms.CheckBox chboxTo;
        private System.Windows.Forms.MaskedTextBox mtxtTrim;
        private System.Windows.Forms.MaskedTextBox mtxtTo;
        private System.Windows.Forms.CheckBox chboxSpeedM2;
        private System.Windows.Forms.CheckBox chboxSpeedD2;
        private System.Windows.Forms.ToolTip toolTipRename;
        private System.Windows.Forms.ToolTip toolTipFast;
        private System.Windows.Forms.ToolTip toolTipSelect;
        private System.Windows.Forms.ToolTip toolTipGif;
        private System.Windows.Forms.Label LblAudio;
        private System.Windows.Forms.Button btnRenameLast4;
        private System.Windows.Forms.Label lbl_Parametres;
        private System.Windows.Forms.Label lbl_ext;
        private System.Windows.Forms.Label lbl_RecordDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnRectRecord;
        private System.Windows.Forms.Label lblPathSelectFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chboxVideo;
        private System.Windows.Forms.CheckBox chboxAudio;
        private System.Windows.Forms.ComboBox cmbBoxRecordAudio;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxOut;
        private System.Windows.Forms.ComboBox cmbBoxConvertAudio;
    }
}

