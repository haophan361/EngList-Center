using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangCafe
{
    public partial class FormDsSV : Form
    {
        public FormDsSV()
        {
            InitializeComponent();
        }
        
        private string tukhoa = "";
        private void FormDsSV_Load(object sender, EventArgs e)
        {
            LoadDsSV();  
        }
        
        private void LoadDsSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvSinhvien.DataSource = new Database().SelectData("SelectAllSinhVien",lstPara);
            dgvSinhvien.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvSinhvien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhvien.Columns["nsinh"].HeaderText = "Ngày sinh";
            dgvSinhvien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvSinhvien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhvien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhvien.Columns["dienthoai"].HeaderText = "Số điện thoại";
            dgvSinhvien.Columns["email"].HeaderText = "Email";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormSinhvien(null).ShowDialog();
            LoadDsSV();
        }

        private void dgvSinhvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var msv= dgvSinhvien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new FormSinhvien(msv).ShowDialog() ;
                LoadDsSV();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tukhoa=txtsearch.Text;
            LoadDsSV() ;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
