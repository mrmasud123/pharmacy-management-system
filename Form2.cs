
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            administrator_uc1.Visible = true;
            adduser1.Visible = false;
            viewuser11.Visible = false;
            profile1.Visible = false;
            viewProducts1.Visible = false;
            bill1.Visible = false;
            //this.FromBorderStyle = FromBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,20,20));
            dashboardBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,dashboardBtn.Width,dashboardBtn.Height,20,20));
            adduserBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, adduserBtn.Width, adduserBtn.Height, 20, 20));
            viewuser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, viewuser.Width, viewuser.Height, 20, 20));
            profileBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profileBtn.Width, profileBtn.Height, 20, 20));
            viewProducts.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, viewProducts.Width, viewProducts.Height, 20, 20));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            billBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            loginName.Text = "Hello, " + Form1.name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            adduser1.Visible = false;
            administrator_uc1.Visible = true;
            administrator_uc1.BringToFront();
            dashboardBtn.BackColor = Color.Green;
            adduserBtn.BackColor = Color.Red;
            viewuser.BackColor = Color.Red;
            billBtn.BackColor = Color.Red;
            profileBtn.BackColor = Color.Red;
            viewProducts.BackColor = Color.Red;
        }

        private void adduserBtn_Click(object sender, EventArgs e)
        {
            administrator_uc1.Visible = false;
            adduser1.Visible = true;
            adduser1.BringToFront();
            dashboardBtn.BackColor = Color.Red;
            adduserBtn.BackColor = Color.Green;
            viewuser.BackColor = Color.Red;
            profileBtn.BackColor = Color.Red;
            viewProducts.BackColor = Color.Red;
            billBtn.BackColor = Color.Red;
        }

        private void viewuser_Click(object sender, EventArgs e)
        {
            administrator_uc1.Visible = false;
            adduser1.Visible = false;
            viewuser11.Visible = true;
            viewuser11.BringToFront();
            dashboardBtn.BackColor = Color.Red;
            adduserBtn.BackColor = Color.Red;
            viewuser.BackColor = Color.Green;
            profileBtn.BackColor = Color.Red;
            viewProducts.BackColor = Color.Red;
            billBtn.BackColor = Color.Red;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            administrator_uc1.Visible = false;
            adduser1.Visible = false;
            viewuser11.Visible = false;
            profile1.Visible=true;
            profile1.BringToFront();
            dashboardBtn.BackColor = Color.Red;
            adduserBtn.BackColor = Color.Red;
            viewuser.BackColor = Color.Red;
            profileBtn.BackColor = Color.Green;
            billBtn.BackColor = Color.Red;
            viewProducts.BackColor = Color.Red;
        }

        private void viewProducts_Click(object sender, EventArgs e)
        {
            viewProducts1.Visible = true;
            viewProducts1.BringToFront();
            dashboardBtn.BackColor = Color.Red;
            adduserBtn.BackColor = Color.Red;
            viewuser.BackColor = Color.Red;
            profileBtn.BackColor = Color.Red;
            billBtn.BackColor = Color.Red;
            viewProducts.BackColor = Color.Green;
        }
        private void billBtn_Click(object sender, EventArgs e)
        {
            bill1.Visible = true;
            bill1.BringToFront();
            dashboardBtn.BackColor = Color.Red;
            adduserBtn.BackColor = Color.Red;
            viewuser.BackColor = Color.Red;
            profileBtn.BackColor = Color.Red;
            viewProducts.BackColor = Color.Red;
            billBtn.BackColor = Color.Green;
        }

    }
}