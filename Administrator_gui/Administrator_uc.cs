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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using Pharmacy.Administrator_gui;
using Pharmacy.Pharmacist_gui;

namespace Pharmacy.Administrator_gui
{
    public partial class Administrator_uc : UserControl
    {
        public static int n = modifyMedicine.updateCount;
        string ConnectionString = DB_CONNECTION.con;
        [DllImport("Gdi32.dll", EntryPoint ="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        //public string ConnectionString = "Data Source=DESKTOP-RRHEUSU\\MRMASUD;Initial Catalog=pharmacy;Integrated Security=True";
        int count = 0;
        int Ecount = 0;
        public Administrator_uc()
        {
            
            InitializeComponent();
            load_chart();
        }
       
        public void load_chart()
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "select count(Mname) from medicine where edate >= getDate()";
            SqlCommand cmd = new SqlCommand(query, con);
            count = (int)cmd.ExecuteScalar();
            this.medicChart.Series["Valid Medicine"].Points.AddXY("Medicine Validity Chart", count);

            string Equery = "select count(Mname) from medicine where edate <= getDate()";
            SqlCommand Ecmd = new SqlCommand(Equery, con);
            Ecount = (int)Ecmd.ExecuteScalar();
            this.medicChart.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chart", Ecount);
            con.Close();
        }
        int admin, pharmacist;
        private void Administrator_uc_Load(object sender, EventArgs e)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 30, 30));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 30, 30));
            summary();
            if (n > 0)
            {
                updateFlag.Text = " Medicine updated";
            }
            else
            {
                updateFlag.Text = "No updataion";
            }
        }
        private void summary()
        {
            SqlConnection Con = new SqlConnection(ConnectionString);
            Con.Open();
            string aquery = "select count(admin_name) from APTable where user_role='admin'";
            SqlCommand acmd = new SqlCommand(aquery, Con);
            admin = (int)acmd.ExecuteScalar();
            TotalAdmin.Text = admin.ToString();

            string pquery = "select count(admin_name) from APTable where user_role='pharmacist'";
            SqlCommand pcmd = new SqlCommand(pquery, Con);
            pharmacist = (int)pcmd.ExecuteScalar();
            TotalPharmacist.Text = pharmacist.ToString();

            string Equery = "select count(Mname) from medicine where edate <= getDate()";
            SqlCommand Ecmd = new SqlCommand(Equery, Con);
            Ecount = (int)Ecmd.ExecuteScalar();
            ExpMedic.Text = Ecount.ToString();
            Con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void reloadBtn_Click(object sender, EventArgs e)
        {
            summary();
            foreach (var series in medicChart.Series)
            {
                series.Points.Clear();
            }
            load_chart();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
