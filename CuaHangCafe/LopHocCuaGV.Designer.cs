namespace CuaHangCafe
{
    partial class LopHocCuaGV
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
            this.dgvLopHocGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLopHocGV
            // 
            this.dgvLopHocGV.AllowUserToAddRows = false;
            this.dgvLopHocGV.AllowUserToDeleteRows = false;
            this.dgvLopHocGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHocGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLopHocGV.Location = new System.Drawing.Point(0, 128);
            this.dgvLopHocGV.MultiSelect = false;
            this.dgvLopHocGV.Name = "dgvLopHocGV";
            this.dgvLopHocGV.ReadOnly = true;
            this.dgvLopHocGV.RowHeadersWidth = 51;
            this.dgvLopHocGV.RowTemplate.Height = 24;
            this.dgvLopHocGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHocGV.Size = new System.Drawing.Size(1367, 415);
            this.dgvLopHocGV.TabIndex = 0;
            this.dgvLopHocGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHocGV_CellContentClick);
            this.dgvLopHocGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHocGV_CellDoubleClick);
            // 
            // LopHocCuaGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 543);
            this.Controls.Add(this.dgvLopHocGV);
            this.Name = "LopHocCuaGV";
            this.Text = "LopHocCuaGV";
            this.Load += new System.EventHandler(this.LopHocCuaGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLopHocGV;
    }
}