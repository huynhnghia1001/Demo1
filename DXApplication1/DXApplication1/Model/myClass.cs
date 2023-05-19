using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Model
{
    public class myClass
    {
        static SqlConnection con = new SqlConnection();
        public static void taoKetNoi()
        {
            con.ConnectionString = "Data Source = .; Initial Catalog = QLKho; User ID = sa; Password=123;";
            try
            {
                con.Open();
            }
            catch
            {
                throw;    
            }
        }
        public static void dongKetNoi()
        {
            con.Close();
        }
        public static DataTable GetData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }
    }
}
