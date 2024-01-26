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
    public partial class FormDsMH : Form
    {
        public FormDsMH()
        {
            InitializeComponent();
        }
        private string tukhoa="";
        private void DsMH_Load(object sender, EventArgs e)
        {
            LoadDsMH();
        }
        private void LoadDsMH()
        {
            List<CustomParameter> lstPara= new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            dgvMonHoc.DataSource = new Database().SelectData("SelectAllMonHoc", lstPara);
            dgvMonHoc.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvMonHoc.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvMonHoc.Columns["sotinchi"].HeaderText = "Số tín chỉ";
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                var mamh = dgvMonHoc.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new FormMonHoc(mamh).ShowDialog();
                LoadDsMH();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new FormMonHoc(null).ShowDialog();
            LoadDsMH();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tukhoa=txtsearch.Text;
            LoadDsMH();
        }
    }
}
