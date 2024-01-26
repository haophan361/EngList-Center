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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk = "";
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(cbbLoaiTaiKhoan.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản khác");
                return;
            }

            if(string.IsNullOrEmpty(txttendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                txttendangnhap.Select();
                return;
            }
            if(string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            tendangnhap = txttendangnhap.Text;
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk="admin";
                    break;
                case "Giáo viên":
                    loaitk="gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }
            List<CustomParameter> list = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@loaitaikhoan",
                    value=loaitk,
                },
                new CustomParameter()
                {
                    key="@taikhoan",
                    value=txttendangnhap.Text
                },
                new CustomParameter()
                {
                    key ="@matkhau",
                    value=txtmatkhau.Text
                }
            };
            var rs = new Database().SelectData("dangnhap", list);
            if(rs.Rows.Count > 0 )
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
            //this.Hide();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
