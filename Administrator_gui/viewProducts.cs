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
using System.Runtime.InteropServices;
namespace Pharmacy.Administrator_gui
{

    public partial class viewProducts : UserControl
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
        public viewProducts()
        {
            InitializeComponent();
        }
        string ConnectionString = DB_CONNECTION.con;
        //public string ConnectionString = "Data Source=DESKTOP-RRHEUSU\\MRMASUD;Initial Catalog=pharmacy;Integrated Security=True";
        public void load_medicine()
        {
            productTable.Rows.Clear();
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "select * from medicine";
            SqlCommand insertCmd = new SqlCommand(query, con);
            var reader = insertCmd.ExecuteReader();
            while (reader.Read())
            {
                var Id = reader["Id"];
                var Name = reader["Mname"];
                var Medicine_Type = reader["Mtype"];
                var Quantity = reader["Qty"];
                var Price = reader["Price"];
                var Manufacturer = reader["ManName"];
                var Expiry_date = reader["edate"];

                productTable.Rows.Add(Id, Name, Medicine_Type, Quantity, Price, Manufacturer, Expiry_date);
            }
            check();
            con.Close();
        }
        int Ecount=0;
        private void viewProducts_Load(object sender, EventArgs e)
        {
            searchBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, searchBtn.Width, searchBtn.Height, 20, 20));
            categoryPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, categoryPanel.Width, categoryPanel.Height,20,20));
            load_medicine();
            SqlConnection Con = new SqlConnection(ConnectionString);
            Con.Open();
            string Equery = "select count(Mname) from medicine where edate <= getDate()";
            SqlCommand Ecmd = new SqlCommand(Equery, Con);
            Ecount = (int)Ecmd.ExecuteScalar();
            expMedic.Text = Ecount.ToString() +" Medicines are expired";
            Con.Close();
        }

        public int medId = 0;
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (medId == 0)
            {
                MessageBox.Show("Please Select Row First");
            }
            else
            {
                SqlConnection delCon = new SqlConnection(ConnectionString);
                delCon.Open();
                SqlCommand delCmd = new SqlCommand("delete from medicine where Id=@id", delCon);
                delCmd.Parameters.AddWithValue("@id", medId);
                delCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully !!!!!!");
                load_medicine();
                
                medId = 0;
                delCon.Close();
            }
        }
        public void check()
        {
            for (int a = 0; a < productTable.RowCount - 1; a++)
            {
                string dates = productTable.Rows[a].Cells[6].Value.ToString();
                DateTime d = DateTime.Parse(dates);
                if (d < DateTime.Today)
                {
                    productTable.Rows[a].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void reloadBtn_Click(object sender, EventArgs e)
        {
            load_medicine();
            SqlConnection Con = new SqlConnection(ConnectionString);
            Con.Open();
            string Equery = "select count(Mname) from medicine where edate <= getDate()";
            SqlCommand Ecmd = new SqlCommand(Equery, Con);
            Ecount = (int)Ecmd.ExecuteScalar();
            expMedic.Text = Ecount.ToString() + " Medicines are expired";
            check();
            Con.Close();
        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string search_term = searchTerm.Text.Trim();
            if (search_term != "")
            {
                productTable.DataSource=null;
                SqlConnection Con = new SqlConnection(ConnectionString);
                Con.Open();
                SqlCommand cmd = new SqlCommand("select * from medicine where Mname like '%" + search_term + "%'", Con);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                productTable.DataSource = ds;
                check();
                Con.Close();
            }
            else
            {
                load_medicine();
            }
        }

        
    }
}
