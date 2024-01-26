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
    public partial class FormDsSVTheoLop : Form
    {
        public FormDsSVTheoLop(string malop,string tenlophoc)
        {
            this.malop = malop;
            this.tenlophoc = tenlophoc;
            InitializeComponent();
            this.Text = "Lớp " + malop + "_" + tenlophoc;
        }
        private string malop;
        private string tenlophoc;
        private void FormDsSVTheoLop_Load(object sender, EventArgs e)
        {
            LoadDsSVTheoLop();
        }
        private void LoadDsSVTheoLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malop
            });
            dgvSvInClass.DataSource = new Database().SelectData("DsSVTrongLop", lstPara);
            dgvSvInClass.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvSvInClass.Columns["sinhvien"].HeaderText = "Họ tên sinh viên";
            dgvSvInClass.Columns["diemlan1"].HeaderText = "Điểm giữa kì";
            dgvSvInClass.Columns["diemlan2"].HeaderText = "Điểm cuối kì";
        }
        private void dgvSvInClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                string masv = dgvSvInClass.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new NhapDiemSV(malop,masv).ShowDialog();
            }
            LoadDsSVTheoLop();
        }
    }
}
