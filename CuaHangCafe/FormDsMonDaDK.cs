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
    public partial class FormDsMonDaDK : Form
    {
        public FormDsMonDaDK(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void FormDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadFormDkMonHoc();
        }
        private void LoadFormDkMonHoc()
        {
            List<CustomParameter> list = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@masinhvien",
                    value=masv
                }
            };
            dgvDsMHDk.DataSource = new Database().SelectData("monDaDangKy", list);
            dgvDsMHDk.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDsMHDk.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDsMHDk.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDsMHDk.Columns["giaovien"].HeaderText = "Giáo viên";
        }

        private void btndangkymonhoc_Click(object sender, EventArgs e)
        {
            new FormDkMonHoc(masv).ShowDialog();
            LoadFormDkMonHoc();
        }
    }
}
