namespace CuaHangCafe
{
    partial class FormDkMonHoc
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
            this.dgvDsLop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsLop
            // 
            this.dgvDsLop.AllowUserToAddRows = false;
            this.dgvDsLop.AllowUserToDeleteRows = false;
            this.dgvDsLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDsLop.Location = new System.Drawing.Point(0, 195);
            this.dgvDsLop.MultiSelect = false;
            this.dgvDsLop.Name = "dgvDsLop";
            this.dgvDsLop.ReadOnly = true;
            this.dgvDsLop.RowHeadersWidth = 51;
            this.dgvDsLop.RowTemplate.Height = 24;
            this.dgvDsLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsLop.Size = new System.Drawing.Size(1379, 349);
            this.dgvDsLop.TabIndex = 0;
            this.dgvDsLop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsLop_CellDoubleClick);
            // 
            // FormDkMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 544);
            this.Controls.Add(this.dgvDsLop);
            this.Name = "FormDkMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học";
            this.Load += new System.EventHandler(this.FormDkMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsLop;
    }
}