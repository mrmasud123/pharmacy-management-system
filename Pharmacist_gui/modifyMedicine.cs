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
    public partial class modifyMedicine : UserControl
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
        public modifyMedicine()
        {
            InitializeComponent();
            ResetForm();
        }

        private void modifyMedicine_Load(object sender, EventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }
        int medId;
       
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (medicId.Text=="")
            {
                MessageBox.Show("Please Enter Medicine Id");
            }
            else
            {
                medId = Convert.ToInt32(medicId.Text);
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from medicine where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", medId);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                sd.Fill(data);
                if (data.Tables[0].Rows.Count > 0)
                {

                    medicName.Text = data.Tables[0].Rows[0][1].ToString();
                    //medicMan.Items.Add(data.Tables[0].Rows[0][5].ToString());
                    string dateString = data.Tables[0].Rows[0][6].ToString();
                    DateTime date = DateTime.Parse(dateString);
                    medate.Value = date;
                    qty.Text = data.Tables[0].Rows[0][3].ToString();
                    PerPrice.Text = data.Tables[0].Rows[0][4].ToString();
                    GetManufacturer();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Medicine Found");
                    ResetForm();
                }
            }
        }
            private void GetManufacturer()
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand manCmd = new SqlCommand("select manName from manufacturer", con);
                SqlDataReader Rdr;
                Rdr = manCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("manName", typeof(string));
                dt.Load(Rdr);
                medicMan.ValueMember = "manName";
                medicMan.DataSource = dt;
            con.Close();
            }
        string uName, uMan, uDate, uQty, uPrice;

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            medicName.Text = "";
            medicMan.Text = "";
            medate.Text = "";
            qty.Text = "";
            PerPrice.Text = "";
            medicId.Text = "";
        }
        public static int updateCount = 0;
        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            uName = medicName.Text.Trim();
            uMan = medicMan.Text;
            uDate = medate.Text;
            uQty = qty.Text.Trim();
            uPrice = PerPrice.Text.Trim();
            if (uName=="" ||Convert.ToInt32(uQty)<=0 || Convert.ToInt32(uPrice)<=0)
            {
                MessageBox.Show("Invalid Quantity or price or empty name.");

            }
            else
            {
                string uQuery = "update medicine set Mname='" + uName + "', Qty='" + uQty + "', price='" + uPrice + "', manName='" + uMan + "', edate='" + uDate + "' where Id='" + medicId.Text + "'";
                SqlCommand cmd = new SqlCommand(uQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                ResetForm();
            }
            
        }
    }
}
