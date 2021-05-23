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
    public partial class frmKaksesuar : Form
    {
        public frmKaksesuar()
        {
            InitializeComponent();
        }

        private void frmKaksesuar_Load(object sender, EventArgs e)
        {
            
            // ürün görselleri :
            u1.pFoto.Image = Properties.Resources.k1;
            u2.pFoto.Image = Properties.Resources.k2;
            u3.pFoto.Image = Properties.Resources.k3;
            u4.pFoto.Image = Properties.Resources.k4;
            u5.pFoto.Image = Properties.Resources.k5;
            u6.pFoto.Image = Properties.Resources.k6;
            u7.pFoto.Image = Properties.Resources.k7;
            u8.pFoto.Image = Properties.Resources.k8;
            u9.pFoto.Image = Properties.Resources.k9;
            u10.pFoto.Image = Properties.Resources.k10;
            u11.pFoto.Image = Properties.Resources.k11;
            u12.pFoto.Image = Properties.Resources.k12;
            // ürün isimleri :
            u1.lblEtiket.Text = "BobigoKadın Çanta";
            u2.lblEtiket.Text = "Pierre Cardin Çanta";
            u3.lblEtiket.Text = "Pierre Cardin Çanta";
            u4.lblEtiket.Text = "Pierre Cardin Çanta";
            u5.lblEtiket.Text = "Housebags Çanta";
            u6.lblEtiket.Text = "Madamra Hasır Çanta";
            u7.lblEtiket.Text = "Pierre Cardin Çanta";
            u8.lblEtiket.Text = "Pierre Cardin Çanta";
            u9.lblEtiket.Text = "Pierre Cardin Çanta";
            u10.lblEtiket.Text = "Top All Bag Siyah";
            u11.lblEtiket.Text = "Rome Italy";
            u12.lblEtiket.Text = "Pierre Cardin Çanta";
            // ürün fiyatlandırma :
            u1.lblFiyat.Text = "29,40₺";
            u2.lblFiyat.Text = "169,99₺";
            u3.lblFiyat.Text = "159,99₺";
            u4.lblFiyat.Text = "199,99₺";
            u5.lblFiyat.Text = "64,99₺";
            u6.lblFiyat.Text = "109,90₺";
            u7.lblFiyat.Text = "199,99₺";
            u8.lblFiyat.Text = "199,99₺";
            u9.lblFiyat.Text = "149,99₺";
            u10.lblFiyat.Text = "39,98₺";
            u11.lblFiyat.Text = "69,90₺";
            u12.lblFiyat.Text = "179,90₺";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void u1_Click(object sender, EventArgs e)
        {
            
            


        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void u1_Load(object sender, EventArgs e)
        {

        }
    }
}
