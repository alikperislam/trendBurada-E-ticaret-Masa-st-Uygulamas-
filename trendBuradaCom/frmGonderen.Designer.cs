﻿namespace trendBuradaCom
{
    partial class frmGonderen
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
            this.gonderFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gonderFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gonderFoto
            // 
            this.gonderFoto.Location = new System.Drawing.Point(254, 68);
            this.gonderFoto.Name = "gonderFoto";
            this.gonderFoto.Size = new System.Drawing.Size(186, 160);
            this.gonderFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gonderFoto.TabIndex = 0;
            this.gonderFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmGonderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gonderFoto);
            this.Name = "frmGonderen";
            this.Text = "frmGonderen";
            this.Load += new System.EventHandler(this.frmGonderen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gonderFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox gonderFoto;
        public System.Windows.Forms.Label label1;
    }
}