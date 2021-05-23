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
    public partial class frmKelektronik : Form
    {
        public frmKelektronik()
        {
            InitializeComponent();
        }

        private void userControl112_Load(object sender, EventArgs e)
        {

        }

        private void frmKelektronik_Load(object sender, EventArgs e)
        {
            
        }

        private void eu2_Load(object sender, EventArgs e)
        {

        }

        private void frmKelektronik_Load_1(object sender, EventArgs e)
        {
            // ürün görseli:
            eu1.pFoto.Image = Properties.Resources.e1;
            eu2.pFoto.Image = Properties.Resources.e2;
            eu3.pFoto.Image = Properties.Resources.e3;
            eu4.pFoto.Image = Properties.Resources.e4;
            eu5.pFoto.Image = Properties.Resources.e5;
            eu6.pFoto.Image = Properties.Resources.e6;
            eu7.pFoto.Image = Properties.Resources.e7;
            eu8.pFoto.Image = Properties.Resources.e8;
            eu9.pFoto.Image = Properties.Resources.e9;
            eu10.pFoto.Image = Properties.Resources.e10;
            eu11.pFoto.Image = Properties.Resources.e11;
            eu12.pFoto.Image = Properties.Resources.e12;
            // ürün isimlendirme:
            eu1.lblEtiket.Text = "GamePowerWarlock ";
            eu2.lblEtiket.Text = "Rampage Kulaklık";
            eu3.lblEtiket.Text = "Rampage Mikrofon";
            eu4.lblEtiket.Text = "Snopy Kulaklık";
            eu5.lblEtiket.Text = "RampageSmx-r27";
            eu6.lblEtiket.Text = "Evo MousePad";
            eu7.lblEtiket.Text = "Logitech Mouse";
            eu8.lblEtiket.Text = "PubG Kulaklık";
            eu9.lblEtiket.Text = "RampageSTORMY Siyah";
            eu10.lblEtiket.Text = "M90 Kulaklık";
            eu11.lblEtiket.Text = "Mastek RGB klavye";
            eu12.lblEtiket.Text = "Hadron Kulaklık";
            // ürün fiyatlandırma :
            eu1.lblFiyat.Text = "19,89₺";
            eu2.lblFiyat.Text = "124,90₺";
            eu3.lblFiyat.Text = "159,99₺";
            eu4.lblFiyat.Text = "239₺";
            eu5.lblFiyat.Text = "66,64₺";
            eu6.lblFiyat.Text = "229₺";
            eu7.lblFiyat.Text = "69,99₺";
            eu8.lblFiyat.Text = "194,66₺";
            eu9.lblFiyat.Text = "231,98₺";
            eu10.lblFiyat.Text = "159,08₺";
            eu11.lblFiyat.Text = "127,30₺";
            eu12.lblFiyat.Text = "56,90₺";
        }

        private void eu4_Load(object sender, EventArgs e)
        {

        }

        private void eu2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
