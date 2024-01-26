using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangCafe
{
    public partial class FormDkMonHoc : Form
    {
        public FormDkMonHoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private string masv;
        private void FormDkMonHoc_Load(object sender, EventArgs e)
        {
            LoadDsLopChuaDk();
        }
        private void LoadDsLopChuaDk()
        {
            List<CustomParameter> list = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@masinhvien",
                    value=masv
                }
            };
            dgvDsLop.DataSource = new Database().SelectData("dsLopChuaDk", list);
            dgvDsLop.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDsLop.Columns["mamonhoc"].Visible = false;
            dgvDsLop.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDsLop.Columns["giaovien"].HeaderText = "Giáo viên";
            dgvDsLop.Columns["sotinchi"].HeaderText = "Số tín chỉ";
        }

        private void dgvDsLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDsLop.Rows[e.RowIndex].Index>0)
            {
                if
                    (DialogResult.Yes ==
                    MessageBox.Show
                    ("Bạn muốn đăng kí học phần [" + dgvDsLop.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]"
                    , "Xác nhận đăng kí",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question))
                {
                    List<CustomParameter> lstPara= new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = masv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDsLop.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });
                    var rs = new Database().Execute("[dkmonhoc]", lstPara);
                    if(rs==-1)
                    {
                        MessageBox.Show("Bạn đã đăng kí học phần này bạn hãy đăng kí môn khác");
                        return;
                    }
                    if(rs==1)
                    {
                        MessageBox.Show("Đã đăng kí học phần thành công");
                        LoadDsLopChuaDk();
                    }
                }
                else
                {
                    return;     
                }
            }

        }
    }
}
