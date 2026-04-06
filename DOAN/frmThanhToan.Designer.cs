namespace DOAN
{
    partial class frmThanhToan
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
            btnThanhToan = new Button();
            btnHuyBo = new Button();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            radVip = new RadioButton();
            radThuong = new RadioButton();
            label6 = new Label();
            txtTenSan = new TextBox();
            label7 = new Label();
            txtTenNhanVien = new TextBox();
            label8 = new Label();
            txtTenKhachHang = new TextBox();
            label9 = new Label();
            txtMaDatSan = new TextBox();
            label10 = new Label();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.LightGreen;
            btnThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.Black;
            btnThanhToan.Location = new Point(166, 322);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(141, 46);
            btnThanhToan.TabIndex = 1;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Crimson;
            btnHuyBo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(330, 322);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(141, 46);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(btnHuyBo);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtTenSan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTenNhanVien);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTenKhachHang);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtMaDatSan);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(652, 407);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thanh toán";
            // 
            // panel1
            // 
            panel1.Controls.Add(radVip);
            panel1.Controls.Add(radThuong);
            panel1.Location = new Point(200, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 64);
            panel1.TabIndex = 11;
            // 
            // radVip
            // 
            radVip.AutoSize = true;
            radVip.ForeColor = Color.Black;
            radVip.Location = new Point(147, 18);
            radVip.Name = "radVip";
            radVip.Size = new Size(75, 31);
            radVip.TabIndex = 10;
            radVip.TabStop = true;
            radVip.Text = "VIP";
            radVip.UseVisualStyleBackColor = true;
            // 
            // radThuong
            // 
            radThuong.AutoSize = true;
            radThuong.ForeColor = Color.Black;
            radThuong.Location = new Point(16, 18);
            radThuong.Name = "radThuong";
            radThuong.Size = new Size(112, 31);
            radThuong.TabIndex = 9;
            radThuong.TabStop = true;
            radThuong.Text = "Thường";
            radThuong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(22, 223);
            label6.Name = "label6";
            label6.Size = new Size(108, 27);
            label6.TabIndex = 8;
            label6.Text = "Phân loại:";
            // 
            // txtTenSan
            // 
            txtTenSan.Location = new Point(462, 49);
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Size = new Size(145, 35);
            txtTenSan.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(363, 53);
            label7.Name = "label7";
            label7.Size = new Size(93, 27);
            label7.TabIndex = 6;
            label7.Text = "Tên sân:";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(200, 165);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(407, 35);
            txtTenNhanVien.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 169);
            label8.Name = "label8";
            label8.Size = new Size(155, 27);
            label8.TabIndex = 4;
            label8.Text = "Tên nhân viên:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(200, 106);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(407, 35);
            txtTenKhachHang.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(22, 110);
            label9.Name = "label9";
            label9.Size = new Size(171, 27);
            label9.TabIndex = 2;
            label9.Text = "Tên khách hàng:";
            // 
            // txtMaDatSan
            // 
            txtMaDatSan.Location = new Point(158, 49);
            txtMaDatSan.Name = "txtMaDatSan";
            txtMaDatSan.Size = new Size(190, 35);
            txtMaDatSan.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(22, 53);
            label10.Name = "label10";
            label10.Size = new Size(130, 27);
            label10.TabIndex = 0;
            label10.Text = "Mã đặt sân: ";
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(652, 407);
            Controls.Add(groupBox2);
            ForeColor = Color.Transparent;
            Name = "frmThanhToan";
            Text = "frmThanhToan";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radVip;
        private System.Windows.Forms.RadioButton radThuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaDatSan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}