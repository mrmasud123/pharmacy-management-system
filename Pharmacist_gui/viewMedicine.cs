using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Pharmacy.Pharmacist_gui
{
    public partial class viewMedicine : UserControl
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
        public viewMedicine()
        {
            InitializeComponent();
        }
        public string ConnectionString = DB_CONNECTION.con;

        private void viewMedicine_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(ConnectionString);
            Con.Open();
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            //string query = "select * from billTable where BillName='"+Form1.name+"'";
            string query = "select * from billTable";
            SqlCommand cmd = new SqlCommand(query,Con);
            //SqlDataAdapter sd = new SqlDataAdapter(cmd);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            MedicineTable.DataSource = dt;
            Con.Close();
        }

    }
}
