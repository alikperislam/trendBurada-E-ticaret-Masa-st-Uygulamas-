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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        sqlBaglantisi bgl = new sqlBaglantisi(); // sql sınıfı 
        private void button1_Click(object sender, EventArgs e)
        {
            if (signUsername.Text==signUsername2.Text && signPassword.Text==signPassword2.Text)
            {

                //komut için:
                SqlCommand komut = new SqlCommand("insert into login0(dbKullaniciAdi,dbParola) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", signUsername.Text);// parametreye değer atama işlemi.
                komut.Parameters.AddWithValue("@p2", signPassword.Text);
                komut.ExecuteNonQuery();// sql komutlarını çalıştır.
                bgl.baglanti().Close();//bağlantıyı bitir.


                // login getir:
                Login lg = new Login();
                lg.Show();
                this.Hide();

            }           
        }
    }
}
