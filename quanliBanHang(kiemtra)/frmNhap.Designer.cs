namespace quanliBanHang_kiemtra_
{
    partial class frmNhap
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
            this.components = new System.ComponentModel.Container();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtidcus = new System.Windows.Forms.TextBox();
            this.txtidpro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(157, 12);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(224, 22);
            this.txtdate.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(157, 74);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(224, 22);
            this.txttotal.TabIndex = 2;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(157, 351);
            this.txtcost.Name = "txtcost";
            this.txtcost.ReadOnly = true;
            this.txtcost.Size = new System.Drawing.Size(224, 22);
            this.txtcost.TabIndex = 6;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(157, 146);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(224, 22);
            this.txtstatus.TabIndex = 4;
            // 
            // txtidcus
            // 
            this.txtidcus.Location = new System.Drawing.Point(157, 217);
            this.txtidcus.Name = "txtidcus";
            this.txtidcus.Size = new System.Drawing.Size(224, 22);
            this.txtidcus.TabIndex = 5;
            // 
            // txtidpro
            // 
            this.txtidpro.Location = new System.Drawing.Point(157, 291);
            this.txtidpro.Name = "txtidpro";
            this.txtidpro.Size = new System.Drawing.Size(224, 22);
            this.txtidpro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã sản phẩm";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(116, 414);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 24);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(247, 414);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(93, 24);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidpro);
            this.Controls.Add(this.txtidcus);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtdate);
            this.Name = "frmNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmxuat";
            this.Load += new System.EventHandler(this.frmxuat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtidcus;
        private System.Windows.Forms.TextBox txtidpro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}