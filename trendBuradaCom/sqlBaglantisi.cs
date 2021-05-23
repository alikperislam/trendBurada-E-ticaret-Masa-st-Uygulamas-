using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace trendBuradaCom
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-96JGKTV\\SQLEXPRESS;Initial Catalog=trendburada;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
