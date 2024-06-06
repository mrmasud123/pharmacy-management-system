using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Pharmacy
{
    public partial class Form1 : Form
    {
        string ConnectionString = DB_CONNECTION.con;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                 int nLeftRect,
                 int nRightRect,
                 int nTopRect,
                 int nBottomRect,
                 int nWidthEllipse,
                 int nHeightEllipse
             );
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showPass.Checked;
            switch (check)
            {
                case true :
                    passwordte.UseSystemPasswordChar = false;
                    break;
                default:
                    passwordte.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
           
            emailte.Text= "";
            passwordte.Text= "";
            MessageBox.Show("Form has been reset"); 
        }
        public static string name;
        public static string pname;
        public static string userRole;
        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            
            string EmailText = emailte.Text;
            string passwordText = passwordte.Text;
            if (EmailText != " " && passwordText != " ")
            {
                //string ConnectionString = "Data Source=DESKTOP-RRHEUSU\\MRMASUD;Initial Catalog=pharmacy;Integrated Security=True";


                SqlConnection con = new SqlConnection(ConnectionString);
                string query = "select * from APTable where admin_email=@email and admin_password=@pass";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@email", emailte.Text);
                cmd.Parameters.AddWithValue("@pass", passwordte.Text);
                SqlDataReader data = cmd.ExecuteReader();
                
                if (data.HasRows == true)
                {
                    //MessageBox.Show(data.GetString(1) +" : "+ data.GetString(5));
                    while (data.Read())
                    {
                        name = data.GetString(1);
                        userRole = data.GetString(5);
                    }
                    if (userRole=="pharmacist")
                    {
                        Form pharma = new pharmacist();
                        pharma.Show();
                        this.Hide();
                    }
                    else if(userRole=="admin")
                    {
                        Form f2 = new Form2();
                        f2.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Neither an Admin or Pharmacist");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
               
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            loginBtn.Region=Region.FromHrgn(CreateRoundRectRgn(0,0,loginBtn.Width,loginBtn.Height,20,20));
            resetBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetBtn.Width, resetBtn.Height, 20, 20));
        }

      
    }
}
