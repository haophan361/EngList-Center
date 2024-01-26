namespace CuaHangCafe
{
    partial class FormDsMonDaDK
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
            this.dgvDsMHDk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndangkymonhoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMHDk)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsMHDk
            // 
            this.dgvDsMHDk.AllowUserToAddRows = false;
            this.dgvDsMHDk.AllowUserToDeleteRows = false;
            this.dgvDsMHDk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsMHDk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsMHDk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsMHDk.Location = new System.Drawing.Point(0, 129);
            this.dgvDsMHDk.MultiSelect = false;
            this.dgvDsMHDk.Name = "dgvDsMHDk";
            this.dgvDsMHDk.ReadOnly = true;
            this.dgvDsMHDk.RowHeadersWidth = 51;
            this.dgvDsMHDk.RowTemplate.Height = 24;
            this.dgvDsMHDk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsMHDk.Size = new System.Drawing.Size(1397, 414);
            this.dgvDsMHDk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Location = new System.Drawing.Point(793, 27);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(308, 22);
            this.txtsearch.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.Location = new System.Drawing.Point(1120, 17);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(95, 32);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btndangkymonhoc
            // 
            this.btndangkymonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndangkymonhoc.Location = new System.Drawing.Point(1240, 17);
            this.btndangkymonhoc.Name = "btndangkymonhoc";
            this.btndangkymonhoc.Size = new System.Drawing.Size(133, 32);
            this.btndangkymonhoc.TabIndex = 4;
            this.btndangkymonhoc.Text = "Đăng ký môn học";
            this.btndangkymonhoc.UseVisualStyleBackColor = true;
            this.btndangkymonhoc.Click += new System.EventHandler(this.btndangkymonhoc_Click);
            // 
            // FormDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 543);
            this.Controls.Add(this.btndangkymonhoc);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDsMHDk);
            this.Name = "FormDangKyMonHoc";
            this.Text = "Danh sách môn học đã đăng ký";
            this.Load += new System.EventHandler(this.FormDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsMHDk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsMHDk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndangkymonhoc;
    }
}