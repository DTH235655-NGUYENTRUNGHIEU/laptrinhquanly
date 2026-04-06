using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
namespace DOAN
{
    public partial class frmSan : Form
    {
        Database db;
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id;
        public frmSan()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = !giaTri;
            btnHuy.Enabled = !giaTri;
            btnSua.Enabled = giaTri;
            btnXoa.Enabled = giaTri;
            btnXuat.Enabled = giaTri;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        class Database
        {
            public SqlConnection cn;
            SqlDataAdapter da;
            public Database(string srvname, string dbName)
            {
                string cnnstr = "Data source=" + srvname + "; Initial Catalog =" + dbName + "; Integrated Security = True";
                cn = new SqlConnection(cnnstr);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            // Ví dụ khi bạn gọi class Database trong Form
            db = new Database(@"(localdb)\MSSQLLocalDB", "QLSB");
            DataTable dt = db.laydl("SELECT MaSan AS ID, TenSan AS [Tên Sân], LoaiSan AS [Loại Sân], GiaThueGio AS [Giá thuê giờ], TrangThai AS [Trạng thái] FROM SAN_BONG");
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click trúng tiêu đề cột
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTen.Text = row.Cells[1].Value?.ToString();
                cboLoai.Text = row.Cells[2].Value?.ToString();
                txtGia.Text = row.Cells[3].Value?.ToString();
                cboTrangThai.Text = row.Cells[4].Value?.ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(false);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLyThem == false) // Đang ở chế độ Sửa
            {
                try
                {
                    // Tạo câu lệnh SQL Update dựa trên các ô TextBox của bạn
                    string sqlSua = "UPDATE SAN_BONG SET TenSan = N'" + txtTen.Text +
                                    "', LoaiSan = N'" + cboLoai.Text +
                                    "', GiaThueGio = " + txtGia.Text +
                                    ", TrangThai = N'" + cboTrangThai.Text +
                                    "' WHERE MaSan = " + id;

                    SqlCommand cmd = new SqlCommand(sqlSua, db.cn);
                    db.thucthi(cmd);

                    MessageBox.Show("Đã cập nhật thông tin sân thành công!", "Thông báo");

                    // Load lại lưới DataGridView để thấy dữ liệu mới
                    DataTable dt = db.laydl("SELECT MaSan AS ID, TenSan AS [Tên Sân], LoaiSan AS [Loại Sân], GiaThueGio AS [Giá thuê giờ], TrangThai AS [Trạng thái] FROM SAN_BONG");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                }
            }
            else
            {
                // Chỗ này sau này bạn viết code cho phần Thêm Mới nhé
            }

            // Lưu xong thì khóa các nút lại như cũ
            BatTatChucNang(true);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
    