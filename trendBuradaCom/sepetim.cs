using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace trendBuradaCom
{
    public partial class sepetim : Form
    {
        public sepetim()
        {
            InitializeComponent();
        }
        public string et=Properties.Settings.Default.aEtiket;
        public string fi=Properties.Settings.Default.aFiyat;

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void sepetim_Load(object sender, EventArgs e)
        {
            
            //int deger = int.Parse(Properties.Settings.Default.sayi);
            UserControl1 u = new UserControl1();
            
            lblEt.Text = et;
            lblFi.Text = fi;

            SqlCommand komut = new SqlCommand("select * from dbSepet0", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dataG.Rows.Add(dr[0], dr[1], dr[2], Properties.Resources.Adsız, "True");
            }







        }
        public int sa = 0;
        private void denemeFoto_Click(object sender, EventArgs e)
        {

        }

        private void lblEt_TextChanged(object sender, EventArgs e)
        {
            sa++;
            
        }

        private void dataG_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataG_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dataG_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //sa++;
            //dataG.Rows.Add(sa, et, fi, Properties.Resources.Adsız);
        }

        private void dataG_Click(object sender, EventArgs e)
        {
            // seçili satırın seçili elemanını çekiyoruz.
            label1.Text = dataG.CurrentRow.Cells[1].Value.ToString();
            label2.Text = dataG.CurrentRow.Cells[2].Value.ToString();

            Properties.Settings.Default.siparisFiyat = dataG.CurrentRow.Cells[2].Value.ToString();
            Properties.Settings.Default.siparisEtiket = dataG.CurrentRow.Cells[1].Value.ToString();


        }

        private void dataG_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataG_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblFi_Click(object sender, EventArgs e)
        {

        }

        private void dataG_DoubleClick(object sender, EventArgs e)
        {
            
                
            
            
        }

        private void dataG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
