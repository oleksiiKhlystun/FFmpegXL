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
            this.chboxSound = new System.Windows.Forms.CheckBox();
            this.btnSelConvert = new System.Windows.Forms.Button();
            this.upDownFps = new System.Windows.Forms.NumericUpDown();
            this.radioBtn_png = new System.Windows.Forms.RadioButton();
            this.chboxResize2 = new System.Windows.Forms.CheckBox();
            this.chboxFps = new System.Windows.Forms.CheckBox();
            this.chboxTrim = new System.Windows.Forms.CheckBox();
            this.chboxFast = new System.Windows.Forms.CheckBox();
            this.chboxTo = new System.Windows.Forms.CheckBox();
            this.mtxtTrim = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDownFps)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtn_mov
            // 
            this.radioBtn_mov.AutoSize = true;
            this.radioBtn_mov.Checked = true;
            this.radioBtn_mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_mov.Location = new System.Drawing.Point(19, 97);
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
            this.radioBtn_mp4.Location = new System.Drawing.Point(88, 97);
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
            this.radioBtn_avi.Location = new System.Drawing.Point(19, 120);
            this.radioBtn_avi.Name = "radioBtn_avi";
            this.radioBtn_avi.Size = new System.Drawing.Size(44, 21);
            this.radioBtn_avi.TabIndex = 2;
            this.radioBtn_avi.Text = "avi";
            this.radioBtn_avi.UseVisualStyleBackColor = true;
            this.radioBtn_avi.CheckedChanged += new System.EventHandler(this.radioBtn_avi_CheckedChanged);
            // 
            // chboxSound
            // 
            this.chboxSound.AutoSize = true;
            this.chboxSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chboxSound.Location = new System.Drawing.Point(19, 42);
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
            this.btnSelConvert.Location = new System.Drawing.Point(19, 223);
            this.btnSelConvert.Name = "btnSelConvert";
            this.btnSelConvert.Size = new System.Drawing.Size(129, 23);
            this.btnSelConvert.TabIndex = 5;
            this.btnSelConvert.Text = "Select_Convert";
            this.btnSelConvert.UseVisualStyleBackColor = true;
            this.btnSelConvert.Click += new System.EventHandler(this.btnSelConvert_Click);
            // 
            // upDownFps
            // 
            this.upDownFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upDownFps.Location = new System.Drawing.Point(106, 11);
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
            this.radioBtn_png.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_png.Location = new System.Drawing.Point(88, 120);
            this.radioBtn_png.Name = "radioBtn_png";
            this.radioBtn_png.Size = new System.Drawing.Size(49, 20);
            this.radioBtn_png.TabIndex = 9;
            this.radioBtn_png.TabStop = true;
            this.radioBtn_png.Text = "png";
            this.radioBtn_png.UseVisualStyleBackColor = true;
            // 
            // chboxResize2
            // 
            this.chboxResize2.AutoSize = true;
            this.chboxResize2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxResize2.Location = new System.Drawing.Point(19, 70);
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
            this.chboxFps.Location = new System.Drawing.Point(19, 13);
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
            this.chboxTrim.Location = new System.Drawing.Point(19, 144);
            this.chboxTrim.Name = "chboxTrim";
            this.chboxTrim.Size = new System.Drawing.Size(82, 21);
            this.chboxTrim.TabIndex = 12;
            this.chboxTrim.Text = "trim from";
            this.chboxTrim.UseVisualStyleBackColor = true;
            this.chboxTrim.CheckedChanged += new System.EventHandler(this.chboxTrim_CheckedChanged);
            // 
            // chboxFast
            // 
            this.chboxFast.AutoSize = true;
            this.chboxFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxFast.Location = new System.Drawing.Point(19, 196);
            this.chboxFast.Name = "chboxFast";
            this.chboxFast.Size = new System.Drawing.Size(141, 21);
            this.chboxFast.TabIndex = 14;
            this.chboxFast.Text = "fast(copy params)";
            this.chboxFast.UseVisualStyleBackColor = true;
            this.chboxFast.CheckedChanged += new System.EventHandler(this.chboxFast_CheckedChanged);
            // 
            // chboxTo
            // 
            this.chboxTo.AutoSize = true;
            this.chboxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chboxTo.Location = new System.Drawing.Point(57, 169);
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
            this.mtxtTrim.Location = new System.Drawing.Point(98, 144);
            this.mtxtTrim.Mask = "00:00:00";
            this.mtxtTrim.Name = "mtxtTrim";
            this.mtxtTrim.Size = new System.Drawing.Size(50, 20);
            this.mtxtTrim.TabIndex = 19;
            this.mtxtTrim.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtTo
            // 
            this.mtxtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtTo.Location = new System.Drawing.Point(98, 169);
            this.mtxtTo.Mask = "00:00:00";
            this.mtxtTo.Name = "mtxtTo";
            this.mtxtTo.Size = new System.Drawing.Size(50, 20);
            this.mtxtTo.TabIndex = 20;
            this.mtxtTo.ValidatingType = typeof(System.DateTime);
            // 
            // toMovMp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 253);
            this.Controls.Add(this.mtxtTo);
            this.Controls.Add(this.mtxtTrim);
            this.Controls.Add(this.chboxTo);
            this.Controls.Add(this.chboxFast);
            this.Controls.Add(this.chboxTrim);
            this.Controls.Add(this.chboxFps);
            this.Controls.Add(this.chboxResize2);
            this.Controls.Add(this.radioBtn_png);
            this.Controls.Add(this.upDownFps);
            this.Controls.Add(this.btnSelConvert);
            this.Controls.Add(this.chboxSound);
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
        private System.Windows.Forms.CheckBox chboxSound;
        private System.Windows.Forms.Button btnSelConvert;
        private System.Windows.Forms.NumericUpDown upDownFps;
        private System.Windows.Forms.RadioButton radioBtn_png;
        private System.Windows.Forms.CheckBox chboxResize2;
        private System.Windows.Forms.CheckBox chboxFps;
        private System.Windows.Forms.CheckBox chboxTrim;
        private System.Windows.Forms.CheckBox chboxFast;
        private System.Windows.Forms.CheckBox chboxTo;
        private System.Windows.Forms.MaskedTextBox mtxtTrim;
        private System.Windows.Forms.MaskedTextBox mtxtTo;
    }
}
