using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangCafe
{
    public class Database
    {
        private string connection = @"Data Source=LAPTOP-EKK6NSHE; Initial Catalog= QuanLySV;Integrated Security=True;";
        private SqlConnection con;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                con = new SqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể kết nối " + e.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                con.Open ();
                cmd=new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key,para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi lấy dữ liệu " + e.Message);
                con.Close();
                return null;
            }
            finally 
            { 
                con.Close(); 
            }
        }
        public DataRow Select (string sql)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi không thể lấy dữ liệu "+e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public int Execute(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                con.Open ();
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thực hiện câu lệnh "+e.Message); 
                return -1;
            }
            finally 
            { 
                con.Close(); 
            }
        }
    }
}
