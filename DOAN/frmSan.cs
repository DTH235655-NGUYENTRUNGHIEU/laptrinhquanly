using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace DOAN
{
    public partial class frmSan : Form
    {

        public frmSan()
        {
            InitializeComponent();
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
            // Ví dụ khi bạn gọi class Database trong Form
            Database db = new Database(@"(localdb)\MSSQLLocalDB", "QLSB");
            DataTable dt = db.laydl("Select * FROM SAN_BONG");
            dataGridView1.DataSource = dt;
        }
    }
}
