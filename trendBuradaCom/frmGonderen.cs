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
    public partial class frmGonderen : Form
    {
        public frmGonderen()
        {
            InitializeComponent();
        }

        private void frmGonderen_Load(object sender, EventArgs e)
        {
            sepetim s = new sepetim();
            MessageBox.Show(gonderFoto.Name);

            
            
        }
    }
}
