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
    public partial class addMedicine : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public addMedicine()
        {
            InitializeComponent();
            GetManufacturer();
            load_medicine();
        }
        
        private void profile_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            addBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addBtn.Width, addBtn.Height, 20, 20));
            resetBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetBtn.Width, resetBtn.Height, 20, 20));
            deleteBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deleteBtn.Width, deleteBtn.Height, 20, 20));
            UpdateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UpdateBtn.Width, UpdateBtn.Height, 20, 20));
        }
        string ConnectionString = DB_CONNECTION.con;
        //public string ConnectionString = "Data Source=DESKTOP-RRHEUSU\\MRMASUD;Initial Catalog=pharmacy;Integrated Security=True";
        private void GetManufacturer()
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand manCmd = new SqlCommand("select manName from manufacturer", con);
            SqlDataReader Rdr = manCmd.ExecuteReader();
            while (Rdr.Read())
            {
                manufacturerId.Items.Add(Rdr["manName"].ToString());
            }
        }
        public void load_medicine()
        {
            medicineTable.Rows.Clear();
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "select * from medicine";
            SqlCommand cmd = new SqlCommand(query,con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var Id = reader["Id"];
                var Name = reader["Mname"];
                var Medicine_Type = reader["Mtype"];
                var Quantity = reader["Qty"];
                var Price = reader["Price"];
                var Manufacturer = reader["ManName"];
                var Expiry_date = reader["edate"];

                medicineTable.Rows.Add(Id, Name, Medicine_Type,Quantity,Price,Manufacturer,Expiry_date);
            }
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (medId==0)
            {
               
                object manufacturerIdte = manufacturerId.SelectedItem;
                string medicinePricete = medicinePrice.Text;
                string medicineQtyte = medicineQty.Text;
                string medicineTypete = medicineType.Text;
                string medicineNamete = medicineName.Text;
                string edatete = edate.Text;
                if (edatete == "" || manufacturerIdte == null || medicinePricete == "" || medicineQtyte == "" || medicineTypete == "" || medicineNamete == "")
                {
                    MessageBox.Show("Please Fill up Every Fields");
                }
                else if(Convert.ToInt32(medicinePricete) <=0 || Convert.ToInt32(medicineQtyte) <=0){
                    MessageBox.Show("Invalid Price or Quantity");
                }
                else
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    string Query = "insert into medicine values ('" + medicineNamete + "' , '" + medicineTypete + "' , '" + medicineQtyte + "' , '" + medicinePricete + "' , '" + manufacturerIdte + "' , '" + edatete + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Inserted");
                    load_medicine();
                    resetForm();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("This Data already exists !!");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            //manufacturerId.SelectedIndex = 0;
            medicinePrice.Text = "";
            medicineQty.Text = "";
            medicineType.Text = "";
            medicineName.Text = "";
            medId = 0;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (medId==0)
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
                resetForm();
                medId = 0;
                delCon.Close();
            }
        }
        public int medId = 0;

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Id : "+ medId);
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            if (medicineName.Text!="" & medicineType.Text!="" & medicineQty.Text!="" & medicinePrice.Text!="" & manufacturerId.Text!="" & edate.Text!="")
            {
                string query = "update medicine set Mname='" + medicineName.Text + "', Mtype='" + medicineType.Text + "',Qty='" + medicineQty.Text + "', price='" + medicinePrice.Text + "', manName='" + manufacturerId.Text + "', edate='" + edate.Text + "' where Id='" + medId + "'";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                load_medicine();
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
            manufacturerId.Items.Clear();
            GetManufacturer();
            load_medicine();
            resetForm();
            
            medId = 0;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medicineName.Text = medicineTable.SelectedRows[0].Cells[1].Value.ToString();
            medicineType.Text = medicineTable.SelectedRows[0].Cells[2].Value.ToString();
            medicineQty.Text = medicineTable.SelectedRows[0].Cells[3].Value.ToString();
            medicinePrice.Text = medicineTable.SelectedRows[0].Cells[4].Value.ToString();
            manufacturerId.Text = medicineTable.SelectedRows[0].Cells[5].Value.ToString();

            edate.Text = medicineTable.SelectedRows[0].Cells[6].Value.ToString();
            if (medicineName.Text == "")
            {
                medId = 0;
            }
            else
            {
                medId = int.Parse(medicineTable.SelectedRows[0].Cells[0].Value.ToString());
            }
            medicineTable.CurrentRow.Selected = true;
            // medId = Convert.ToInt32(medicineTable.Rows[e.RowIndex].Cells["Id"].Value.ToString());
        }
    }
}
