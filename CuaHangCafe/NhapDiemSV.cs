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
    public partial class NhapDiemSV : Form
    {
        public NhapDiemSV(string malop,string masv)
        {
            this.malop = malop;
            this.masv = masv;
            InitializeComponent();
        }

        private string malop, masv;
        private void NhapDiemSV_Load(object sender, EventArgs e)
        {
            this.Text = "Nhập điểm cho sinh viên";
            var r = new Database().Select("NhapDiemSV '" + malop + "','" + masv + "'");
            txtdiemlan1.Text = r["diemlan1"].ToString();
            txtdiemlan2.Text = r["diemlan2"].ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var diemlan1 = double.Parse(txtdiemlan1.Text);
                if (diemlan1 < 0 || diemlan1>10)
                {
                    MessageBox.Show("Điểm nhập vào phải lớn hơn 0 và bé hơn 10");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Điểm phải là số ");
                txtdiemlan1.Select();
                return;
            }
            try
            {
                var diemlan2 = double.Parse(txtdiemlan2.Text);
                if (diemlan2 < 0 || diemlan2 > 10)
                {
                    MessageBox.Show("Điểm nhập vào phải lớn hơn 0 và bé hơn 10");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Điểm phải là số ");
                txtdiemlan2.Select();
                return;
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malop
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diemlan1",
                value = txtdiemlan1.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diemlan2",
                value = txtdiemlan2.Text
            });
            var rs = new Database().Execute("CapNhatDiemSV", lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Đã cập nhật điểm thành công");
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
