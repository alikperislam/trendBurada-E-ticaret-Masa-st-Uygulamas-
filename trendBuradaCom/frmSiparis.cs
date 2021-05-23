using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace trendBuradaCom
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            label1.Text =Properties.Settings.Default.siparisEtiket;
            label2.Text = Properties.Settings.Default.siparisFiyat;

            
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            cNumara.Clear();
        }

        private void cİsim_Click(object sender, EventArgs e)
        {
            cİsim.Clear();
        }

        private void cNumara_TextChanged(object sender, EventArgs e)
        {
            kartNumara.Text = cNumara.Text;
        }

        private void cİsim_TextChanged(object sender, EventArgs e)
        {
            kartİsim.Text = cİsim.Text;
            cİsim.Text.ToUpper();

        }

        private void cAy_TextChanged(object sender, EventArgs e)
        {
            kartAy.Text = cAy.Text;
        }

        private void cYil_TextChanged(object sender, EventArgs e)
        {
            kartYil.Text = cYil.Text;
        }

        private void cYil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public int d = 0;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            //komut için:
            SqlCommand komut = new SqlCommand("insert into dbBilgiler0(bilgiAdSoyad,bilgiAdres,bilgiUrunİsim,bilgiFiyat) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adresİsim.Text);// parametreye değer atama işlemi.
            komut.Parameters.AddWithValue("@p2", adresGenel.Text);
            komut.Parameters.AddWithValue("@p3", label1.Text);
            komut.Parameters.AddWithValue("@p4", label2.Text);
            komut.ExecuteNonQuery();// sql komutlarını çalıştır.
            bgl.baglanti().Close();//bağlantıyı bitir.

           // d++;
            //Properties.Settings.Default.sa=d.ToString();
            








            Properties.Settings.Default.pGenelAdres = adresGenel.Text;
            Properties.Settings.Default.pNumara = kartNumara.Text;
            Properties.Settings.Default.pİl = AdresSehir.Text;
            Properties.Settings.Default.pİlce = adresİlce.Text;
            Properties.Settings.Default.pİsim = adresİsim.Text;
            Properties.Settings.Default.PMail = adresMail.Text;

            ////////////////////////////////////////

            MailMessage mesaj = new MailMessage(); // göndereceğimiz mesaj için bir nesne ürettik.
            //smtp : mail göndermek için kullanılan sunucu ile iletişime geçen bir protokoldur.
            SmtpClient istemci = new SmtpClient(); // istemci nesnesi ürettik.
            // istemci üzerinde kullanıcı mail adresi ve şifremi girmem için networkcredential sınıfı için mail adresimi ve parolamı yazıyorum.
            istemci.Credentials = new System.Net.NetworkCredential("ornekhesapcsharp1923@outlook.com", "a123456789a");
            istemci.Port = 587; // türkiyede port numarası genellikle 587 olarak kullanılır.
            istemci.Host = "smtp.live.com"; //outlook'un sunucu adresi.
            istemci.EnableSsl = true; // mail doğru adrese ulaşana kadar şifreleme yapması için yani websitelerdeki https işlevi görüyor.
            // göndereceğimiz mesaj ile ilgili içerikleri artık ekleyebiliriz.
            mesaj.To.Add(adresMail.Text); //mesajın hangi mail adresine gönderileceğini belirtiyoruz.
            mesaj.From = new MailAddress("ornekhesapcsharp1923@outlook.com"); // hangi mail adresinden yani kimden gönderileceği ile ilgili.
            mesaj.Subject = "trendburada.com yaptığınız alış-veriş ile ilgili."; // konu ile ilgili bilgi girilecek.
            mesaj.Body = "Merhaba sayın "+adresİsim.Text+", "+kartNumara.Text+" Numaralı kredi kartınız ile yapmış olduğunuz "+label2.Text+" tutarındaki "+label1.Text
                +" isimli ürün siparişiniz "+adresGenel.Text+" adresinize 1-3 iş günü içerisinde ulaşması için kargoya verilmiştir. İyi günler dileriz. "; // gönderilecek mesaj içeiriği burda.

            istemci.Send(mesaj); // istemci verileri mesaj sınıfından alacak ve outlook'a gönderecek.



        }
    }
}
