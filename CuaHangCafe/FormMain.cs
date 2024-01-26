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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string loaitk = "";
        private string tendangnhap = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            var fdangnhap = new FormDangNhap();
            fdangnhap.ShowDialog();
            tendangnhap=fdangnhap.tendangnhap;
            loaitk= fdangnhap.loaitk;
            if(loaitk.Equals("admin"))
            {
                chamDiemToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if(loaitk.Equals("gv"))
                {
                    chucNangToolStripMenuItem.Visible=false;
                }
                else
                {
                    chamDiemToolStripMenuItem.Visible = false;
                }
            }
            FormWelcome f=new FormWelcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDsSV f=new FormDsSV();
            AddForm(f);
        }

        private void monhocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDsMH f=new FormDsMH();
            AddForm(f);
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDsGV f=new FormDsGV();
            AddForm(f);
        }

        private void diemThiToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FormKetQuaHocTap f=new FormKetQuaHocTap(tendangnhap);
            AddForm(f);
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ChucNangToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dangKyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDsMonDaDK f = new FormDsMonDaDK(tendangnhap);
            AddForm(f);
        }

        private void chamDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopHocCuaGV f = new LopHocCuaGV(tendangnhap);
            AddForm(f);
        }
    }
}
