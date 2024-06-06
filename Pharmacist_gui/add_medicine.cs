using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pharmacy.Pharmacist_gui
{
    public partial class add_medicine : UserControl
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
        public string ConnectionString = DB_CONNECTION.con;
        public add_medicine()
        {
            
            InitializeComponent();
            load_medicine();
            
        }


        private void add_medicine_Load(object sender, EventArgs e)
        {
            
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }

        public void check()
        {
            for (int a = 0; a < productTable.RowCount - 1; a++)
            {
                string dates = productTable.Rows[a].Cells["edate"].Value.ToString();
                DateTime d = DateTime.Parse(dates);
                if (d < DateTime.Today)
                {
                    productTable.Rows[a].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        public void load_medicine()
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "select * from medicine";
            SqlCommand insertCmd = new SqlCommand(query, con);
            SqlDataAdapter sd = new SqlDataAdapter(insertCmd);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            productTable.DataSource = ds;
            check();
            con.Close();
            
        }
        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string search_term = searchTerm.Text.Trim();
            if (search_term != "")
            {
                productTable.DataSource = null;
                SqlConnection Con = new SqlConnection(ConnectionString);
                Con.Open();
                SqlCommand cmd = new SqlCommand("select * from medicine where Mname like '%" + search_term + "%'", Con);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                productTable.DataSource = ds;
                Con.Close();
                check();
                
            }
            else
            {
                load_medicine(); 
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            load_medicine();
        }
    }
}
