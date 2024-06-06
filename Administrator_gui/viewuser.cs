using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy.Administrator_gui
{
    public partial class viewuser1 : UserControl
    {
        string ConnectionString = DB_CONNECTION.con;
        //string ConnectionString = "Data Source=DESKTOP-RRHEUSU\\MRMASUD;Initial Catalog=pharmacy;Integrated Security=True";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
              int nLeftRect,
              int nRightRect,
              int nTopRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
          );
        public viewuser1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int pharmacist_id = 0;
        private void pharmacistTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void showManufacturer()
        {
            pharmacistTable.Rows.Clear();
            SqlConnection con = new SqlConnection(ConnectionString);
            string query = "select * from manufacturer";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var Id = reader["manId"];
                var Name = reader["manName"];
                var Address = reader["manAdd"];
                var Email = reader["manEmail"];
                
                pharmacistTable.Rows.Add(Id, Name, Address, Email);
            }
            con.Close();
        }
        private void viewuser1_Load(object sender, EventArgs e)
         {
            //Font font = new Font("Arial",10);
            //Font HeaderFont = new Font("Arial", 11, FontStyle.Bold);
            //pharmacistTable.DefaultCellStyle.Font= font;
            //pharmacistTable.ColumnHeadersDefaultCellStyle.Font = HeaderFont;
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 20, 20));
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 20, 20));
            resetBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetBtn.Width, resetBtn.Height, 20, 20));
            deletebtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deletebtn.Width, deletebtn.Height, 20, 20));
            manufacturePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, manufacturePanel.Width, manufacturePanel.Height, 20, 20));
            showManufacturer();
                      
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string manNamete = manName.Text.Trim();
            string manAddte = manAdd.Text.Trim();
            string manEmailte = manEmail.Text.Trim();
            SqlConnection conn= new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmdToCheckEmail = new SqlCommand("select * from manufacturer where manEmail='"+manEmail.Text+"'",conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmdToCheckEmail);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (manNamete=="" || manAddte=="" || manEmailte=="")
            {
                MessageBox.Show("Fill up every fields");
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Email already exists! ");
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand("insert into manufacturer values('" + manNamete + "','" + manAddte + "','" + manEmailte + "')", conn);
                    insertCmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Inserted Sucessfully");
                    showManufacturer();
                    manName.Text = "";
                    manAdd.Text = "";
                    manEmail.Text = "";
                }
            }
            
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            manName.Text = "";
            manAdd.Text = "";
            manEmail.Text = "";
            MessageBox.Show("Form has been reset");
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (pharmacist_id==0) 
            {
                MessageBox.Show("Select row first");
            }
            else
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from manufacturer where manId=@pharmacist_id",con);
                cmd.Parameters.AddWithValue("@pharmacist_id",pharmacist_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manufactured Deleted");
                con.Close();
                showManufacturer();
                manName.Text = "";
                manAdd.Text = "";
                manEmail.Text = "";
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (manName.Text.Trim()!="" & manAdd.Text.Trim()!="" && manEmail.Text.Trim()!="")
            {
                MessageBox.Show("Id is : " + pharmacist_id);
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string query = "update manufacturer set manName='" + manName.Text.Trim() + "', manAdd='" + manAdd.Text.Trim() + "', manEmail='" + manEmail.Text.Trim() + "' where manId='" + pharmacist_id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                con.Close();
                showManufacturer();
            }
            else
            {
                MessageBox.Show("Fields can not be blank");
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            showManufacturer();
            manName.Text = "";
            manAdd.Text = "";
            manEmail.Text = "";

        }

        private void pharmacistTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            manName.Text = pharmacistTable.SelectedRows[0].Cells[1].Value.ToString();
            manAdd.Text = pharmacistTable.SelectedRows[0].Cells[2].Value.ToString();
            manEmail.Text = pharmacistTable.SelectedRows[0].Cells[3].Value.ToString();
            if (manName.Text == "")
            {
                pharmacist_id = 0;
            }
            else
            {
                pharmacist_id = int.Parse(pharmacistTable.SelectedRows[0].Cells[0].Value.ToString());
            }
            pharmacistTable.CurrentRow.Selected = true;
            pharmacist_id = Convert.ToInt32(pharmacistTable.SelectedRows[0].Cells[0].Value.ToString());
            manName.Text = pharmacistTable.SelectedRows[0].Cells[1].Value.ToString();
            manAdd.Text = pharmacistTable.SelectedRows[0].Cells[2].Value.ToString();
            manEmail.Text = pharmacistTable.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
    }
