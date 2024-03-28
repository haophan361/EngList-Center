using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliBanHang_kiemtra_
{
    public partial class frmDonHang : Form
    {
        SqlConnection conn = null;
        string sodh = "";
        string keyword = "";
        public frmDonHang()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDonHang();
        }
        private void LoadDonHang()
        {
            string sql = "EXEC selectDonHang @keyword";
            DataTable dt = new DataTable();
            keyword = txtsearch.Text;
            try
            {
                getConncetion connect = new getConncetion();
                conn=connect.getConnect();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter para = new SqlParameter("@keyword", keyword);
                cmd.Parameters.Add(para);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                dgvDonHang.DataSource = dt;
                dgvDonHang.Columns[0].HeaderText = "Số Đơn Hàng";
                dgvDonHang.Columns[1].HeaderText = "Mã khách hàng";
                dgvDonHang.Columns[2].HeaderText = "Mã sản phẩm";
                dgvDonHang.Columns[3].HeaderText = "Ngày đặt hàng";
                dgvDonHang.Columns[4].HeaderText = "Số lượng";
                dgvDonHang.Columns[5].HeaderText = "Đơn giá ";
                dgvDonHang.Columns[6].HeaderText = "Tình trạng";

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void dgvDonHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvDonHang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDonHang.Rows[selectedRowIndex];
                string sodh = selectedRow.Cells["sodh"].Value.ToString();

                string sql = "EXEC deleteBill @sodh";

                try
                {
                    getConncetion connect = new getConncetion();
                    conn = connect.getConnect();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sodh", sodh);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Đã xóa đơn hàng thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi xóa đơn hàng: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xóa!");
            }
            LoadDonHang();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadDonHang();
        }
        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            { 
                sodh = dgvDonHang.Rows[e.RowIndex].Cells["sodh"].Value.ToString();
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            frmNhap formnhapHang = new frmNhap(sodh);
            formnhapHang.Text = ("Thêm");
            formnhapHang.ShowDialog();
            LoadDonHang();
        }

        private void dgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                sodh = dgvDonHang.Rows[e.RowIndex].Cells["sodh"].Value.ToString();
            }
            frmNhap formnhapHang = new frmNhap(sodh);
            formnhapHang.Text = ("Cập nhật");
            formnhapHang.ShowDialog();
            LoadDonHang() ;
        }
    }
}
