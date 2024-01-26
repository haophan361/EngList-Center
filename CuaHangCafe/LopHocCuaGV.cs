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
    public partial class LopHocCuaGV : Form
    {
        public LopHocCuaGV(string magv)
        {
            InitializeComponent();
            this.magv = magv;
        }
        private string magv;
        private void LopHocCuaGV_Load(object sender, EventArgs e)
        {
            LoadLopHocCuaGv();
        }
        private void LoadLopHocCuaGv()
        {
            List<CustomParameter> list = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@magiaovien",
                    value=magv
                }
            };
            dgvLopHocGV.DataSource = new Database().SelectData("LopHocCuaGV", list);
            dgvLopHocGV.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvLopHocGV.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvLopHocGV.Columns["hoten"].HeaderText = "Giáo viên";
        }

        private void dgvLopHocGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLopHocGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var malophoc = dgvLopHocGV.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                var tenlophoc = dgvLopHocGV.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString();
                new FormDsSVTheoLop(malophoc,tenlophoc).ShowDialog();
                LoadLopHocCuaGv();
            }
        }
    }
}
