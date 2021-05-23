namespace trendBuradaCom
{
    partial class frmBilgi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataB = new Guna.UI.WinForms.GunaDataGridView();
            this.sıra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunİsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataB
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dataB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataB.BackgroundColor = System.Drawing.Color.White;
            this.dataB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataB.ColumnHeadersHeight = 27;
            this.dataB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıra,
            this.adSoyad,
            this.adres,
            this.urunİsim,
            this.urunFiyat});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataB.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataB.EnableHeadersVisualStyles = false;
            this.dataB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataB.Location = new System.Drawing.Point(0, 0);
            this.dataB.Name = "dataB";
            this.dataB.RowHeadersVisible = false;
            this.dataB.RowHeadersWidth = 51;
            this.dataB.RowTemplate.Height = 24;
            this.dataB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataB.Size = new System.Drawing.Size(801, 506);
            this.dataB.TabIndex = 0;
            this.dataB.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dataB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dataB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dataB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataB.ThemeStyle.HeaderStyle.Height = 27;
            this.dataB.ThemeStyle.ReadOnly = false;
            this.dataB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dataB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataB.ThemeStyle.RowsStyle.Height = 24;
            this.dataB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataB_CellContentClick);
            // 
            // sıra
            // 
            this.sıra.HeaderText = "Sıra";
            this.sıra.MinimumWidth = 6;
            this.sıra.Name = "sıra";
            // 
            // adSoyad
            // 
            this.adSoyad.HeaderText = "Ad Soyad";
            this.adSoyad.MinimumWidth = 6;
            this.adSoyad.Name = "adSoyad";
            // 
            // adres
            // 
            this.adres.HeaderText = "Adres";
            this.adres.MinimumWidth = 6;
            this.adres.Name = "adres";
            // 
            // urunİsim
            // 
            this.urunİsim.HeaderText = "Ürün İsim";
            this.urunİsim.MinimumWidth = 6;
            this.urunİsim.Name = "urunİsim";
            // 
            // urunFiyat
            // 
            this.urunFiyat.HeaderText = "Ürün Fiyat";
            this.urunFiyat.MinimumWidth = 6;
            this.urunFiyat.Name = "urunFiyat";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            this.btnEkle.Location = new System.Drawing.Point(228, 512);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(189, 46);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "GÜNCELLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            this.button1.Location = new System.Drawing.Point(423, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataB);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBilgi";
            this.Text = "frmBilgi";
            this.Load += new System.EventHandler(this.frmBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn sıra;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunİsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyat;
        public Guna.UI.WinForms.GunaDataGridView dataB;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
    }
}