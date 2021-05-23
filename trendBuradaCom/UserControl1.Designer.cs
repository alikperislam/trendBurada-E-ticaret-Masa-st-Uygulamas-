namespace trendBuradaCom
{
    partial class UserControl1
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblEtiket = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnSepet = new System.Windows.Forms.Button();
            this.pFoto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kargo\r\nBedava\r\n";
            // 
            // lblEtiket
            // 
            this.lblEtiket.AutoSize = true;
            this.lblEtiket.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEtiket.ForeColor = System.Drawing.Color.Black;
            this.lblEtiket.Location = new System.Drawing.Point(3, 140);
            this.lblEtiket.Name = "lblEtiket";
            this.lblEtiket.Size = new System.Drawing.Size(274, 21);
            this.lblEtiket.TabIndex = 2;
            this.lblEtiket.Text = "Nike air max 2. nesil ayakkabı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Century Schoolbook", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFiyat.Location = new System.Drawing.Point(115, 156);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(113, 26);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "179,99 Tl";
            // 
            // btnSepet
            // 
            this.btnSepet.FlatAppearance.BorderSize = 0;
            this.btnSepet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            this.btnSepet.Location = new System.Drawing.Point(24, 68);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(188, 35);
            this.btnSepet.TabIndex = 6;
            this.btnSepet.Text = "Sepete Ekle";
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Visible = false;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // pFoto
            // 
            this.pFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pFoto.Image = ((System.Drawing.Image)(resources.GetObject("pFoto.Image")));
            this.pFoto.Location = new System.Drawing.Point(58, 3);
            this.pFoto.Name = "pFoto";
            this.pFoto.Size = new System.Drawing.Size(126, 134);
            this.pFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pFoto.TabIndex = 0;
            this.pFoto.TabStop = false;
            this.pFoto.Click += new System.EventHandler(this.pFoto_Click);
            this.pFoto.MouseLeave += new System.EventHandler(this.pictureFotograf_MouseLeave);
            this.pFoto.MouseHover += new System.EventHandler(this.pictureFotograf_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEtiket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pFoto);
            this.Font = new System.Drawing.Font("Century Schoolbook", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(244, 186);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pFoto;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblEtiket;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblFiyat;
        public System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.Timer timer1;
    }
}
