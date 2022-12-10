using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Final_exam_ver2
{
    public partial class Form1 : Form
    {
        public List<ComboBoxItem> item = new List<ComboBoxItem>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            search.Enabled = false;
            btnAdd_Receipt_ID.Enabled = false;
            btnCancel.Enabled = false;
            btnRemove.Enabled = false;
            txtItemID.Select();
            
            addItemToComboBox();
        }

        private void btnAdd_Item_Click(object sender, EventArgs e)
        {
            if(txtItemID.Text == "")
            {
                MessageBox.Show("Please enter your ID's Item");
            }
            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Please enter your Name's Item");
            }
            else if (txtPriceItem.Text == "")
            {
                MessageBox.Show("Please enter your Price's Item");
            }
            else if (txtQuantityItem.Text == "")
            {
                MessageBox.Show("Please enter your Quantity's Item");
            }
            else if (txtBenefit.Text == "")
            {
                MessageBox.Show("Please enter your Benefit's Item");
            }
            else
            {
                
                gridViewItem.Rows.Add(txtItemID.Text, txtItemName.Text, txtQuantityItem.Text, txtPriceItem.Text, txtBenefit.Text);
               
            }
            
        }
        private void gridViewItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(gridViewItem.Rows.Count > 1)
            {
                search.Enabled = true;
                btnAdd_Receipt_ID.Enabled = true;
                btnCancel.Enabled = true;
                btnRemove.Enabled = true;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gridViewItem.SelectedRows)
            {
                gridViewItem.Rows.RemoveAt(item.Index);
            }

        }

        private void btnAdd_Receipt_ID_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to add invoice ID", "Add Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                int totalQuantityItem = 0;
                double totalPrice = 0;
                Connection create_ReceiptID = new Connection();
                create_ReceiptID.CreateConnection();
                SqlConnection connect = Connection.connection;

                SqlCommand executeCommand = connect.CreateCommand();
                executeCommand.CommandText = "Execute procItems @itemsID, @itemsName, @itemsPrice, @itemsQuantity, @benefit";
                for (int i = 0; i < gridViewItem.Rows.Count - 1; i++)
                {
                    totalQuantityItem += Convert.ToInt32(gridViewItem.Rows[i].Cells[2].Value);
                    totalPrice += Convert.ToDouble(gridViewItem.Rows[i].Cells[3].Value) * Convert.ToInt32(gridViewItem.Rows[i].Cells[2].Value);
                    executeCommand.Parameters.AddWithValue("@itemsID", gridViewItem.Rows[i].Cells[0].Value.ToString());
                    executeCommand.Parameters.AddWithValue("@itemsName", gridViewItem.Rows[i].Cells[1].Value.ToString());
                    executeCommand.Parameters.AddWithValue("@itemsPrice", Convert.ToInt32(gridViewItem.Rows[i].Cells[3].Value));
                    executeCommand.Parameters.AddWithValue("@itemsQuantity", Convert.ToDouble(gridViewItem.Rows[i].Cells[2].Value));
                    executeCommand.Parameters.AddWithValue("@benefit", gridViewItem.Rows[i].Cells[4].Value.ToString());
                    executeCommand.ExecuteNonQuery();
                    executeCommand.Parameters.Clear();
                }

                connect.Close();
                int invoice_ID = create_Goods_Received_Note(totalQuantityItem, totalPrice);
                create_Invoice_Detail(invoice_ID);
                MessageBox.Show("Successful");
                if (gridViewItem.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                      
                    app.Visible = true;
                   
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    
                    worksheet.Name = "Creating Goods received note";

                    for (int i = 1; i < gridViewItem.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = gridViewItem.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < gridViewItem.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < gridViewItem.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = gridViewItem.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    worksheet.Cells[1, 6] = "Invoice_ID";
                    worksheet.Cells[1, 7] = "Manager's ID";
                    worksheet.Cells[2, 6] = invoice_ID;
                    worksheet.Cells[2, 7] = managerID.Text;

                    string currDateTime = DateTime.Now.ToString("dd MM yyyy hh mm ss");
                    string path = System.IO.Path.GetFullPath("Inventory receiving voucher " + currDateTime + ".xlsx");

                    workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Visible = true;
                    workbook.Close();
                    app.Quit();

                }
                gridViewItem.Rows.Clear();


            }
            else
            {
                MessageBox.Show("Cancel");
            }

            
           


        }
        public void addItemToComboBox()
        {
            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();

            executeCommand.CommandText = "select * from Manager";
            SqlDataReader dr = executeCommand.ExecuteReader();
            
            while (dr.Read())
            {
                managerID.Items.Add(dr["Manager_ID"].ToString());
                item.AddRange(new List<ComboBoxItem>
                {
                    new ComboBoxItem(dr["Manager_ID"].ToString(), dr["Name"].ToString()),
                });
            }

            connect1.Close();


        }
        public int create_Goods_Received_Note(int totalQuantity,double totalPrice)
        {
            Connection create_Receipt = new Connection();
            create_Receipt.CreateConnection();
            SqlConnection connect2 = Connection.connection;

            SqlCommand executeCommand = connect2.CreateCommand();
            executeCommand.CommandText = "INSERT INTO Goods_Received_Note(TotalQuantityItems, Total_Imported_Price,CreatedDate,Manager_ID) VALUES(@param1,@param2,@param3,@param4);Select SCOPE_IDENTITY()";
            executeCommand.Parameters.AddWithValue("@param1", totalQuantity);
            executeCommand.Parameters.AddWithValue("@param2", totalPrice);
            
            executeCommand.Parameters.Add("@param3", SqlDbType.Date).Value = DateTime.Today.ToString("D");
            executeCommand.Parameters.AddWithValue("@param4", managerID.SelectedItem.ToString());
           
            int id = Convert.ToInt32(executeCommand.ExecuteScalar());
            
            connect2.Close();
            return id;
        }

        public void create_Invoice_Detail(int invoice_ID)
        {
            Connection create_Invoice_Detail = new Connection();
            create_Invoice_Detail.CreateConnection();
            SqlConnection connect = Connection.connection;

            SqlCommand executeCommand = connect.CreateCommand();
            executeCommand.CommandText = "INSERT INTO ImportedItems(TotalItemsQuantity, TotalItemsPrice, Invoice_ID,ItemsID) VALUES(@param1,@param2,@param3,@param4)";
            for (int i = 0; i < gridViewItem.Rows.Count - 1; i++)
            {
                executeCommand.Parameters.AddWithValue("@param1", Convert.ToInt32(gridViewItem.Rows[i].Cells[2].Value));
                executeCommand.Parameters.AddWithValue("@param2", Convert.ToDouble(gridViewItem.Rows[i].Cells[3].Value) * Convert.ToInt32(gridViewItem.Rows[i].Cells[2].Value));

                executeCommand.Parameters.AddWithValue("@param3", invoice_ID);
                executeCommand.Parameters.AddWithValue("@param4", gridViewItem.Rows[i].Cells[0].Value.ToString());


                executeCommand.ExecuteNonQuery();
                executeCommand.Parameters.Clear();
            }
            connect.Close();
        }
        private void txtPriceItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtManagerName.Text = item.ElementAt(managerID.SelectedIndex).Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtManagerName.Text = "";
            managerID.Text = "";
            txtBenefit.Text = "";
            txtPriceItem.Text = "";
            txtQuantityItem.Text = "";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    
        private void search_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;

            gridViewItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in gridViewItem.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        this.gridViewItem.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
