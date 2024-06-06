using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace Pharmacy.Administrator_gui
{
    public partial class bill : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int nLeftRect,
               int nRightRect,
               int nTopRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
           );
        string ConnectionString = DB_CONNECTION.con;
        public bill()
        {
            InitializeComponent();
        }
        //string ConnectionString = "Data Source=DESKTOP-RRHEUSU\\MRMASUD;Initial Catalog=pharmacy;Integrated Security=True";
        private void bill_Load(object sender, EventArgs e)
        {
            
            SqlConnection Con = new SqlConnection(ConnectionString);
            Con.Open();
            
            string query = "select * from billTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            billTable.DataSource = dt;
            Con.Close();
        }
    }
}
