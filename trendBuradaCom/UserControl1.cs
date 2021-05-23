using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;


namespace trendBuradaCom
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnSepet_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureFotograf_MouseHover(object sender, EventArgs e)
        {
            btnSepet.Visible = true;
        }
        
        private void pictureFotograf_MouseLeave(object sender, EventArgs e)
        {
            btnSepet.Visible = false;
        }
        public int degerim = 0;
        public int art = 0;

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void pFoto_Click(object sender, EventArgs e)
        {
            //komut için:
            SqlCommand komut = new SqlCommand("insert into dbSepet0(sepetUrunİsim,sepetUrunFiyat) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblEtiket.Text);// parametreye değer atama işlemi.
            komut.Parameters.AddWithValue("@p2", lblFiyat.Text);
            komut.ExecuteNonQuery();// sql komutlarını çalıştır.
            bgl.baglanti().Close();//bağlantıyı bitir.














            art++;


            // ekleyen popup için kullanılan kod kümesi :
            PopupNotifier popp = new PopupNotifier();
         
            popp.ContentText = "1 ADET ÜRÜN BAŞARIYLA SEPETE EKLENDİ ! ";

            popp.BodyColor = Color.FromArgb(255,103,29);
            popp.ContentColor = Color.White;
            popp.Popup();


            
            // sepete eklenen her bir ürünün verisini frmSepet'e gönderecek :
            //art.ToString();
            Properties.Settings.Default.aFiyat = lblFiyat.Text;
            Properties.Settings.Default.aEtiket = lblEtiket.Text;
            Properties.Settings.Default.sayi = art.ToString();
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                

                
            
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
