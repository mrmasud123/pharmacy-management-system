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

namespace Pharmacy.Administrator_gui
{
    public partial class adduser : UserControl
    {
        string ConnectionString = DB_CONNECTION.con;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public adduser()
        {
            InitializeComponent();
        }

        
        private void showAll()
        {
            pharmaTable.Rows.Clear();
            SqlConnection showCon = new SqlConnection(ConnectionString);
            string showQuery = "SELECT * FROM APTable";
            showCon.Open();
            SqlCommand cmd = new SqlCommand(showQuery,showCon);
            var reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                var Id = reader["admin_id"];
                var Name = reader["admin_name"];
                var Email = reader["admin_email"];
                var Password = reader["admin_password"];
                var Address = reader["admin_address"];
                var Role = reader["user_role"];
                pharmaTable.Rows.Add(Id, Name, Email, Password, Address, Role);
            }
            showCon.Close();
        }
        private void resetForm()
        {
            UserPass.Text = "";
            Useremail.Text = "";
            userMobile.Text = "";
            username.Text = "";
            userrole.Text = "";
            id = 0;
        }

        private void reset_Click(object sender, EventArgs e)  
        {
            resetForm();
        }
        private void signup_Click(object sender, EventArgs e)
        {
            if (id==0)
            {
                string UserPasste = UserPass.Text.Trim();
                string Useremailte = Useremail.Text.Trim() ;
                string userMobilete = userMobile.Text.Trim();
                string usernamete = username.Text.Trim();
                string userrolete = userrole.Text.Trim();
                if (UserPasste == "" || Useremailte == "" || userMobilete == "" || usernamete == "" || userrolete == "")
                {
                    MessageBox.Show("Please Fill up the form");
                }
                else
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    string emailQuery = "select * from APTable where admin_email='" + Useremailte + "'";
                    SqlCommand emailCheck = new SqlCommand(emailQuery, con);
                    SqlDataAdapter sd = new SqlDataAdapter(emailCheck);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Email already exists!!!!");
                    }
                    else
                    {
                        string query = "INSERT INTO APTable values('" + usernamete + "' , '" + Useremailte + "' , '" + UserPasste + "' , '" + userMobilete + "' , '" + userrolete + "')";
                        SqlCommand insertCmd = new SqlCommand(query, con);
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Sucessfully");
                        resetForm();
                        showAll();
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("This Data exist");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (id==0)
            {
                MessageBox.Show("Select row first");
            }
            else
            {
                SqlConnection scon = new SqlConnection(ConnectionString);
                string delQuery = "DELETE from APTable where admin_id=@ad_id";
                scon.Open();
                SqlCommand delCmd = new SqlCommand(delQuery, scon);
                delCmd.Parameters.AddWithValue("@ad_id", id);
                delCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully !!!!!");
                showAll();
                scon.Close();
                resetForm();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (UserPass.UseSystemPasswordChar == true)
            {
                UserPass.UseSystemPasswordChar = false;
            }
            else if (UserPass.UseSystemPasswordChar == false)
            {
                UserPass.UseSystemPasswordChar = true;
            }
           
        }

        private void adduser_Load(object sender, EventArgs e)
        {
            pharmacistPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pharmacistPanel.Width, pharmacistPanel.Height, 30, 30));
            signup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signup.Width, signup.Height, 20, 20));
            reset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, reset.Width, reset.Height, 20, 20));
            deleteBtn.Region= Region.FromHrgn(CreateRoundRectRgn(0,0,deleteBtn.Width, deleteBtn.Height, 20,20));
            UpdateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 20, 20));
            showAll();
        }
        int id = 0;
        private void pharmaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            if (userrole.Text != "" & username.Text != "" & userMobile.Text != "" & Useremail.Text != "" & UserPass.Text != "")
            {
                string query = "update APTable set admin_name='" + username.Text + "', admin_email='" + Useremail.Text + "',admin_password='" + UserPass.Text + "', admin_address='" + userMobile.Text + "', user_role='" + userrole.Text + "' where admin_id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                showAll();
                resetForm();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill up every Feilds");
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            showAll();
            resetForm();
        }

        private void pharmaTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            userrole.Text = pharmaTable.SelectedRows[0].Cells[5].Value.ToString();
            username.Text = pharmaTable.SelectedRows[0].Cells[1].Value.ToString();
            userMobile.Text = pharmaTable.SelectedRows[0].Cells[4].Value.ToString();
            Useremail.Text = pharmaTable.SelectedRows[0].Cells[2].Value.ToString();
            UserPass.Text = pharmaTable.SelectedRows[0].Cells[3].Value.ToString();

            if (username.Text == "")
            {
                id = 0;
            }
            else
            {
                id = int.Parse(pharmaTable.SelectedRows[0].Cells[0].Value.ToString());
            }
            pharmaTable.CurrentRow.Selected = true;
        }
    }
}
