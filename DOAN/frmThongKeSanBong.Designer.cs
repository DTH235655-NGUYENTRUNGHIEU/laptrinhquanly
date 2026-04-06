namespace DOAN
{
    partial class frmThongKeSanBong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel11 = new Panel();
            label5 = new Label();
            panel12 = new Panel();
            panel4 = new Panel();
            panel10 = new Panel();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            panel9 = new Panel();
            dtgSanBong = new DataGridView();
            panel8 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            btnXemSanBong = new Button();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            chartSanBong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSanBong).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSanBong).BeginInit();
            SuspendLayout();
            // 
            // panel11
            // 
            panel11.Location = new Point(0, 68);
            panel11.Name = "panel11";
            panel11.Size = new Size(988, 37);
            panel11.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(14, 14);
            label5.Name = "label5";
            label5.Size = new Size(181, 26);
            label5.TabIndex = 12;
            label5.Text = "Tổng doanh thu:";
            // 
            // panel12
            // 
            panel12.Location = new Point(0, 68);
            panel12.Name = "panel12";
            panel12.Size = new Size(988, 37);
            panel12.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel12);
            panel4.Location = new Point(300, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(688, 377);
            panel4.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Honeydew;
            panel10.Controls.Add(panel4);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(513, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(475, 408);
            panel10.TabIndex = 13;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(450, 6);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(184, 31);
            dtpDenNgay.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 8);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 10;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(127, 6);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(184, 31);
            dtpTuNgay.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 8);
            label1.Name = "label1";
            label1.Size = new Size(97, 27);
            label1.TabIndex = 8;
            label1.Text = "Từ ngày:";
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(dtgSanBong);
            panel9.Location = new Point(12, 130);
            panel9.Name = "panel9";
            panel9.Size = new Size(514, 408);
            panel9.TabIndex = 13;
            // 
            // dtgSanBong
            // 
            dtgSanBong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSanBong.Dock = DockStyle.Fill;
            dtgSanBong.Location = new Point(0, 0);
            dtgSanBong.Name = "dtgSanBong";
            dtgSanBong.RowHeadersWidth = 62;
            dtgSanBong.Size = new Size(514, 408);
            dtgSanBong.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Location = new Point(0, 68);
            panel8.Name = "panel8";
            panel8.Size = new Size(988, 37);
            panel8.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(988, 37);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Honeydew;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(12, 536);
            panel7.Name = "panel7";
            panel7.Size = new Size(988, 54);
            panel7.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(0, 26);
            label3.TabIndex = 12;
            // 
            // btnXemSanBong
            // 
            btnXemSanBong.BackColor = Color.SteelBlue;
            btnXemSanBong.FlatStyle = FlatStyle.Popup;
            btnXemSanBong.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnXemSanBong.ForeColor = SystemColors.ButtonHighlight;
            btnXemSanBong.Location = new Point(697, 9);
            btnXemSanBong.Name = "btnXemSanBong";
            btnXemSanBong.Size = new Size(283, 43);
            btnXemSanBong.TabIndex = 17;
            btnXemSanBong.Text = "Xem sân bóng";
            btnXemSanBong.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpDenNgay);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dtpTuNgay);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(14, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(672, 43);
            panel5.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnXemSanBong);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(12, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 62);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 37);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 62);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 13);
            label4.Name = "label4";
            label4.Size = new Size(321, 32);
            label4.TabIndex = 4;
            label4.Text = "THỐNG KÊ SÂN BÓNG";
            // 
            // chartSanBong
            // 
            chartArea1.Name = "ChartArea1";
            chartSanBong.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSanBong.Legends.Add(legend1);
            chartSanBong.Location = new Point(525, 130);
            chartSanBong.Name = "chartSanBong";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSanBong.Series.Add(series1);
            chartSanBong.Size = new Size(475, 408);
            chartSanBong.TabIndex = 14;
            chartSanBong.Text = "chart1";
            // 
            // frmThongKeSanBong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1012, 599);
            Controls.Add(chartSanBong);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "frmThongKeSanBong";
            Text = "frmThongKeSanBong";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgSanBong).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartSanBong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Panel panel11;
        private Label label5;
        private Panel panel12;
        private Panel panel4;
        private Panel panel10;
        private DateTimePicker dtpDenNgay;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private Panel panel9;
        private DataGridView dtgSanBong;
        private Panel panel8;
        private Panel panel6;
        private Panel panel7;
        private Label label3;
        private Button btnXemSanBong;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanBong;
    }
}