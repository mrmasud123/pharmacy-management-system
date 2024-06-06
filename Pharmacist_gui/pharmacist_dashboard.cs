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
using System.Threading;

namespace Pharmacy.Pharmacist_gui
{
    public partial class pharmacist_dashboard : UserControl
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
        public pharmacist_dashboard()
        {
            InitializeComponent();
            load_chart();
        }
        public string ConnectionString = DB_CONNECTION.con;
        int count=0;
        int Ecount = 0;
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
        }
        private void pharmacist_dashboard_Load(object sender, EventArgs e)
        {
            reloadBtn.Region =Region.FromHrgn(CreateRoundRectRgn(0, 0, reloadBtn.Width, reloadBtn.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
