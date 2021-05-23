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
    public partial class frmCust : Form
    {
        public frmCust()
        {
            InitializeComponent();
        }

        private void frmCust_Load(object sender, EventArgs e)
        {
            cu1.pFoto.Image = Properties.Resources.t1;
            cu2.pFoto.Image = Properties.Resources.t2;
            cu3.pFoto.Image = Properties.Resources.t3;
            cu4.pFoto.Image = Properties.Resources.t4;
            cu5.pFoto.Image = Properties.Resources.t5;
            cu6.pFoto.Image = Properties.Resources.t6;
            cu7.pFoto.Image = Properties.Resources.t7;
            cu8.pFoto.Image = Properties.Resources.t8;
            cu9.pFoto.Image = Properties.Resources.t9;
            cu10.pFoto.Image = Properties.Resources.t10;
            cu11.pFoto.Image = Properties.Resources.t11;
            cu12.pFoto.Image = Properties.Resources.t12;
            // ürün isimlendirme:
            cu1.lblEtiket.Text = "Yeşil erkek tshirt";
            cu2.lblEtiket.Text = "lacivert erkek tshirt";
            cu3.lblEtiket.Text = "Kırmızı erkek tshirt";
            cu4.lblEtiket.Text = "Beyaz erkek tshirt";
            cu5.lblEtiket.Text = "Desenli tshirt";
            cu6.lblEtiket.Text = "Gri dinozor desenli";
            cu7.lblEtiket.Text = "Turuncu erkek tshirt";
            cu8.lblEtiket.Text = "Lacivert erkek tshirt";
            cu9.lblEtiket.Text = "U.S Polo tshirt";
            cu10.lblEtiket.Text = "Brawl Stars desenli";
            cu11.lblEtiket.Text = "Minecraft desenli";
            cu12.lblEtiket.Text = "U.S Polo siyah";
            // ürün fiyatlandırma :
            cu1.lblFiyat.Text = "46,78₺";
            cu2.lblFiyat.Text = "58,47₺";
            cu3.lblFiyat.Text = "58,47₺";
            cu4.lblFiyat.Text = "58,47₺";
            cu5.lblFiyat.Text = "64,97₺";
            cu6.lblFiyat.Text = "89,90₺";
            cu7.lblFiyat.Text = "64,97₺";
            cu8.lblFiyat.Text = "84,75₺";
            cu9.lblFiyat.Text = "45,97₺";
            cu10.lblFiyat.Text = "38₺";
            cu11.lblFiyat.Text = "61,66₺";
            cu12.lblFiyat.Text = "71,47₺";
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
