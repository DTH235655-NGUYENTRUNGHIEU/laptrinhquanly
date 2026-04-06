using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace DOAN
{
    internal class DatabaseConnection
    {
        private static string connectionString = @"Server=ADMIN\SQLEXPRESS; Database=QLSB; Integrated Security=True; TrustServerCertificate=True;";

        // Phương thức lấy chuỗi kết nối
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Phương thức dùng để test thử kết nối xem có thành công không
        public static void TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open(); // Thử mở kết nối
                    MessageBox.Show("Kết nối tới CSDL QLSB thành công tuyệt đối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
