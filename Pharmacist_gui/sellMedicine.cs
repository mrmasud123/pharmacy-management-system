using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Pharmacy.Pharmacist_gui
{
    public partial class sellMedicine : UserControl
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
        public sellMedicine()
        {
            InitializeComponent();
            LoadMedic();
        }

        private void sellMedicine_Load(object sender, EventArgs e)
        {
            AddToBill.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AddToBill.Width, AddToBill.Height, 20, 20));
            //remove.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, remove.Width, remove.Height, 20, 20));
            //purchasePrint.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, purchasePrint.Width, purchasePrint.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }
        public SqlConnection Con=new SqlConnection(DB_CONNECTION.con);
        
        private void LoadMedic()
        {
            ShowMedicines.Rows.Clear();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Id,Mname,Qty,price from medicine where edate >= getDate() and Qty>0", Con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ShowMedicines.Rows.Add(reader["Id"], reader["Mname"], reader["Qty"], reader["price"]);
            }
            Con.Close();
        }

        int key=0, Stock;
        int n = 1, GridTotal=0,MedPrice,MedQty,MedTot, MedId,pos=60;
        private void medicine_text_TextChanged(object sender, EventArgs e)
        {
            
            string search_term = medicine_text.Text;
            if (search_term!="")
            {
                ShowMedicines.Rows.Clear();
                Con.Open();
                SqlCommand cmd = new SqlCommand("select Id,Mname,Qty,price from medicine where edate >= getDate() and Qty>0 and Mname like '%" + search_term + "%'", Con);
                var data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        ShowMedicines.Rows.Add(data["Id"], data["Mname"], data["Qty"], data["price"]);
                    }
                Con.Close();
            }
            else
            {
                ShowMedicines.Rows.Clear();
                LoadMedic();
            }
  
           
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            LoadMedic();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285,600);
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        string Medname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MR Pharmacy" , new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID MEDICINE PRICE QUANTITY TOTAL" , new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26,40));
            foreach (DataGridViewRow row in billTable.Rows)
            {
                MedId = Convert.ToInt32(row.Cells["Column1"].Value);
                Medname = "" + row.Cells["Column2"].Value;
                MedPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                MedQty = Convert.ToInt32(row.Cells["Column4"].Value);
                MedTot = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString(""+MedId, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(26,pos));
                e.Graphics.DrawString(""+Medname, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(45,pos));
                e.Graphics.DrawString(""+MedPrice, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(120,pos));
                e.Graphics.DrawString(""+MedQty, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(170,pos));
                e.Graphics.DrawString(""+MedTot, new Font("Century Gothic", 8, FontStyle.Bold),Brushes.Blue, new Point(235,pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: Tk "+GridTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(50, pos+50));
            e.Graphics.DrawString("***************  MR Pharmacy  ***************"+GridTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(10, pos+85));
            billTable.Rows.Clear();
            billTable.Refresh();
            pos = 100;
            GridTotal = 0;
            n = 0;
            TotalBill.Text = "";
            MedName.Text = "";
            MedicPerPrice.Text = "";
        }

        private void AddToBill_Click(object sender, EventArgs e)
        {
            if (medQty.Text=="" || Convert.ToInt32(medQty.Text)>Stock)
            {
                MessageBox.Show("Enter Correct Quantity !!");
            }
            else
            {
                int total = Convert.ToInt32(medQty.Text) * Convert.ToInt32(MedicPerPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(billTable);
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = MedName.Text;
                newRow.Cells[2].Value = medQty.Text;
                newRow.Cells[3].Value = MedicPerPrice.Text;
                newRow.Cells[4].Value = total;
                billTable.Rows.Add(newRow);
                GridTotal = GridTotal + total;
                n = n + 1;
                TotalBill.Text = "Tk . " + GridTotal;
                ShowMedicines.Rows.Clear();
                updateQty();
                InsertBill();
                medQty.Text = "";
                MedName.Text = "";
                MedicPerPrice.Text = "" ;
            }
        }

        private void ShowMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedName.Text = ShowMedicines.SelectedRows[0].Cells[1].Value.ToString();
            Stock = Convert.ToInt32(ShowMedicines.SelectedRows[0].Cells[2].Value.ToString());
            MedicPerPrice.Text = ShowMedicines.SelectedRows[0].Cells[3].Value.ToString();
            MessageBox.Show("Quantity is : "+ Stock);
            if (MedName.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ShowMedicines.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void updateQty()
        {
           
            int newQty = Convert.ToInt32(Stock) - Convert.ToInt32(medQty.Text.Trim());
            Con.Open();
            SqlCommand cmd = new SqlCommand("update medicine set Qty='" + newQty + "' where Id='" + key + "'",Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            LoadMedic();
        }
        private void InsertBill()
        {
            Con.Open();
            string query = "insert into billTable values('" + MedName.Text + "','" + MedicPerPrice.Text + "','" + medQty.Text + "','" + GridTotal + "','" + Form1.name + "')";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bill inserted");
            Con.Close();

        }
    }
}
