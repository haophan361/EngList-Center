using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangCafe
{
    public partial class FormLopHoc : Form
    {
        public FormLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database database;
        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            database = new Database();
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@tukhoa",
                    value=""
                }
            };
            cbbmonhoc.DataSource = database.SelectData("SelectAllMonHoc", lstPara);
            cbbmonhoc.DisplayMember = "tenmonhoc";
            cbbmonhoc.ValueMember = "mamonhoc";
            cbbmonhoc.SelectedValue = -1;

            cbbgiaovien.DataSource = database.SelectData("SelectAllGiaoVien", lstPara);
            cbbgiaovien.DisplayMember = "hoten";
            cbbgiaovien.ValueMember = "magiaovien";
            cbbgiaovien.SelectedValue = -1;
            if(string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật thông tin lớp học";
                var r = database.Select("SelectLopHoc '" + malophoc + "'");
                cbbmonhoc.SelectedValue = r["mamonhoc"].ToString();
                cbbgiaovien.SelectedValue = r["magiaovien"].ToString();
                
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string nguoithuchien = "admin";
        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbbmonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if (cbbgiaovien.SelectedIndex<0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            List<CustomParameter> list = new List<CustomParameter>();
            if(string.IsNullOrEmpty(malophoc))
            {
                sql = "InsertLopHoc";
                list.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "UpdateLopHoc";
                list.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                list.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
                list.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = cbbmonhoc.SelectedValue.ToString()
                });
                list.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = cbbgiaovien.SelectedValue.ToString()
                });
            }
            var kq = database.Execute(sql, list);
            if(kq==1)
            {
                if(string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin lớp học thành công");
                }
            }
            else
            {
                MessageBox.Show("Lỗi thực thi câu lệnh");
            }
        }
    }
}
