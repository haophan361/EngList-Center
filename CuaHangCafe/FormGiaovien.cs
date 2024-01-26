using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangCafe
{
    public partial class FormGiaovien : Form
    {
        public FormGiaovien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithuchien = "admin";
        private void FormGiaovien_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên";
                var r = new Database().Select("SelectGV '" + int.Parse(mgv) + "'");
                txtho.Text = r["ho"].ToString();
                txttendem.Text = r["tendem"].ToString();
                txtten.Text = r["ten"].ToString();
                if (int.Parse(r["gioitinh"].ToString())==0)
                {
                    radnu.Checked = true;
                }
                maskngaysinh.Text = r["nsinh"].ToString();
                txtdienthoai.Text = r["dienthoai"].ToString() ;
                txtemail.Text = r["email"].ToString() ;
                txtdiachi.Text = r["diachi"].ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txtho.Text;
            string tendem = txttendem.Text;
            string ten = txtten.Text;
            string gioitinh = "1";
            if (radnu.Checked)
            {
                gioitinh = "0";
            }
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(maskngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(Exception) 
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                maskngaysinh.Select();
                return;
            }
            string dienthoai = txtdienthoai.Text;
            string email = txtemail.Text;
            string diachi = txtdiachi.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "UpdateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });
                
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật giáo viên thành công");
                }
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
        }
    }
}
