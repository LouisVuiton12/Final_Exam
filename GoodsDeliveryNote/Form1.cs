using System;
using System.Collections;
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
using Microsoft.Office.Interop.Excel;

namespace GoodsDeliveryNote
{
    public partial class Form1 : Form
    {
        private static ArrayList OrderID1 = new ArrayList();
        private static ArrayList TotalOrderPrice1 = new ArrayList();
        private static ArrayList TotalOrderQuantity1 = new ArrayList();
        private static ArrayList OrderedDate1 = new ArrayList();
        private static ArrayList Status1 = new ArrayList();
        private static ArrayList AgentID1 = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            updateDatagrid();
            
        }

        private void savetoList()
        {
            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();

            executeCommand.CommandText = "select * from OrderReceipt";
            SqlDataReader dr = executeCommand.ExecuteReader();

            while (dr.Read())
            {
                string dateTime = ((DateTime)dr["OrderedDate"]).ToLongDateString().ToString();
                OrderID1.Add(dr["OrderID"].ToString());
                TotalOrderPrice1.Add(dr["TotalOrderPrice"].ToString());
                TotalOrderQuantity1.Add(dr["TotalOrderQuantity"].ToString());
                OrderedDate1.Add(dateTime);
                Status1.Add(dr["Status"].ToString());
                AgentID1.Add(dr["AgentID"].ToString());

            }

            connect1.Close();
        }
        private void updateDatagrid()
        {
            savetoList();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < OrderID1.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = OrderID1[i];
                newRow.Cells[1].Value = TotalOrderPrice1[i];
                newRow.Cells[2].Value = TotalOrderQuantity1[i];
                newRow.Cells[3].Value = OrderedDate1[i];
                newRow.Cells[4].Value = Status1[i];
                newRow.Cells[5].Value = AgentID1[i];
                
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            gridViewDetailOrder.Rows.Clear();
            
            int orderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();

            executeCommand.CommandText = "select * from OrderProducts where OrderID =" + orderId.ToString();
            SqlDataReader dr = executeCommand.ExecuteReader();

            List<OrderProduct> orderProducts = new List<OrderProduct>();

            while (dr.Read())
            {
                OrderProduct orderProduct = new OrderProduct()
                {
                    OrderID = (int)dr["OrderID"],
                    ItemsID = dr["ItemsID"].ToString(),
                    TotalProductPrice = (double) dr["TotalProductPrice"],
                    TotalProductQuantity = (int)dr["TotalProductQuantity"]
                };

                orderProducts.Add(orderProduct);
            }

            for (int i = 0; i < orderProducts.Count; i++)
            {
                gridViewDetailOrder.Rows.Add(orderProducts[i].OrderID, orderProducts[i].ItemsID, orderProducts[i].TotalProductQuantity, orderProducts[i].TotalProductPrice);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            if (DialogResult.Yes == MessageBox.Show("Are you sure to update Status", "Update Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        dataGridView1.Rows[i].Cells["Status"].Value = "Completed Transaction";
                        break;
  
                    }

                }
                int orderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Connection create_ComboBox = new Connection();
                create_ComboBox.CreateConnection();
                SqlConnection connect1 = Connection.connection;

                SqlCommand executeCommand = connect1.CreateCommand();
                executeCommand.CommandText = "UPDATE OrderReceipt SET Status = 'Completed Transaction' Where OrderID =" + orderId.ToString();
                executeCommand.ExecuteNonQuery();
                dataGridView1.Refresh();
                
                connect1.Close();
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Print out The Goods Delivery Note", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {

                if (gridViewDetailOrder.Rows.Count > 0)
                {
                    for (int item = 0; item < dataGridView1.Rows.Count; item++)
                    {
                        if (dataGridView1.Rows[item].Selected)
                        {
                            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                            app.Visible = true;

                            worksheet = workbook.Sheets["Sheet1"];
                            worksheet = workbook.ActiveSheet;

                            worksheet.Name = "Goods received note";

                            for (int i = 1; i < gridViewDetailOrder.Columns.Count + 1; i++)
                            {
                                worksheet.Cells[1, i] = gridViewDetailOrder.Columns[i - 1].HeaderText;
                            }
                            for (int i = 0; i < gridViewDetailOrder.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < gridViewDetailOrder.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1] = gridViewDetailOrder.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            string currDateTime = DateTime.Now.ToString("dd/MM/yyyyhh/mm/ss");
                            string path = System.IO.Path.GetFullPath("Good Delivery Note " + currDateTime + ".xlsx");

                            workbook.SaveAs(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                            app.Visible = true;
                            workbook.Close();
                            app.Quit();
                            break;

                        }

                    }
                   

                }
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
