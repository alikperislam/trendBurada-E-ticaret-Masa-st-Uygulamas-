using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trendBuradaCom
{
    public partial class frmCaksesuar : Form
    {
        public frmCaksesuar()
        {
            InitializeComponent();
        }

        private void frmCaksesuar_Load(object sender, EventArgs e)
        {
            ca1.pFoto.Image = Properties.Resources.x1;
            ca2.pFoto.Image = Properties.Resources.x2;
            ca3.pFoto.Image = Properties.Resources.x3;
            ca4.pFoto.Image = Properties.Resources.x4;
            ca5.pFoto.Image = Properties.Resources.x5;
            ca6.pFoto.Image = Properties.Resources.x6;
            ca7.pFoto.Image = Properties.Resources.x7;
            ca8.pFoto.Image = Properties.Resources.x8;
            ca9.pFoto.Image = Properties.Resources.x9;
            ca10.pFoto.Image = Properties.Resources.x10;
            ca11.pFoto.Image = Properties.Resources.x11;
            ca12.pFoto.Image = Properties.Resources.x12;
            // ürün isimlendirme:
            ca1.lblEtiket.Text = "Bmw M6 Coupe Işıklı";
            ca2.lblEtiket.Text = "2005 Hummer";
            ca3.lblEtiket.Text = "Mega tır turuncu";
            ca4.lblEtiket.Text = "Bin git ilk arabam";
            ca5.lblEtiket.Text = "Oyuncak puset";
            ca6.lblEtiket.Text = "Pilli Airbus uçak";
            ca7.lblEtiket.Text = "Su çarkı";
            ca8.lblEtiket.Text = "Swat araba";
            ca9.lblEtiket.Text = "Şimşek McQuenn";
            ca10.lblEtiket.Text = "20'li araba seti";
            ca11.lblEtiket.Text = "2012 Lotus Exige S";
            ca12.lblEtiket.Text = "Bumblebee Transformers";
            // ürün fiyatlandırma :
            ca1.lblFiyat.Text = "104₺";
            ca2.lblFiyat.Text = "68,29₺";
            ca3.lblFiyat.Text = "149,90₺";
            ca4.lblFiyat.Text = "74,52₺";
            ca5.lblFiyat.Text = "144,90₺";
            ca6.lblFiyat.Text = "53,90₺";
            ca7.lblFiyat.Text = "239,90₺";
            ca8.lblFiyat.Text = "127,94₺";
            ca9.lblFiyat.Text = "38,70₺";
            ca10.lblFiyat.Text = "177,25₺";
            ca11.lblFiyat.Text = "67,29₺";
            ca12.lblFiyat.Text = "60,98₺";
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
