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
    public partial class frmEalt : Form
    {
        public frmEalt()
        {
            InitializeComponent();
        }

        private void frmEalt_Load(object sender, EventArgs e)
        {
            ea1.pFoto.Image = Properties.Resources.ep1;
            ea2.pFoto.Image = Properties.Resources.ep2;
            ea3.pFoto.Image = Properties.Resources.ep3;
            ea4.pFoto.Image = Properties.Resources.ep4;
            ea5.pFoto.Image = Properties.Resources.ep5;
            ea6.pFoto.Image = Properties.Resources.ep6;
            ea7.pFoto.Image = Properties.Resources.ep7;
            ea8.pFoto.Image = Properties.Resources.ep8;
            ea9.pFoto.Image = Properties.Resources.ep9;
            ea10.pFoto.Image = Properties.Resources.ep10;
            ea11.pFoto.Image = Properties.Resources.ep11;
            ea12.pFoto.Image = Properties.Resources.ep12;
            // ürün isimlendirme:
            ea1.lblEtiket.Text = "İtalyan kesim Kot";
            ea2.lblEtiket.Text = "Siyah İtalyan kesim";
            ea3.lblEtiket.Text = "Likralı Lacivert";
            ea4.lblEtiket.Text = "Siyah İtalyan kesim";
            ea5.lblEtiket.Text = "Pierre Cardin Bej";
            ea6.lblEtiket.Text = "Erkek Gri İtalyan";
            ea7.lblEtiket.Text = "Buz Mavi Kot";
            ea8.lblEtiket.Text = "Skinny Fit Jeans";
            ea9.lblEtiket.Text = "Lastikli Kargo Pantolon";
            ea10.lblEtiket.Text = "Haki Pantolon";
            ea11.lblEtiket.Text = "Jogger Pantolon";
            ea12.lblEtiket.Text = "Dar Kalıp Jogger";
            // ürün fiyatlandırma :
            ea1.lblFiyat.Text = "123,90₺";
            ea2.lblFiyat.Text = "123,90₺";
            ea3.lblFiyat.Text = "99,99₺";
            ea4.lblFiyat.Text = "123,90₺";
            ea5.lblFiyat.Text = "119,23₺";
            ea6.lblFiyat.Text = "99,89₺";
            ea7.lblFiyat.Text = "127,99₺";
            ea8.lblFiyat.Text = "123,99₺";
            ea9.lblFiyat.Text = "109,99₺";
            ea10.lblFiyat.Text = "105₺";
            ea11.lblFiyat.Text = "117,90₺";
            ea12.lblFiyat.Text = "118,80₺";
        }

        private void ea8_Load(object sender, EventArgs e)
        {

        }
    }
}
