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
    public partial class FormSinhvien : Form
    {
        public FormSinhvien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void FormSinhvien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                
                this.Text = "Cập nhật thông tin sinh viên";
                var r = new Database().Select("EXEC SelectSV '" + msv+"' ");
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                maskedNgaysinh.Text = r["nsinh"].ToString();
                if ((r["gtinh"].ToString()) == "Nữ")
                {
                    radNu.Checked = true;
                }
                txtQuequan.Text = r["quequan"].ToString() ;
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql;
            string ho=txtHo.Text;
            string tendem=txtTendem.Text;
            string ten=txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh=DateTime.ParseExact(maskedNgaysinh.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            }
            catch(Exception) 
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                maskedNgaysinh.Select();
                return;
            }
            string gioitinh="1";
            if(radNu.Checked)
            {
                gioitinh = "0";
            }
            string quequan=txtQuequan.Text;
            string diachi=txtDiachi.Text;
            string dienthoai=txtDienthoai.Text;
            string email=txtEmail.Text;
            List<CustomParameter> lstPara=new List<CustomParameter>();
            if(string.IsNullOrEmpty(msv))
            {
                sql = "AddSV";
            }
            else
            {
                sql = "UpdateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Masinhvien",
                    value = msv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@Ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            }); ;
            lstPara.Add(new CustomParameter()
            {
                key = "@Gioitinh",
                value = gioitinh
            }); 
            lstPara.Add(new CustomParameter()
            {
                key = "@Quequan",
                value = quequan
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = email
            });
            var rs=new Database().Execute(sql,lstPara);
            if(rs==1)
            {
                if(string.IsNullOrEmpty(msv)) 
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thành công");
                }
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
