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
    public partial class frmEust : Form
    {
        public frmEust()
        {
            InitializeComponent();
        }

        private void frmEust_Load(object sender, EventArgs e)
        {
            eust1.pFoto.Image = Properties.Resources.eu1;
            eust2.pFoto.Image = Properties.Resources.eu2;
            eust3.pFoto.Image = Properties.Resources.eu3;
            eust4.pFoto.Image = Properties.Resources.eu4;
            eust5.pFoto.Image = Properties.Resources.eu5;
            eust6.pFoto.Image = Properties.Resources.eu6;
            eust7.pFoto.Image = Properties.Resources.eu7;
            eust8.pFoto.Image = Properties.Resources.eu8;
            eust9.pFoto.Image = Properties.Resources.eu9;
            eust10.pFoto.Image = Properties.Resources.eu10;
            eust11.pFoto.Image = Properties.Resources.eu11;
            eust12.pFoto.Image = Properties.Resources.eu12;
            // ürün isimlendirme:
            eust1.lblEtiket.Text = "Kahverengi yazlık";
            eust2.lblEtiket.Text = "U.S Polo beyaz";
            eust3.lblEtiket.Text = "Regular Fit yaka";
            eust4.lblEtiket.Text = "Apoletli slim fit";
            eust5.lblEtiket.Text = "Desenli bebe mavisi";
            eust6.lblEtiket.Text = "Kısa Kollu Yazlık";
            eust7.lblEtiket.Text = "Pamuklu Yazılık";
            eust8.lblEtiket.Text = "Yeşil Çift cepli";
            eust9.lblEtiket.Text = "Regular Fit yaka";
            eust10.lblEtiket.Text = "Slim fit panelli";
            eust11.lblEtiket.Text = "Yazlık kısa kollu";
            eust12.lblEtiket.Text = "Haki kısa kollu";
            // ürün fiyatlandırma :
            eust1.lblFiyat.Text = "109,99₺";
            eust2.lblFiyat.Text = "79,18₺";
            eust3.lblFiyat.Text = "89,99₺";
            eust4.lblFiyat.Text = "79,99₺";
            eust5.lblFiyat.Text = "79,99₺";
            eust6.lblFiyat.Text = "75₺";
            eust7.lblFiyat.Text = "76₺";
            eust8.lblFiyat.Text = "99,80₺";
            eust9.lblFiyat.Text = "79,99₺";
            eust10.lblFiyat.Text = "71,99₺";
            eust11.lblFiyat.Text = "109,90₺";
            eust12.lblFiyat.Text = "89,99₺";
        }
    }
}
