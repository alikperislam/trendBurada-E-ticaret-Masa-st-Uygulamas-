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
    public partial class frmKalt : Form
    {
        public frmKalt()
        {
            InitializeComponent();
        }

        private void frmKalt_Load(object sender, EventArgs e)
        {
            // ürün görseli:
            kau1.pFoto.Image = Properties.Resources.ka1;
            kau2.pFoto.Image = Properties.Resources.ka2;
            kau3.pFoto.Image = Properties.Resources.ka3;
            kau4.pFoto.Image = Properties.Resources.ka4;
            kau5.pFoto.Image = Properties.Resources.ka5;
            kau6.pFoto.Image = Properties.Resources.ka6;
            kau7.pFoto.Image = Properties.Resources.ka7;
            kau8.pFoto.Image = Properties.Resources.ka8;
            kau9.pFoto.Image = Properties.Resources.ka9;
            kau10.pFoto.Image = Properties.Resources.ka10;
            kau11.pFoto.Image = Properties.Resources.ka11;
            kau12.pFoto.Image = Properties.Resources.ka12;
            // ürün isimlendirme:
            kau1.lblEtiket.Text = "MadeModaKadın";
            kau2.lblEtiket.Text = "TrendyolMilla";
            kau3.lblEtiket.Text = "Happiness ist.";
            kau4.lblEtiket.Text = "Antrasit Kemerli";
            kau5.lblEtiket.Text = "Dökümlü pantolon";
            kau6.lblEtiket.Text = "Siyah detaylı";
            kau7.lblEtiket.Text = "Bej ispanyol paça";
            kau8.lblEtiket.Text = "Siyah Flare";
            kau9.lblEtiket.Text = "Pileli İspanyol paça";
            kau10.lblEtiket.Text = "Düz kesim";
            kau11.lblEtiket.Text = "Yüksek bel";
            kau12.lblEtiket.Text = "Siyah Cigarette";
            // ürün fiyatlandırma :
            kau1.lblFiyat.Text = "74,90₺";
            kau2.lblFiyat.Text = "89,99₺";
            kau3.lblFiyat.Text = "42,60₺";
            kau4.lblFiyat.Text = "99,99₺";
            kau5.lblFiyat.Text = "69,99₺";
            kau6.lblFiyat.Text = "55,99₺";
            kau7.lblFiyat.Text = "79,99₺";
            kau8.lblFiyat.Text = "55,99₺";
            kau9.lblFiyat.Text = "84,99₺";
            kau10.lblFiyat.Text = "99,99₺";
            kau11.lblFiyat.Text = "84,99₺";
            kau12.lblFiyat.Text = "59,99₺";
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }
    }
}
