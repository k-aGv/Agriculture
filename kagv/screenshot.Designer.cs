﻿namespace kagv
{
    partial class screenshot
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
            this.SuspendLayout();
            // 
            // screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "screenshot";
            this.Text = "screenshot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.screenshot_FormClosing);
            this.Load += new System.EventHandler(this.screenshot_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.screenshot_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.screenshot_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.screenshot_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.screenshot_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}