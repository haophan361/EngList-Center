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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }
        private string mamh;
        private string nguoithuchien = "admin";
        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new Database().Select("SelectMH '" + int.Parse(mamh) + "'");
                txtmonhoc.Text = r["tenmonhoc"].ToString();
                txttinchi.Text = r["sotinchi"].ToString();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tenmonhoc=txtmonhoc.Text;
            try
            {
                var sotinchi=int.Parse(txttinchi.Text);
                if(sotinchi<=0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Số tín chỉ phải là số nguyên ");
                txttinchi.Select();
                return;
            }
            if(string.IsNullOrEmpty((string)txtmonhoc.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txtmonhoc.Select();
                return;
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh) )
            {
                sql = "InsertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "UpdateMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtmonhoc.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txttinchi.Text
            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                }
            }
            else
            {
                MessageBox.Show("Thực hiện thất bại");
            }
        }
    }
}
