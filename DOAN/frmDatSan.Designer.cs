namespace DOAN
{
    partial class frmDatSan
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
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            cboThoiGian = new ComboBox();
            label2 = new Label();
            dtpChonNgay = new DateTimePicker();
            label1 = new Label();
            panel1 = new Panel();
            lblSanE = new Label();
            lblSanD = new Label();
            lblSanC = new Label();
            lblSanB = new Label();
            lblSanA = new Label();
            groupBox2 = new GroupBox();
            btnTraCuuDatSan = new Button();
            txtTraCuuDatSan = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(cboThoiGian);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpChonNgay);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sân:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(847, 38);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(119, 49);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboThoiGian
            // 
            cboThoiGian.FormattingEnabled = true;
            cboThoiGian.Location = new Point(620, 45);
            cboThoiGian.Name = "cboThoiGian";
            cboThoiGian.Size = new Size(180, 30);
            cboThoiGian.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 45);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 2;
            label2.Text = "Chọn thời gian:";
            // 
            // dtpChonNgay
            // 
            dtpChonNgay.Format = DateTimePickerFormat.Short;
            dtpChonNgay.Location = new Point(169, 45);
            dtpChonNgay.Name = "dtpChonNgay";
            dtpChonNgay.Size = new Size(250, 30);
            dtpChonNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 0;
            label1.Text = "Chọn ngày:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSanE);
            panel1.Controls.Add(lblSanD);
            panel1.Controls.Add(lblSanC);
            panel1.Controls.Add(lblSanB);
            panel1.Controls.Add(lblSanA);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(12, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 473);
            panel1.TabIndex = 1;
            // 
            // lblSanE
            // 
            lblSanE.BorderStyle = BorderStyle.FixedSingle;
            lblSanE.Image = Properties.Resources.caisan;
            lblSanE.Location = new Point(788, 110);
            lblSanE.Name = "lblSanE";
            lblSanE.Size = new Size(188, 348);
            lblSanE.TabIndex = 5;
            lblSanE.Text = " ";
            // 
            // lblSanD
            // 
            lblSanD.BorderStyle = BorderStyle.FixedSingle;
            lblSanD.Location = new Point(594, 110);
            lblSanD.Name = "lblSanD";
            lblSanD.Size = new Size(188, 348);
            lblSanD.TabIndex = 4;
            lblSanD.Text = " ";
            // 
            // lblSanC
            // 
            lblSanC.BorderStyle = BorderStyle.FixedSingle;
            lblSanC.Location = new Point(400, 110);
            lblSanC.Name = "lblSanC";
            lblSanC.Size = new Size(188, 348);
            lblSanC.TabIndex = 3;
            lblSanC.Text = " ";
            // 
            // lblSanB
            // 
            lblSanB.BorderStyle = BorderStyle.FixedSingle;
            lblSanB.Location = new Point(206, 110);
            lblSanB.Name = "lblSanB";
            lblSanB.Size = new Size(188, 348);
            lblSanB.TabIndex = 2;
            lblSanB.Text = " ";
            // 
            // lblSanA
            // 
            lblSanA.BorderStyle = BorderStyle.FixedSingle;
            lblSanA.Location = new Point(12, 110);
            lblSanA.Name = "lblSanA";
            lblSanA.Size = new Size(188, 348);
            lblSanA.TabIndex = 1;
            lblSanA.Text = " ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTraCuuDatSan);
            groupBox2.Controls.Add(txtTraCuuDatSan);
            groupBox2.Location = new Point(12, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(964, 92);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tra cứu đặt sân:";
            // 
            // btnTraCuuDatSan
            // 
            btnTraCuuDatSan.Location = new Point(835, 29);
            btnTraCuuDatSan.Name = "btnTraCuuDatSan";
            btnTraCuuDatSan.Size = new Size(119, 49);
            btnTraCuuDatSan.TabIndex = 5;
            btnTraCuuDatSan.Text = "Tra cứu";
            btnTraCuuDatSan.UseVisualStyleBackColor = true;
            // 
            // txtTraCuuDatSan
            // 
            txtTraCuuDatSan.Location = new Point(16, 29);
            txtTraCuuDatSan.Multiline = true;
            txtTraCuuDatSan.Name = "txtTraCuuDatSan";
            txtTraCuuDatSan.Size = new Size(795, 49);
            txtTraCuuDatSan.TabIndex = 0;
            // 
            // frmDatSan
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1011, 600);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDatSan";
            Text = "Đặt sân";
            Load += frmDatSan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnTimKiem;
        private ComboBox cboThoiGian;
        private Label label2;
        private DateTimePicker dtpChonNgay;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button btnTraCuuDatSan;
        private TextBox txtTraCuuDatSan;
        private Label lblSanA;
        private Label lblSanE;
        private Label lblSanD;
        private Label lblSanC;
        private Label lblSanB;
    }
}