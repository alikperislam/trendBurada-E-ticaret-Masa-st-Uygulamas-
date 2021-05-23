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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        int side=0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            lblCopy.Left--;
            if (lblCopy.Left==-437)
            {
                lblCopy.Left = 782;
            }

        }

        void getirPanel(Form frm)
        {
            anaPanel.Controls.Clear(); // üst üste formlar gelmemesi için panelin içerisini her seferinde temizliyoruz.
            frm.MdiParent = this; // gelen formu yani açılacak olan formu burada açacağına dair Mdi=this; yapıyoruz.
            anaPanel.Controls.Add(frm);//formu nerede açacaksa o panelin controlune ekliyoruz.
            frm.Show(); // formu ekranda göster.
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            pt1.BackColor = Color.White;
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            p1.BackColor = Color.White;
            p2.BackColor = Color.White;
            p3.BackColor = Color.White;
            p4.BackColor = Color.White;
            p5.BackColor = Color.White;
            p6.BackColor = Color.White;


            timer1.Start();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            but = 1;
            p1.BackColor = Color.FromArgb(255,103,29);
            p2.BackColor = Color.White;
            p3.BackColor = Color.White;
            p4.BackColor = Color.White;
            p5.BackColor = Color.White;
            p6.BackColor = Color.White;
            p7.BackColor = Color.White;

            pt1.BackColor = Color.FromArgb(255, 103, 29);
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            
                frmKaksesuar fr = new frmKaksesuar();
                getirPanel(fr);
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            but = 2;
            p2.BackColor = Color.FromArgb(255, 103, 29);
            p1.BackColor = Color.White;
            p3.BackColor = Color.White;
            p4.BackColor = Color.White;
            p5.BackColor = Color.White;
            p6.BackColor = Color.White;
            p7.BackColor = Color.White;

            pt1.BackColor = Color.FromArgb(255, 103, 29);
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            
                frmEaksesuar fre = new frmEaksesuar();
                getirPanel(fre);
            
        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            but = 3;
            p3.BackColor = Color.FromArgb(255, 103, 29);
            p2.BackColor = Color.White;
            p1.BackColor = Color.White;
            p4.BackColor = Color.White;
            p5.BackColor = Color.White;
            p6.BackColor = Color.White;
            p7.BackColor = Color.White;

            pt1.BackColor = Color.FromArgb(255, 103, 29);
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            
                frmCaksesuar frec = new frmCaksesuar();
                getirPanel(frec);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            p4.BackColor = Color.FromArgb(255, 103, 29);
            p2.BackColor = Color.White;
            p3.BackColor = Color.White;
            p1.BackColor = Color.White;
            p5.BackColor = Color.White;
            p6.BackColor = Color.White;
            p7.BackColor = Color.White;

            pt1.BackColor = Color.White;
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            sepetim fr0 = new sepetim();
            getirPanel(fr0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p5.BackColor = Color.FromArgb(255, 103, 29);
            p2.BackColor = Color.White;
            p3.BackColor = Color.White;
            p4.BackColor = Color.White;
            p1.BackColor = Color.White;
            p6.BackColor = Color.White;
            p7.BackColor = Color.White;

            pt1.BackColor = Color.White;
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            frmSiparis sip = new frmSiparis();
            getirPanel(sip);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p6.BackColor = Color.FromArgb(255, 103, 29);
            p2.BackColor = Color.White;
            p3.BackColor = Color.White;
            p4.BackColor = Color.White;
            p5.BackColor = Color.White;
            p1.BackColor = Color.White;
            p7.BackColor = Color.White;

            pt1.BackColor = Color.White;
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            frmBilgiler bil = new frmBilgiler();
            getirPanel(bil);
        }
        public int eleman = 0;
        public int but = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            eleman=1;
            pt1.BackColor = Color.FromArgb(255, 103, 29);
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            if (eleman == 1 && but == 1)
            {
                frmKaksesuar fr = new frmKaksesuar();
                getirPanel(fr);
            }
            else if (eleman == 1 && but == 2)
            {
                frmEaksesuar fre = new frmEaksesuar();
                getirPanel(fre);
            }
            else if (eleman == 1 && but == 3)
            {
                frmCaksesuar frec = new frmCaksesuar();
                getirPanel(frec);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            eleman = 2;
            pt2.BackColor = Color.FromArgb(255, 103, 29);
            pt1.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt4.BackColor = Color.White;

            
             if (eleman == 2 && but == 1)
            {
                frmKalt fr1 = new frmKalt();
                getirPanel(fr1);
            }
            else if (eleman == 2 && but == 2)
            {
                frmEalt frEa = new frmEalt();
                getirPanel(frEa);
            }
            else if (eleman == 2 && but == 3)
            {
                frmCalt frca = new frmCalt();
                getirPanel(frca);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            eleman = 3;
            pt3.BackColor = Color.FromArgb(255, 103, 29);
            pt2.BackColor = Color.White;
            pt1.BackColor = Color.White;
            pt4.BackColor = Color.White;

            
             if (eleman == 3 && but == 1)
            {
                frmKust fr2 = new frmKust();
                getirPanel(fr2);
            }
            else if (eleman == 3 && but == 2)
            {
                frmEust freu = new frmEust();
                getirPanel(freu);
            }
            else if (eleman == 3 && but == 3)
            {
                frmCust frcu = new frmCust();
                getirPanel(frcu);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            eleman = 4;
            pt4.BackColor = Color.FromArgb(255, 103, 29);
            pt2.BackColor = Color.White;
            pt3.BackColor = Color.White;
            pt1.BackColor = Color.White;

            
            if (eleman == 4 && but == 1)
            {
                frmKelektronik fr3 = new frmKelektronik();
                getirPanel(fr3);
            }
            else if (eleman == 4 && but == 2)
            {
                frmKelektronik fr3 = new frmKelektronik();
                getirPanel(fr3);
            }
            else if (eleman == 4 && but == 3)
            {
                frmKelektronik fr3 = new frmKelektronik();
                getirPanel(fr3);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p5.BackColor = Color.White;
            p2.BackColor = Color.White;
            p3.BackColor = Color.White;
            p4.BackColor = Color.White;
            p1.BackColor = Color.White;
            p6.BackColor = Color.White;
            p7.BackColor = Color.FromArgb(255, 103, 29);

            frmBilgi b = new frmBilgi();
            getirPanel(b);
        }
    }
}
