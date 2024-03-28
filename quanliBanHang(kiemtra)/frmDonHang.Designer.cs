namespace quanliBanHang_kiemtra_
{
    partial class frmDonHang
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
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDonHang.Location = new System.Drawing.Point(0, 150);
            this.dgvDonHang.MultiSelect = false;
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(1202, 432);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellContentClick);
            this.dgvDonHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellContentDoubleClick);
            this.dgvDonHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellDoubleClick);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(37, 65);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(134, 28);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(1049, 65);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(106, 28);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "Thêm";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(847, 65);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(134, 28);
            this.btnload.TabIndex = 5;
            this.btnload.Text = "Tải lại";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(209, 71);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(570, 22);
            this.txtsearch.TabIndex = 6;
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 582);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.dgvDonHang);
            this.Name = "frmDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox txtsearch;
    }
}

