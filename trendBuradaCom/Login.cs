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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            signIn sgn = new signIn();
            sgn.Show();
            this.Hide();

        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select  * from login0 where dbKullaniciAdi=@p1 and dbParola=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtUsername.Text);
            komut.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader rd = komut.ExecuteReader();//komuttan gelen verileri datareader ile okuyacak.

            if (rd.Read()) // eğer verilerin hepsi doğru  bir şekilde okunabiliyorsa :
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }          
        }
    }
}
