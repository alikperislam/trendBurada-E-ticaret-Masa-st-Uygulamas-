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
    public partial class frmKust : Form
    {
        public frmKust()
        {
            InitializeComponent();
        }

        private void frmKust_Load(object sender, EventArgs e)
        {
            uu1.pFoto.Image = Properties.Resources.ku1;
            uu2.pFoto.Image = Properties.Resources.ku2;
            uu3.pFoto.Image = Properties.Resources.ku3;
            uu4.pFoto.Image = Properties.Resources.ku4;
            uu5.pFoto.Image = Properties.Resources.ku5;
            uu6.pFoto.Image = Properties.Resources.ku6;
            uu7.pFoto.Image = Properties.Resources.ku7;
            uu8.pFoto.Image = Properties.Resources.ku8;
            uu9.pFoto.Image = Properties.Resources.ku9;
            uu10.pFoto.Image = Properties.Resources.ku10;
            uu11.pFoto.Image = Properties.Resources.ku11;
            uu12.pFoto.Image = Properties.Resources.ku12;
            // ürün isimlendirme:
            uu1.lblEtiket.Text = "Siyah Kolsuz";
            uu2.lblEtiket.Text = "Beyaz Kolsuz";
            uu3.lblEtiket.Text = "Çizgili Basic";
            uu4.lblEtiket.Text = "Lacivert Polo Yaka";
            uu5.lblEtiket.Text = "Kahverengi - Bej";
            uu6.lblEtiket.Text = "Ananas Baskılı ";
            uu7.lblEtiket.Text = "Lila Büzgülü";
            uu8.lblEtiket.Text = "Siyah ve Beyaz";
            uu9.lblEtiket.Text = "Gri Kolsuz";
            uu10.lblEtiket.Text = "Somon Kolsuz";
            uu11.lblEtiket.Text = "Bordo Polo Yaka";
            uu12.lblEtiket.Text = "Siyah ve Beyaz Tshirt";
            // ürün fiyatlandırma :
            uu1.lblFiyat.Text = "44,99₺";
            uu2.lblFiyat.Text = "44,99₺";
            uu3.lblFiyat.Text = "44,99₺";
            uu4.lblFiyat.Text = "89₺";
            uu5.lblFiyat.Text = "64,99₺";
            uu6.lblFiyat.Text = "56,79₺";
            uu7.lblFiyat.Text = "49₺";
            uu8.lblFiyat.Text = "64,99₺";
            uu9.lblFiyat.Text = "44,99₺";
            uu10.lblFiyat.Text = "49,9₺";
            uu11.lblFiyat.Text = "56,90₺";
            uu12.lblFiyat.Text = "89₺";
        }

        private void userControl13_Load(object sender, EventArgs e)
        {

        }
    }
}
