namespace CuaHangCafe
{
    partial class FormLopHoc
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
            this.txtmonhoc = new System.Windows.Forms.Label();
            this.txtgiaovien = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cbbmonhoc = new System.Windows.Forms.ComboBox();
            this.cbbgiaovien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtmonhoc
            // 
            this.txtmonhoc.AutoSize = true;
            this.txtmonhoc.Location = new System.Drawing.Point(48, 27);
            this.txtmonhoc.Name = "txtmonhoc";
            this.txtmonhoc.Size = new System.Drawing.Size(58, 16);
            this.txtmonhoc.TabIndex = 0;
            this.txtmonhoc.Text = "Môn học";
            this.txtmonhoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtgiaovien
            // 
            this.txtgiaovien.AutoSize = true;
            this.txtgiaovien.Location = new System.Drawing.Point(48, 81);
            this.txtgiaovien.Name = "txtgiaovien";
            this.txtgiaovien.Size = new System.Drawing.Size(64, 16);
            this.txtgiaovien.TabIndex = 2;
            this.txtgiaovien.Text = "Giáo viên";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(148, 159);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(276, 159);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cbbmonhoc
            // 
            this.cbbmonhoc.FormattingEnabled = true;
            this.cbbmonhoc.Location = new System.Drawing.Point(148, 27);
            this.cbbmonhoc.Name = "cbbmonhoc";
            this.cbbmonhoc.Size = new System.Drawing.Size(309, 24);
            this.cbbmonhoc.TabIndex = 6;
            // 
            // cbbgiaovien
            // 
            this.cbbgiaovien.FormattingEnabled = true;
            this.cbbgiaovien.Location = new System.Drawing.Point(148, 81);
            this.cbbgiaovien.Name = "cbbgiaovien";
            this.cbbgiaovien.Size = new System.Drawing.Size(309, 24);
            this.cbbgiaovien.TabIndex = 7;
            // 
            // FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 213);
            this.Controls.Add(this.cbbgiaovien);
            this.Controls.Add(this.cbbmonhoc);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtgiaovien);
            this.Controls.Add(this.txtmonhoc);
            this.Name = "FormLopHoc";
            this.Text = "FormLopHoc";
            this.Load += new System.EventHandler(this.FormLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtmonhoc;
        private System.Windows.Forms.Label txtgiaovien;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cbbmonhoc;
        private System.Windows.Forms.ComboBox cbbgiaovien;
    }
}