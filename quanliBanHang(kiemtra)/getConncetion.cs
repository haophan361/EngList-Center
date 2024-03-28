using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliBanHang_kiemtra_
{
    public class getConncetion
    {
        SqlConnection conn=null;
        string con = "Data Source=localhost;Initial Catalog=quanliBanHang;Integrated Security=True";
        public SqlConnection getConnect()
        {
            try
            {
                conn = new SqlConnection(con);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
