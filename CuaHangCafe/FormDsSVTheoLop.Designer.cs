namespace CuaHangCafe
{
    partial class FormDsSVTheoLop
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
            this.dgvSvInClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvInClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSvInClass
            // 
            this.dgvSvInClass.AllowUserToAddRows = false;
            this.dgvSvInClass.AllowUserToDeleteRows = false;
            this.dgvSvInClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSvInClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvInClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSvInClass.Location = new System.Drawing.Point(0, 135);
            this.dgvSvInClass.MultiSelect = false;
            this.dgvSvInClass.Name = "dgvSvInClass";
            this.dgvSvInClass.ReadOnly = true;
            this.dgvSvInClass.RowHeadersWidth = 51;
            this.dgvSvInClass.RowTemplate.Height = 24;
            this.dgvSvInClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSvInClass.Size = new System.Drawing.Size(1377, 365);
            this.dgvSvInClass.TabIndex = 0;
            this.dgvSvInClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSvInClass_CellDoubleClick);
            // 
            // FormDsSVTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 500);
            this.Controls.Add(this.dgvSvInClass);
            this.Name = "FormDsSVTheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDsSVTheoLop";
            this.Load += new System.EventHandler(this.FormDsSVTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvInClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSvInClass;
    }
}