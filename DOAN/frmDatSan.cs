using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DOAN.DatabaseConnection;

namespace DOAN
{
    public partial class frmDatSan : Form
    {
        public frmDatSan()
        {
            InitializeComponent();
        }

        //DatabaseConnection pro = new DatabaseConnection();

        private void frmDatSan_Load(object sender, EventArgs e)
        {
            cboThoiGian.Items.Clear();
            cboThoiGian.Items.Add("08:00 - 09:00");
            cboThoiGian.Items.Add("09:00 - 10:00");
            cboThoiGian.Items.Add("10:00 - 11:00");
            cboThoiGian.Items.Add("11:00 - 12:00");
            cboThoiGian.Items.Add("12:00 - 13:00");
            cboThoiGian.Items.Add("13:00 - 14:00");
            cboThoiGian.Items.Add("14:00 - 15:00");
            cboThoiGian.Items.Add("15:00 - 16:00");
            cboThoiGian.Items.Add("16:00 - 17:00");
            cboThoiGian.Items.Add("17:00 - 18:00");
            cboThoiGian.Items.Add("18:00 - 19:00");
            cboThoiGian.Items.Add("19:00 - 20:00");
            cboThoiGian.Items.Add("20:00 - 21:00");

            // Mặc định chọn khung đầu tiên
            cboThoiGian.SelectedIndex = 0;
            LoadTrangThaiSan();
        }
        private void LoadTrangThaiSan(string tenSanLoc = "")
        {
            // Giao diện có 5 sân: lblSanA, lblSanB, lblSanC, lblSanD, lblSanE
            Label[] labels = { lblSanA, lblSanB, lblSanC, lblSanD, lblSanE };
            var mapSan = new Dictionary<string, Label>{
                                                         { "Sân A", lblSanA }, { "Sân B", lblSanB },
                                                         { "Sân C", lblSanC }, { "Sân D", lblSanD }, { "Sân E", lblSanE }
                                                        };


            foreach (var kvp in mapSan)
            {
                Label lbl = kvp.Value;
                string tenSanTrongList = kvp.Key;

                lbl.Text = "";
                lbl.BackColor = Color.LightGray;
                lbl.TextAlign = ContentAlignment.TopLeft; //căn trái
                lbl.Padding = new Padding(5, 10, 0, 0); // cách lề

                lbl.Tag = null;

                // Logic ẩn hiện khi tìm kiếm
                if (string.IsNullOrEmpty(tenSanLoc))
                {
                    lbl.Visible = true;
                }
                else
                {
                    lbl.Visible = (tenSanTrongList == tenSanLoc);
                }
            }

            // Xử lý lọc giờ
            string gioTu = "";
            string gioDen = "";
            bool coLocGio = false;

            if (!string.IsNullOrEmpty(cboThoiGian.Text) && cboThoiGian.Text.Contains("-"))
            {
                string[] parts = cboThoiGian.Text.Split('-');
                if (parts.Length == 2)
                {
                    gioTu = parts[0].Trim();
                    gioDen = parts[1].Trim();

                    coLocGio = true;
                }
            }


            // SQL
            string ngayChon = dtpChonNgay.Value.ToString("yyyy-MM-dd");
            string hienThiNgay = dtpChonNgay.Value.ToString("dd/MM/yyyy");

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Đã sửa lại đúng tên bảng (SAN_BONG, KHACH_HANG) và tên cột (ThoiGianBatDau, TrangThaiDat...)
                    // Đã sửa lại thứ tự nối chuỗi SQL
                    string sql = @"SELECT s.TenSan, s.LoaiSan, 
                      d.MaDatSan AS MaDat, 
                      kh.TenKH AS TenKhach, 
                      kh.SoDienThoai, 
                      d.TrangThaiDat AS TrangThai, 
                      d.ThoiGianBatDau, 
                      d.ThoiGianKetThuc
               FROM SAN_BONG s
               LEFT JOIN DAT_SAN d ON s.MaSan = d.MaSan 
                    AND CAST(d.ThoiGianBatDau AS DATE) = @NgayDat 
                    AND d.TrangThaiDat IN (N'Đã đặt', N'Đang sử dụng', N'Hoàn thành')";

                    if (coLocGio)
                    {
                        // ĐƯA ĐIỀU KIỆN LỌC GIỜ VÀO 'ON' CỦA LEFT JOIN ĐỂ KHÔNG BỊ MẤT SÂN TRỐNG
                        sql += " AND (CAST(d.ThoiGianBatDau AS TIME) < @DenGio AND CAST(d.ThoiGianKetThuc AS TIME) > @TuGio) ";
                    }

                    // Bắt đầu nối tiếp LEFT JOIN thứ 2 và WHERE
                    sql += " LEFT JOIN KHACH_HANG kh ON d.MaKH = kh.MaKH WHERE 1=1 ";

                    if (!string.IsNullOrEmpty(tenSanLoc))
                    {
                        sql += " AND s.TenSan = @TenSanLoc ";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@NgayDat", ngayChon);

                    if (coLocGio)
                    {
                        cmd.Parameters.AddWithValue("@TuGio", gioTu);
                        cmd.Parameters.AddWithValue("@DenGio", gioDen);
                    }

                    if (!string.IsNullOrEmpty(tenSanLoc))
                    {
                        cmd.Parameters.AddWithValue("@TenSanLoc", tenSanLoc);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string tenSan = reader["TenSan"].ToString();
                        string loaiSan = reader["LoaiSan"].ToString();

                        if (!mapSan.ContainsKey(tenSan)) continue;
                        Label lbl = mapSan[tenSan];

                        // Dữ liệu mặc định
                        string maDat = "---";
                        string tenKhach = "---";
                        string sdt = "---";
                        string trangThai = "Trống";
                        string hienThiGio = "---";

                        // Kiểm tra xem sân có người đặt không (MaDat sẽ khác Null)
                        if (!reader.IsDBNull(reader.GetOrdinal("MaDat")))
                        {
                            maDat = reader["MaDat"].ToString();
                            tenKhach = reader["TenKhach"].ToString();
                            sdt = reader["SoDienThoai"].ToString();
                            trangThai = reader["TrangThai"].ToString();

                            // CSDL lưu là DATETIME, ta lấy ra và tách lấy phần Giờ (TimeOfDay)
                            DateTime dtDa = (DateTime)reader["ThoiGianBatDau"];
                            DateTime dtKet = (DateTime)reader["ThoiGianKetThuc"];
                            hienThiGio = $"{dtDa.ToString("HH:mm")} - {dtKet.ToString("HH:mm")}";

                            if (trangThai == "Đang sử dụng")
                            {
                                lbl.BackColor = Color.LightGreen;
                            }
                            else if (trangThai == "Đã đặt")
                            {
                                lbl.BackColor = Color.Gold;
                            }
                            else if (trangThai == "Hoàn thành")
                            {
                                lbl.BackColor = Color.DeepSkyBlue;
                            }
                            else
                            {
                                lbl.BackColor = Color.LightGray;
                            }
                            lbl.Tag = $"{maDat}|{tenSan}|{trangThai}";
                        }
                        else
                        {
                            lbl.BackColor = Color.LightGray;
                            lbl.Tag = $"|{tenSan}|Trống";
                        }

                        // Chỉnh sửa nội dung Label
                        string dong1 = CanGiuaTuDong($"   {tenSan.ToUpper()}", lbl);
                        string dong2 = CanGiuaTuDong($"   ({loaiSan})", lbl);
                        string line = CanGiuaTuDong("_________________", lbl);
                        string body = $"Mã đặt: {maDat}\n" +
                                      $"Ngày: {hienThiNgay}\n" +
                                      $"Giờ: {hienThiGio}\n" +
                                      $"Tên: {tenKhach}\n" +
                                      $"SĐT: {sdt}\n" +
                                      $"Trạng thái: {trangThai}";

                        lbl.Text = "\n\n\n\n" + dong1 + "\n" + dong2 + "\n" + line + "\n\n" + body;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi CSDL: " + ex.Message);
                }
            }
        }

        private string CanGiuaTuDong(string text, Label lbl)
        {
            if (string.IsNullOrEmpty(text) || lbl == null) return "";

            // Đo độ rộng của chữ gốc
            int doRongChu = TextRenderer.MeasureText(text, lbl.Font).Width;

            // Tính khoảng trống cần thiết ở bên trái để chữ ra giữa
            // Công thức: (Chiều rộng khung - Chiều rộng chữ) / 2
            int doRongKhung = lbl.Width - lbl.Padding.Left - lbl.Padding.Right;
            int khoangTrongBenTrai = (doRongKhung - doRongChu) / 2;

            if (khoangTrongBenTrai <= 0) return text; // Chữ dài quá thì khỏi căn

            string dauCach = "";
            int doRongHienTai = 0;

            // Cứ thêm dấu cách vào cho đến khi nào độ rộng của đám dấu cách gần bằng khoảng trống bên trái
            while (doRongHienTai < khoangTrongBenTrai)
            {
                dauCach += " ";
                doRongHienTai = TextRenderer.MeasureText(dauCach, lbl.Font).Width;
            }

            // Trả về: Đám dấu cách + Chữ gốc
            return dauCach + text;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadTrangThaiSan();
        }
    }
}
