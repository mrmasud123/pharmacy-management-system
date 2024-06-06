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

namespace Pharmacy
{
    public partial class pharmacist : Form
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
        public pharmacist()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pharmacistLogout_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pharmacist_Load(object sender, EventArgs e)
        {
            pharmacist_dashboard1.Visible = true;
            add_medicine2.Visible = false;
            viewMedicine1.Visible = false;
            modifyMedicine1.Visible = false;
            sellMedicine1.Visible=false;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pharmacistDashboard.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, pharmacistDashboard.Width, pharmacistDashboard.Height,20,20));
            addMedicine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addMedicine.Width, addMedicine.Height, 20, 20));
            viewmedicine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, viewmedicine.Width, viewmedicine.Height, 20, 20));
            modifyMedicine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, modifyMedicine.Width, modifyMedicine.Height, 20, 20));
            sellMedicine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sellMedicine.Width, sellMedicine.Height, 20, 20));
            pharmacistLogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pharmacistLogout.Width, pharmacistLogout.Height, 20, 20));
            loginName.Text ="Hello , " +Form1.name;
        }

        private void pharmacistDashboard_Click(object sender, EventArgs e)
        {
            pharmacist_dashboard1.Visible = true;
            pharmacist_dashboard1.BringToFront();
            add_medicine2.Visible = false;
            viewMedicine1.Visible = false;
            modifyMedicine1.Visible = false;
            sellMedicine1.Visible = false;
            pharmacistDashboard.BackColor = Color.Green;
            addMedicine.BackColor = Color.Red;
            viewmedicine.BackColor = Color.Red;
            modifyMedicine.BackColor = Color.Red;
            sellMedicine.BackColor = Color.Red;
            pharmacistLogout.BackColor = Color.Red;
        }

        private void modifyMedicine_Click(object sender, EventArgs e)
        {
            modifyMedicine1.Visible = true;
            modifyMedicine1.BringToFront();
            pharmacist_dashboard1.Visible = false;
            add_medicine2.Visible = false;
            viewMedicine1.Visible = false;
            sellMedicine1.Visible = false;
            pharmacistDashboard.BackColor = Color.Red;
            addMedicine.BackColor = Color.Red;
            viewmedicine.BackColor = Color.Red;
            modifyMedicine.BackColor = Color.Green;
            sellMedicine.BackColor = Color.Red;
            pharmacistLogout.BackColor = Color.Red;
        }

        private void sellMedicine_Click(object sender, EventArgs e)
        {
            sellMedicine1.Visible = true;
            sellMedicine1.BringToFront();
            viewMedicine1.Visible = false;
            pharmacist_dashboard1.Visible = false;
            add_medicine2.Visible = false;
            modifyMedicine1.Visible = false;
            pharmacistDashboard.BackColor = Color.Red;
            addMedicine.BackColor = Color.Red;
            viewmedicine.BackColor = Color.Red;
            modifyMedicine.BackColor = Color.Red;
            sellMedicine.BackColor = Color.Green;
            pharmacistLogout.BackColor = Color.Red;
        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            add_medicine2.Visible = true;
            add_medicine2.BringToFront();
            pharmacist_dashboard1.Visible = false;
            viewMedicine1.Visible = false;
            modifyMedicine1.Visible = false;
            sellMedicine1.Visible = false;
            pharmacistDashboard.BackColor = Color.Red;
            addMedicine.BackColor = Color.Green;
            viewmedicine.BackColor = Color.Red;
            modifyMedicine.BackColor = Color.Red;
            sellMedicine.BackColor = Color.Red;
            pharmacistLogout.BackColor = Color.Red;
        }

        private void viewmedicine_Click(object sender, EventArgs e)
        {
            viewMedicine1.Visible = true;
            viewMedicine1.BringToFront();
            pharmacist_dashboard1.Visible = false;
            add_medicine2.Visible = false;
            modifyMedicine1.Visible = false;
            sellMedicine1.Visible = false;
            pharmacistDashboard.BackColor = Color.Red;
            addMedicine.BackColor = Color.Red;
            viewmedicine.BackColor = Color.Green;
            modifyMedicine.BackColor = Color.Red;
            sellMedicine.BackColor = Color.Red;
            pharmacistLogout.BackColor = Color.Red;
        }

        private void pharmacistPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pharmacist_dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
