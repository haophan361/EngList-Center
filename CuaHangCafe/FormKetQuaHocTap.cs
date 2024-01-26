using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangCafe
{
    public partial class FormKetQuaHocTap : Form
    {
        public FormKetQuaHocTap(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void FormKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKqHocTap();
        }
        private void LoadKqHocTap()
        {
            List<CustomParameter> list = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDiem.DataSource = new Database().SelectData("TraCuuDiem", list);
            dgvDiem.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDiem.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDiem.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDiem.Columns["giaovien"].HeaderText = "Giáo viên";
            dgvDiem.Columns["diemlan1"].HeaderText = " Điểm giữa kì";
            dgvDiem.Columns["diemlan2"].HeaderText = "Điểm cuối kì";
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
