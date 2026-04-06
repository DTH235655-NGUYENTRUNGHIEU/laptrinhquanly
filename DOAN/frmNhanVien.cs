using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            textBox2.Text = row.Cells[1].Value?.ToString(); // Tên NV
            textBox3.Text = row.Cells[2].Value?.ToString(); // Số điện thoại
            textBox4.Text = row.Cells[3].Value?.ToString(); // Địa chỉ
            textBox5.Text = row.Cells[4].Value?.ToString(); // Tài khoản
            textBox6.Text = row.Cells[5].Value?.ToString(); // Mật khẩu
            // Xử lý riêng cho ô Ngày Vào Làm (DateTimePicker)
            if (row.Cells[6].Value != DBNull.Value && row.Cells[6].Value != null)
            {
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[6].Value);
            }
            textBox1.Text = row.Cells[7].Value?.ToString(); 
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
      
