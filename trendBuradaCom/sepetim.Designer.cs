namespace trendBuradaCom
{
    partial class sepetim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEt = new System.Windows.Forms.Label();
            this.lblFi = new System.Windows.Forms.Label();
            this.dataG = new Guna.UI.WinForms.GunaDataGridView();
            this.sıra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunİsmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunRating = new System.Windows.Forms.DataGridViewImageColumn();
            this.urunAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOnay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEt
            // 
            this.lblEt.AutoSize = true;
            this.lblEt.Location = new System.Drawing.Point(152, 22);
            this.lblEt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEt.Name = "lblEt";
            this.lblEt.Size = new System.Drawing.Size(63, 21);
            this.lblEt.TabIndex = 1;
            this.lblEt.Text = "label1";
            this.lblEt.TextChanged += new System.EventHandler(this.lblEt_TextChanged);
            // 
            // lblFi
            // 
            this.lblFi.AutoSize = true;
            this.lblFi.Location = new System.Drawing.Point(234, 22);
            this.lblFi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFi.Name = "lblFi";
            this.lblFi.Size = new System.Drawing.Size(63, 21);
            this.lblFi.TabIndex = 2;
            this.lblFi.Text = "label2";
            this.lblFi.Click += new System.EventHandler(this.lblFi_Click);
            // 
            // dataG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataG.BackgroundColor = System.Drawing.Color.White;
            this.dataG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataG.ColumnHeadersHeight = 54;
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıra,
            this.urunİsmi,
            this.urunFiyati,
            this.urunRating,
            this.urunAdedi,
            this.btnOnay});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataG.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataG.EnableHeadersVisualStyles = false;
            this.dataG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataG.Location = new System.Drawing.Point(-1, 0);
            this.dataG.Margin = new System.Windows.Forms.Padding(2);
            this.dataG.Name = "dataG";
            this.dataG.RowHeadersVisible = false;
            this.dataG.RowHeadersWidth = 51;
            this.dataG.RowTemplate.Height = 24;
            this.dataG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataG.Size = new System.Drawing.Size(802, 560);
            this.dataG.TabIndex = 3;
            this.dataG.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot;
            this.dataG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dataG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dataG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dataG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataG.ThemeStyle.HeaderStyle.Height = 54;
            this.dataG.ThemeStyle.ReadOnly = false;
            this.dataG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dataG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataG.ThemeStyle.RowsStyle.Height = 24;
            this.dataG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataG_CellContentClick);
            this.dataG.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataG_RowHeaderMouseClick);
            this.dataG.SelectionChanged += new System.EventHandler(this.dataG_SelectionChanged);
            this.dataG.SizeChanged += new System.EventHandler(this.dataG_SizeChanged);
            this.dataG.TabIndexChanged += new System.EventHandler(this.dataG_TabIndexChanged);
            this.dataG.Click += new System.EventHandler(this.dataG_Click);
            this.dataG.DoubleClick += new System.EventHandler(this.dataG_DoubleClick);
            this.dataG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataG_MouseClick);
            this.dataG.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataG_MouseDoubleClick);
            // 
            // sıra
            // 
            this.sıra.HeaderText = "Sıra";
            this.sıra.MinimumWidth = 6;
            this.sıra.Name = "sıra";
            // 
            // urunİsmi
            // 
            this.urunİsmi.FillWeight = 140F;
            this.urunİsmi.HeaderText = "Ürün İsim";
            this.urunİsmi.MinimumWidth = 6;
            this.urunİsmi.Name = "urunİsmi";
            // 
            // urunFiyati
            // 
            this.urunFiyati.HeaderText = "Ürün Fiyat";
            this.urunFiyati.MinimumWidth = 6;
            this.urunFiyati.Name = "urunFiyati";
            // 
            // urunRating
            // 
            this.urunRating.HeaderText = "Ürün Puan";
            this.urunRating.Image = global::trendBuradaCom.Properties.Resources.Adsız;
            this.urunRating.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.urunRating.MinimumWidth = 6;
            this.urunRating.Name = "urunRating";
            // 
            // urunAdedi
            // 
            this.urunAdedi.HeaderText = "Ürün Durum";
            this.urunAdedi.MinimumWidth = 6;
            this.urunAdedi.Name = "urunAdedi";
            // 
            // btnOnay
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Onayla";
            this.btnOnay.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.HeaderText = "Onayla";
            this.btnOnay.MinimumWidth = 6;
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.ReadOnly = true;
            this.btnOnay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.ToolTipText = "Onayla";
            this.btnOnay.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataG);
            this.Controls.Add(this.lblFi);
            this.Controls.Add(this.lblEt);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "sepetim";
            this.Text = "sepetim";
            this.Load += new System.EventHandler(this.sepetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEt;
        private System.Windows.Forms.Label lblFi;
        public Guna.UI.WinForms.GunaDataGridView dataG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıra;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunİsmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyati;
        private System.Windows.Forms.DataGridViewImageColumn urunRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdedi;
        private System.Windows.Forms.DataGridViewButtonColumn btnOnay;
    }
}