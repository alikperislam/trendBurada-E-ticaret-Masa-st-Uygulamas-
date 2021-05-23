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
    public partial class frmCalt : Form
    {
        public frmCalt()
        {
            InitializeComponent();
        }

        private void frmCalt_Load(object sender, EventArgs e)
        {
            ca1.pFoto.Image = Properties.Resources.ae1;
            ca2.pFoto.Image = Properties.Resources.ae2;
            ca3.pFoto.Image = Properties.Resources.ae3;
            ca4.pFoto.Image = Properties.Resources.ae4;
            ca5.pFoto.Image = Properties.Resources.ae5;
            ca6.pFoto.Image = Properties.Resources.ae6;
            ca7.pFoto.Image = Properties.Resources.ae7;
            ca8.pFoto.Image = Properties.Resources.ae8;
            ca9.pFoto.Image = Properties.Resources.ae9;
            ca10.pFoto.Image = Properties.Resources.ae10;
            ca11.pFoto.Image = Properties.Resources.ae11;
            ca12.pFoto.Image = Properties.Resources.ae12;
            // ürün isimlendirme:
            ca1.lblEtiket.Text = "Batik desenli eşofman";
            ca2.lblEtiket.Text = "U.S Polo eşofman";
            ca3.lblEtiket.Text = "Lacivert U.S Polo";
            ca4.lblEtiket.Text = "Kamuflaj eşofman";
            ca5.lblEtiket.Text = "Defacto Baskılı Takım";
            ca6.lblEtiket.Text = "Riccotarz Zincirli takım";
            ca7.lblEtiket.Text = "Turkuaz Eşofman Takımı";
            ca8.lblEtiket.Text = "Gri kamuflaj ";
            ca9.lblEtiket.Text = "Crop model eşofman";
            ca10.lblEtiket.Text = "Gazee desenli takım";
            ca11.lblEtiket.Text = "Lacivert eşofman takımı";
            ca12.lblEtiket.Text = "Garnili takım";
            // ürün fiyatlandırma :
            ca1.lblFiyat.Text = "59,95₺";
            ca2.lblFiyat.Text = "71,47₺";
            ca3.lblFiyat.Text = "90,97₺";
            ca4.lblFiyat.Text = "24,48₺";
            ca5.lblFiyat.Text = "55,99₺";
            ca6.lblFiyat.Text = "159,90₺";
            ca7.lblFiyat.Text = "79,99₺";
            ca8.lblFiyat.Text = "75,05₺";
            ca9.lblFiyat.Text = "102,19₺";
            ca10.lblFiyat.Text = "131,94₺";
            ca11.lblFiyat.Text = "122,55₺";
            ca12.lblFiyat.Text = "76,99₺";
        }

        private void userControl13_Load(object sender, EventArgs e)
        {

        }

        private void userControl17_Load(object sender, EventArgs e)
        {
                    }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
