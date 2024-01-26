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
    public partial class FormDsLopHoc : Form
    {
        public FormDsLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void FormDsLopHoc_Load(object sender, EventArgs e)
        {
            LoadDsLopHoc();
        }
        private void LoadDsLopHoc()
        {
            string sql = "SelectAllLopHoc";
            List<CustomParameter> lstPara= new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvLopHoc.DataSource= new Database().SelectData(sql, lstPara);
            dgvLopHoc.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns["gv"].HeaderText = "Giáo viên";
            dgvLopHoc.Columns["tenmonhoc"].HeaderText = "Tên môn học";
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                new FormLopHoc(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                LoadDsLopHoc();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tukhoa=txtsearch.Text;
            LoadDsLopHoc();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new FormLopHoc(null).ShowDialog();
            LoadDsLopHoc();
        }
    }
}
