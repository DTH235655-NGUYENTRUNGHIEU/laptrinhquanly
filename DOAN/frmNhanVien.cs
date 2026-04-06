using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOAN
{
    // ---------------- PHẦN 1: CLASS FORM NHÂN VIÊN ----------------
    public partial class frmNhanVien : Form
    {
        private string? id;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Database db = new Database(@"(localdb)\MSSQLLocalDB", "QLSB");
            DataTable dt = db.laydl("SELECT MaNV AS id, TenNV AS [Tên Nhân Viên], SoDienThoai AS [Số Điện Thoại], DiaChi AS [Địa Chỉ], TaiKhoan AS [Tài Khoản], MatKhau AS [Mật Khẩu], NgayVaoLam AS [Ngày Vào Làm], VaiTro AS [Vai Trò] FROM NHAN_VIEN");
            dataGridView1.DataSource = dt;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtTen.Text = row.Cells[1].Value?.ToString(); // Tên NV
            txtSDT.Text = row.Cells[2].Value?.ToString(); // Số điện thoại
            txtDiaChi.Text = row.Cells[3].Value?.ToString(); // Địa chỉ
            txtTK.Text = row.Cells[4].Value?.ToString(); // Tài khoản
            txtMK.Text = row.Cells[5].Value?.ToString(); // Tài khoản
            // Xử lý riêng cho ô Ngày Vào Làm (DateTimePicker)
            if (row.Cells[6].Value != DBNull.Value && row.Cells[6].Value != null)
            {
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[6].Value);
            }
            txtVaiTro.Text = row.Cells[7].Value?.ToString();
            // Xử lý riêng cho ô Vai Trò (bây giờ là TextBox)
            string vaiTro = row.Cells[7].Value?.ToString();

            if (vaiTro == "1" || vaiTro == "True")
            {
                txtVaiTro.Text = "Quản lý"; // Đổi textBox7 thành tên TextBox thực tế của bạn
            }
            else if (vaiTro == "0" || vaiTro == "False")
            {
                txtVaiTro.Text = "Nhân viên";
            }
            else
            {
                txtVaiTro.Text = ""; // Xóa trắng nếu không có dữ liệu
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                // Kiểm tra nếu giá trị trong database là 1 (hoặc True nếu kiểu bit)
                if (e.Value.ToString() == "1" || e.Value.ToString() == "True")
                {
                    e.Value = "Quản lý";
                }
                // Các trường hợp còn lại (0 hoặc False)
                else if (e.Value.ToString() == "0" || e.Value.ToString() == "False")
                {
                    e.Value = "Nhân viên";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Database
    {
        public SqlConnection cn;
        SqlDataAdapter da;

        public Database(string server, string dbName)
        {
            string connectionString = $@"Data Source={server};Initial Catalog={dbName};Integrated Security=True";
            cn = new SqlConnection(connectionString);
        }

        public DataTable laydl(string sqlstr)
        {
            da = new SqlDataAdapter(sqlstr, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void thucthi(SqlCommand sqlcmd)
        {
            cn.Open();
            sqlcmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
      
