﻿using System;

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
            this.radioBtn_mov = new System.Windows.Forms.RadioButton();
            this.radioBtn_mp4 = new System.Windows.Forms.RadioButton();
            this.radioBtn_avi = new System.Windows.Forms.RadioButton();
            this.radioBtn_mkv = new System.Windows.Forms.RadioButton();
            this.chboxSound = new System.Windows.Forms.CheckBox();
            this.btnSelConvert = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.upDownFps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtn_mov
            // 
            this.radioBtn_mov.AutoSize = true;
            this.radioBtn_mov.Checked = true;
            this.radioBtn_mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_mov.Location = new System.Drawing.Point(15, 66);
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
            this.radioBtn_mp4.Location = new System.Drawing.Point(69, 66);
            this.radioBtn_mp4.Name = "radioBtn_mp4";
            this.radioBtn_mp4.Size = new System.Drawing.Size(53, 21);
            this.radioBtn_mp4.TabIndex = 1;
            this.radioBtn_mp4.Text = "mp4";
            this.radioBtn_mp4.UseVisualStyleBackColor = true;
            this.radioBtn_mp4.CheckedChanged += new System.EventHandler(this.radioBtn_mp4_CheckedChanged);
            // 
            // radioBtn_avi
            // 
            this.radioBtn_avi.AutoSize = true;
            this.radioBtn_avi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_avi.Location = new System.Drawing.Point(15, 89);
            this.radioBtn_avi.Name = "radioBtn_avi";
            this.radioBtn_avi.Size = new System.Drawing.Size(44, 21);
            this.radioBtn_avi.TabIndex = 2;
            this.radioBtn_avi.Text = "avi";
            this.radioBtn_avi.UseVisualStyleBackColor = true;
            this.radioBtn_avi.CheckedChanged += new System.EventHandler(this.radioBtn_avi_CheckedChanged);
            // 
            // radioBtn_mkv
            // 
            this.radioBtn_mkv.AutoSize = true;
            this.radioBtn_mkv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_mkv.Location = new System.Drawing.Point(69, 89);
            this.radioBtn_mkv.Name = "radioBtn_mkv";
            this.radioBtn_mkv.Size = new System.Drawing.Size(51, 21);
            this.radioBtn_mkv.TabIndex = 3;
            this.radioBtn_mkv.Text = "mkv";
            this.radioBtn_mkv.UseVisualStyleBackColor = true;
            this.radioBtn_mkv.CheckedChanged += new System.EventHandler(this.radioBtn_mkv_CheckedChanged);
            // 
            // chboxSound
            // 
            this.chboxSound.AutoSize = true;
            this.chboxSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chboxSound.Location = new System.Drawing.Point(15, 46);
            this.chboxSound.Name = "chboxSound";
            this.chboxSound.Size = new System.Drawing.Size(117, 21);
            this.chboxSound.TabIndex = 4;
            this.chboxSound.Text = "remove sound";
            this.chboxSound.UseVisualStyleBackColor = true;
            this.chboxSound.CheckedChanged += new System.EventHandler(this.chboxSound_CheckedChanged);
            // 
            // btnSelConvert
            // 
            this.btnSelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelConvert.Location = new System.Drawing.Point(15, 116);
            this.btnSelConvert.Name = "btnSelConvert";
            this.btnSelConvert.Size = new System.Drawing.Size(122, 23);
            this.btnSelConvert.TabIndex = 5;
            this.btnSelConvert.Text = "Select_Convert";
            this.btnSelConvert.UseVisualStyleBackColor = true;
            this.btnSelConvert.Click += new System.EventHandler(this.btnSelConvert_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Finish fps";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // upDownFps
            // 
            this.upDownFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upDownFps.Location = new System.Drawing.Point(95, 17);
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
            // toMovMp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 159);
            this.Controls.Add(this.upDownFps);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSelConvert);
            this.Controls.Add(this.chboxSound);
            this.Controls.Add(this.radioBtn_mkv);
            this.Controls.Add(this.radioBtn_avi);
            this.Controls.Add(this.radioBtn_mp4);
            this.Controls.Add(this.radioBtn_mov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "toMovMp4";
            this.Text = "xl_toMovMp4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_mov;
        private System.Windows.Forms.RadioButton radioBtn_mp4;
        private System.Windows.Forms.RadioButton radioBtn_avi;
        private System.Windows.Forms.RadioButton radioBtn_mkv;
        private System.Windows.Forms.CheckBox chboxSound;
        private System.Windows.Forms.Button btnSelConvert;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown upDownFps;
    }
}

