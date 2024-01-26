namespace CuaHangCafe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monhocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LophocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.chucNangToolStripMenuItem,
            this.chamDiemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1373, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doimatkhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hToolStripMenuItem.Text = "Hệ thống";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // doimatkhauToolStripMenuItem
            // 
            this.doimatkhauToolStripMenuItem.Name = "doimatkhauToolStripMenuItem";
            this.doimatkhauToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.doimatkhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.monhocToolStripMenuItem,
            this.giaoVienToolStripMenuItem,
            this.LophocToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            this.quanLyToolStripMenuItem.Click += new System.EventHandler(this.quanLyToolStripMenuItem_Click);
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.sinhVienToolStripMenuItem.Text = "Sinh viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // monhocToolStripMenuItem
            // 
            this.monhocToolStripMenuItem.Name = "monhocToolStripMenuItem";
            this.monhocToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.monhocToolStripMenuItem.Text = "Môn học";
            this.monhocToolStripMenuItem.Click += new System.EventHandler(this.monhocToolStripMenuItem_Click);
            // 
            // giaoVienToolStripMenuItem
            // 
            this.giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            this.giaoVienToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.giaoVienToolStripMenuItem.Text = "Giáo viên";
            this.giaoVienToolStripMenuItem.Click += new System.EventHandler(this.giaoVienToolStripMenuItem_Click);
            // 
            // LophocToolStripMenuItem
            // 
            this.LophocToolStripMenuItem.Name = "LophocToolStripMenuItem";
            this.LophocToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.LophocToolStripMenuItem.Text = "Lớp học";
            this.LophocToolStripMenuItem.Click += new System.EventHandler(this.diemThiToolStripMenuItem_Click);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangKyMonHocToolStripMenuItem,
            this.traCuuDiemToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.chucNangToolStripMenuItem.Text = "Đăng ký môn học";
            this.chucNangToolStripMenuItem.Click += new System.EventHandler(this.ChucNangToolStripMenuItem_Click);
            // 
            // dangKyMonHocToolStripMenuItem
            // 
            this.dangKyMonHocToolStripMenuItem.Name = "dangKyMonHocToolStripMenuItem";
            this.dangKyMonHocToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dangKyMonHocToolStripMenuItem.Text = "Đăng kí môn học";
            this.dangKyMonHocToolStripMenuItem.Click += new System.EventHandler(this.dangKyMonHocToolStripMenuItem_Click);
            // 
            // traCuuDiemToolStripMenuItem
            // 
            this.traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            this.traCuuDiemToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.traCuuDiemToolStripMenuItem.Text = "Tra cứu điểm";
            this.traCuuDiemToolStripMenuItem.Click += new System.EventHandler(this.diemThiToolStripMenuItem_Click);
            // 
            // chamDiemToolStripMenuItem
            // 
            this.chamDiemToolStripMenuItem.Name = "chamDiemToolStripMenuItem";
            this.chamDiemToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.chamDiemToolStripMenuItem.Text = "Chấm điểm";
            this.chamDiemToolStripMenuItem.Click += new System.EventHandler(this.chamDiemToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 477);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doimatkhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monhocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LophocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem chamDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyMonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuDiemToolStripMenuItem;
    }
}

