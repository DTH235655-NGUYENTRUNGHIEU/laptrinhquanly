namespace DOAN
{
    partial class frmSan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboTrangThai = new ComboBox();
            cboLoai = new ComboBox();
            txtGia = new TextBox();
            txtTen = new TextBox();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnXuat = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenSan = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(cboLoai);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1016, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sân";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(602, 100);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(252, 30);
            cboTrangThai.TabIndex = 44;
            // 
            // cboLoai
            // 
            cboLoai.FormattingEnabled = true;
            cboLoai.Location = new Point(195, 100);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(252, 30);
            cboLoai.TabIndex = 43;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(602, 29);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(252, 30);
            txtGia.TabIndex = 42;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(195, 29);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(252, 30);
            txtTen.TabIndex = 41;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightGreen;
            btnThoat.Image = Properties.Resources.exit_icon_icons_com_70975;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(685, 168);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 48);
            btnThoat.TabIndex = 40;
            btnThoat.Text = "  Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += this.btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.LightGreen;
            btnHuy.Image = Properties.Resources.vcsconflicting_93497;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(527, 168);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 48);
            btnHuy.TabIndex = 39;
            btnHuy.Text = "     Hủy Bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.Image = Properties.Resources.Save_37110;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(361, 168);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 48);
            btnLuu.TabIndex = 38;
            btnLuu.Text = "  Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Image = Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(195, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 48);
            btnXoa.TabIndex = 37;
            btnXoa.Text = " Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightGreen;
            btnSua.Image = Properties.Resources.edit_pencil_6320__1_;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(27, 168);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(132, 48);
            btnSua.TabIndex = 36;
            btnSua.Text = "  Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.LightGreen;
            btnXuat.Image = Properties.Resources.microsoft_office_excel_logo_icon_145720;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(847, 168);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(137, 48);
            btnXuat.TabIndex = 14;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 103);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 4;
            label4.Text = "Trạng Thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 36);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 3;
            label3.Text = "Giá Thuê:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 103);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 2;
            label2.Text = "Loại Sân:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 36);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên Sân:";
            // 
            // txtTenSan
            // 
            txtTenSan.Location = new Point(191, 33);
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Size = new Size(241, 27);
            txtTenSan.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1016, 291);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sân";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1010, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // frmSan
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1016, 608);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmSan";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnXuat;
        private ComboBox comboBox1;
        private TextBox txtTenSan;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private ComboBox cboTrangThai;
        private ComboBox cboLoai;
        private TextBox txtGia;
        private TextBox txtTen;
    }
}
