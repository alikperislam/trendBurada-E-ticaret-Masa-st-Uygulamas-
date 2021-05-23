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
    public partial class frmBilgi : Form
    {
        public frmBilgi()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmBilgi_Load(object sender, EventArgs e)
        {
            //label1.Text = Properties.Settings.Default.sa;
            SqlCommand komut = new SqlCommand("select * from dbBilgiler0",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dataB.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }

        }

        private void dataB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            //dataB.Rows.Add(1, Properties.Settings.Default.pNumara, "osmangazi", "Calvin klein", "79,87 TL");
           //dataB.Rows.Add(2, "Alikper islam", "osmangazi", "Calvin klein", "79,87 TL");
            //dataB.Rows.Add(3, "Alikper islam", "osmangazi", "Calvin klein", "79,87 TL");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            
                string yazi = "update dbBilgiler0 set bilgiAdSoyad=@p1,bilgiAdres=@p2,bilgiUrunİsim=@p3,bilgiFiyat=@p4 WHERE bilgiId=@p5 ";
                SqlCommand komut0 = new SqlCommand(yazi, bgl.baglanti());
                komut0.Parameters.AddWithValue("@p1", dataB.CurrentRow.Cells[1].Value);
                komut0.Parameters.AddWithValue("@p2", dataB.CurrentRow.Cells[2].Value);
                komut0.Parameters.AddWithValue("@p3", dataB.CurrentRow.Cells[3].Value);
                komut0.Parameters.AddWithValue("@p4", dataB.CurrentRow.Cells[4].Value);
                komut0.Parameters.AddWithValue("@p5", dataB.CurrentRow.Cells[0].Value);
                komut0.ExecuteNonQuery();
                bgl.baglanti().Close();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sil = "delete from dbBilgiler0 WHERE bilgiId=@p1 ";
            SqlCommand komut1 = new SqlCommand(sil, bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", dataB.CurrentRow.Cells[0].Value);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
