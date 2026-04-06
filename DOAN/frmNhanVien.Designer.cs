namespace DOAN
{
    partial class frmNhanVien
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
            dataGridView1 = new DataGridView();
            btnSua = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            txtMK = new TextBox();
            btnXuat = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            txtVaiTro = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtTK = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 26);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1146, 293);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightGreen;
            btnSua.Image = Properties.Resources.edit_pencil_6320__1_;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(75, 185);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(127, 46);
            btnSua.TabIndex = 7;
            btnSua.Text = "  Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 286);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1154, 322);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sân";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtVaiTro);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtTK);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1154, 269);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(676, 105);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(134, 30);
            txtMK.TabIndex = 37;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.LightGreen;
            btnXuat.Image = Properties.Resources.microsoft_office_excel_logo_icon_145720;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(901, 185);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(132, 46);
            btnXuat.TabIndex = 36;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightGreen;
            btnThoat.Image = Properties.Resources.exit_icon_icons_com_70975;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(730, 185);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(132, 46);
            btnThoat.TabIndex = 35;
            btnThoat.Text = "  Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.LightGreen;
            btnHuy.Image = Properties.Resources.vcsconflicting_93497;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(567, 185);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(124, 46);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "     Hủy Bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.Image = Properties.Resources.Save_37110;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(404, 185);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(124, 46);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "  Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Image = Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(241, 185);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 46);
            btnXoa.TabIndex = 32;
            btnXoa.Text = " Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(988, 92);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(151, 30);
            txtVaiTro.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(988, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 30);
            dateTimePicker1.TabIndex = 30;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(447, 105);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(134, 30);
            txtTK.TabIndex = 28;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(447, 47);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(352, 30);
            txtDiaChi.TabIndex = 27;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(151, 107);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(175, 30);
            txtSDT.TabIndex = 26;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(151, 50);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(175, 30);
            txtTen.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(838, 94);
            label8.Name = "label8";
            label8.Size = new Size(75, 22);
            label8.TabIndex = 23;
            label8.Text = "Vai Trò:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(838, 47);
            label7.Name = "label7";
            label7.Size = new Size(133, 22);
            label7.TabIndex = 22;
            label7.Text = "Ngày Vào Làm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 110);
            label6.Name = "label6";
            label6.Size = new Size(93, 22);
            label6.TabIndex = 21;
            label6.Text = "Mật Khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 108);
            label5.Name = "label5";
            label5.Size = new Size(99, 22);
            label5.TabIndex = 20;
            label5.Text = "Tài Khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 55);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 19;
            label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 110);
            label3.Name = "label3";
            label3.Size = new Size(131, 22);
            label3.TabIndex = 18;
            label3.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 58);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 17;
            label1.Text = "Tên Nhân Viên:";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1154, 608);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            Click += frmNhanVien_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSua;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTK;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTen;
        private TextBox txtVaiTro;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private TextBox txtMK;
    }
}