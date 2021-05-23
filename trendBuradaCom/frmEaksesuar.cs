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
    public partial class frmEaksesuar : Form
    {
        public frmEaksesuar()
        {
            InitializeComponent();
        }

        private void frmEaksesuar_Load(object sender, EventArgs e)
        {
            eak1.pFoto.Image = Properties.Resources.s1;
            eak2.pFoto.Image = Properties.Resources.s2;
            eak3.pFoto.Image = Properties.Resources.s3;
            eak4.pFoto.Image = Properties.Resources.s4;
            eak5.pFoto.Image = Properties.Resources.s5;
            eak6.pFoto.Image = Properties.Resources.s6;
            eak7.pFoto.Image = Properties.Resources.s7;
            eak8.pFoto.Image = Properties.Resources.s8;
            eak9.pFoto.Image = Properties.Resources.s9;
            eak10.pFoto.Image = Properties.Resources.s10;
            eak11.pFoto.Image = Properties.Resources.s11;
            eak12.pFoto.Image = Properties.Resources.s12;
            // ürün isimlendirme:
            eak1.lblEtiket.Text = "Aqua Di Polo";
            eak2.lblEtiket.Text = "Apsv1-1987";
            eak3.lblEtiket.Text = "Aplc 1979";
            eak4.lblEtiket.Text = "Frank martin saat";
            eak5.lblEtiket.Text = "Dokunmatik saat";
            eak6.lblEtiket.Text = "UD333 - Di Polo";
            eak7.lblEtiket.Text = "Er-Se Kol Saati";
            eak8.lblEtiket.Text = "A9472 Di polo";
            eak9.lblEtiket.Text = "Aqua Çiçekli";
            eak10.lblEtiket.Text = "Ferucci Saat";
            eak11.lblEtiket.Text = "Colesium erkek Saat";
            eak12.lblEtiket.Text = "Michael West";
            // ürün fiyatlandırma :
            eak1.lblFiyat.Text = "69,99₺";
            eak2.lblFiyat.Text = "69,99₺";
            eak3.lblFiyat.Text = "69,99₺";
            eak4.lblFiyat.Text = "97,30₺";
            eak5.lblFiyat.Text = "63,95₺";
            eak6.lblFiyat.Text = "59,99₺";
            eak7.lblFiyat.Text = "126,66₺";
            eak8.lblFiyat.Text = "69,99₺";
            eak9.lblFiyat.Text = "79,99₺";
            eak10.lblFiyat.Text = "323,19₺";
            eak11.lblFiyat.Text = "79,90₺";
            eak12.lblFiyat.Text = "64,90₺";
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
