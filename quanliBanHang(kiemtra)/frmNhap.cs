using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliBanHang_kiemtra_
{
    public partial class frmNhap : Form
    {
        string sodh = "";
        DateTime ngaydathang;
        int soluong;
        int tinhtrang;
        int makhachhang;
        int masanpham;
        string ngaydathangstring;
        public frmNhap(string sodh)
        {
            InitializeComponent();
            this.sodh = sodh;
        }
        private void LoadData()
        {
            string sql = "EXEC select1DonHang @sodh";
            SqlConnection conn = null;
            DataTable dt = new DataTable();
            try
            {
                getConncetion connect = new getConncetion();
                conn = connect.getConnect();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter para = new SqlParameter("@sodh", sodh);
                cmd.Parameters.Add(para);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        txtdate.Text = row["ngaydathang"].ToString();
                        txttotal.Text = row["soluong"].ToString();
                        txtcost.Text = row["dongia"].ToString();
                        txtstatus.Text = row["tinhtrangthanhtoan"].ToString();
                        txtidcus.Text = row["makh"].ToString();
                        txtidpro.Text = row["masp"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void frmxuat_Load(object sender, EventArgs e)
        {
            if (this.Text == "Cập nhật")
            {
                LoadData();
            }
            else
            {
                txtcost.Visible = false;
                label3.Visible = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ngaydathang = DateTime.ParseExact(txtdate.Text, "dd/MM/yyyy", null);
            string ngaydathangstring = ngaydathang.ToString("yyyy/MM/dd");
            soluong = int.Parse(txttotal.Text);
            if(txtstatus.Text=="Chưa thanh toán")
            {
                tinhtrang = 0;
            }
            else
            {
                tinhtrang = 1;
            }
            makhachhang = int.Parse(txtidcus.Text);
            masanpham = int.Parse(txtidpro.Text);
            SqlConnection conn = null;
            getConncetion connect = new getConncetion();
            conn = connect.getConnect();
            if (this.Text=="Cập nhật")
            {
                string sql = "EXEC updateBill @sodh,@ngaydathang,@soluong,@tinhtrang,@makh,@masp";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter para1 = new SqlParameter("@sodh", int.Parse(sodh));
                cmd.Parameters.Add(para1);
                SqlParameter para2 = new SqlParameter("@ngaydathang", SqlDbType.Date);
                para2.Value = ngaydathangstring;
                cmd.Parameters.Add(para2);
                SqlParameter para3 = new SqlParameter("@soluong", soluong);
                cmd.Parameters.Add(para3);
                SqlParameter para4 = new SqlParameter("@tinhtrang", tinhtrang);
                cmd.Parameters.Add(para4);
                SqlParameter para5 = new SqlParameter("@makh", makhachhang);
                cmd.Parameters.Add(para5);
                SqlParameter para6 = new SqlParameter("@masp", masanpham);
                cmd.Parameters.Add(para6);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công");
            }
            else
            {
                string sql = "EXEC addBill @ngaydathang,@soluong,@tinhtrang,@makh,@masp";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter para2 = new SqlParameter("@ngaydathang", SqlDbType.Date);
                para2.Value = ngaydathangstring;
                cmd.Parameters.Add(para2);
                SqlParameter para3 = new SqlParameter("@soluong", soluong);
                cmd.Parameters.Add(para3);
                SqlParameter para4 = new SqlParameter("@tinhtrang", tinhtrang);
                cmd.Parameters.Add(para4);
                SqlParameter para5 = new SqlParameter("@makh", makhachhang);
                cmd.Parameters.Add(para5);
                SqlParameter para6 = new SqlParameter("@masp", masanpham);
                cmd.Parameters.Add(para6);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
            }
            this.Close();
            conn.Close();
        }
        //Hello hhghgh
        private void txtcost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
