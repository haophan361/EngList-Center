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
    public partial class FormDsGV : Form
    {
        public FormDsGV()
        {
            InitializeComponent();
        }
        private void FormDsGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }
        private void LoadDSGV()
        {
            string sql = "SelectAllGiaoVien";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDsGV.DataSource = new Database().SelectData(sql, lstPara);
            dgvDsGV.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvDsGV.Columns["hoten"].HeaderText = "Họ tên";
            dgvDsGV.Columns["gtinh"].HeaderText = "Giới tính";
            dgvDsGV.Columns["nsinh"].HeaderText = "Ngày sinh";
            dgvDsGV.Columns["dienthoai"].HeaderText = "Số điện thoại";
            dgvDsGV.Columns["email"].HeaderText = "Email";
            dgvDsGV.Columns["diachi"].HeaderText = "Địa chỉ";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tukhoa =txtsearch.Text;
            LoadDSGV() ;
        }
        private string tukhoa = "";
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var mgv = dgvDsGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new FormGiaovien(mgv).ShowDialog();
                LoadDSGV();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new FormGiaovien(null).ShowDialog();
            LoadDSGV();
        }
    }
}
