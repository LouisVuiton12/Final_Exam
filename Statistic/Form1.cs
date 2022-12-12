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

namespace Statistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataToBestSellingView();
            loadDataToMonthlyRevenue();
        }
        private void btnIncoming_Click(object sender, EventArgs e)
        {
            incomingGood();
        }
        private void incomingGood()
        {
            gridViewGoodInAndOut.Rows.Clear();
            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();
            executeCommand.CommandText = "Select ItemsID, SUM(TotalItemsPrice) AS TotalItemPrice, SUM(TotalItemsQuantity) AS TotalItemQuantity from ImportedItems GROUP BY ItemsID";
            List<IncomingGood> incomingProducts = new List<IncomingGood>();
            SqlDataReader dr = executeCommand.ExecuteReader();

            while (dr.Read())
            {
                IncomingGood incomingProduct = new IncomingGood()
                {
                    ItemsID = dr["ItemsID"].ToString(),
                    TotalProductPrice = (double)dr["TotalItemPrice"],
                    TotalProductQuantity = (int)dr["TotalItemQuantity"]
                };

                incomingProducts.Add(incomingProduct);
            }

            for (int i = 0; i < incomingProducts.Count; i++)
            {
                gridViewGoodInAndOut.Rows.Add(incomingProducts[i].ItemsID, incomingProducts[i].TotalProductQuantity, incomingProducts[i].TotalProductPrice);
            }

        }

        private void btnOutcoming_Click(object sender, EventArgs e)
        {
            outcomingGood();
        }
        private void outcomingGood()
        {
            gridViewGoodInAndOut.Rows.Clear();
            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();
            executeCommand.CommandText = "Select ItemsID, SUM(TotalProductPrice) AS TotalItemPrice, SUM(TotalProductQuantity) AS TotalItemQuantity from OrderProducts GROUP BY ItemsID";
            List<OutcomingGood> outcomingProducts = new List<OutcomingGood>();
            SqlDataReader dr = executeCommand.ExecuteReader();

            while (dr.Read())
            {
                OutcomingGood outcomingProduct = new OutcomingGood()
                {
                    ItemsID = dr["ItemsID"].ToString(),
                    TotalProductPrice = (double)dr["TotalItemPrice"],
                    TotalProductQuantity = (int)dr["TotalItemQuantity"]
                };

                outcomingProducts.Add(outcomingProduct);
            }

            for (int i = 0; i < outcomingProducts.Count; i++)
            {
                gridViewGoodInAndOut.Rows.Add(outcomingProducts[i].ItemsID, outcomingProducts[i].TotalProductQuantity, outcomingProducts[i].TotalProductPrice);
            }

        }
        private void loadDataToBestSellingView()
        {
            gridViewBestSelling.Rows.Clear();
            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();
            executeCommand.CommandText = "SELECT TOP 1 TotalProductQuantity, ItemsID, TotalProductPrice FROM (" +
                "SELECT ItemsID, SUM(TotalProductPrice) AS TotalProductPrice, SUM(TotalProductQuantity) AS TotalProductQuantity FROM OrderProducts GROUP BY ItemsID)Best_Selling_Product ORDER BY TotalProductQuantity DESC";
            List<BestSellingItem> bestSellingProducts = new List<BestSellingItem>();
            SqlDataReader dr = executeCommand.ExecuteReader();

            while (dr.Read())
            {
                BestSellingItem bestSellingProduct = new BestSellingItem()
                {
                    ItemsID = dr["ItemsID"].ToString(),
                    TotalProductPrice = (double)dr["TotalProductPrice"],
                    TotalProductQuantity = (int)dr["TotalProductQuantity"]
                };

                bestSellingProducts.Add(bestSellingProduct);
            }

            for (int i = 0; i < bestSellingProducts.Count; i++)
            {
                gridViewBestSelling.Rows.Add(bestSellingProducts[i].ItemsID, bestSellingProducts[i].TotalProductQuantity, bestSellingProducts[i].TotalProductPrice);
            }

        }
        private void loadDataToMonthlyRevenue()
        {
            gridViewRevenue.Rows.Clear();
            Connection create_ComboBox = new Connection();
            create_ComboBox.CreateConnection();
            SqlConnection connect1 = Connection.connection;

            SqlCommand executeCommand = connect1.CreateCommand();
            executeCommand.CommandText = "SELECT MONTH(OrderedDate) AS Month, SUM(TotalOrderPrice) AS Revenue FROM OrderReceipt GROUP BY MONTH(OrderedDate)";
            List<Revenue> revenues = new List<Revenue>();
            SqlDataReader dr = executeCommand.ExecuteReader();

            while (dr.Read())
            {
                Revenue revenue = new Revenue()
                {
                    month = dr["Month"].ToString(),
                    TotalProductPrice = (double)dr["Revenue"],
                    
                };

                revenues.Add(revenue);
            }

            for (int i = 0; i < revenues.Count; i++)
            {
                gridViewRevenue.Rows.Add(revenues[i].month, revenues[i].TotalProductPrice);
            }
        }
    }
}
