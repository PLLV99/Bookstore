using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;
using Bookstore.Models.DataLayer;

namespace Bookstore
{
    public partial class SalesReportForm : Form
    {
        private readonly BookstoreContext context = new BookstoreContext();

        public SalesReportForm()
        {
            InitializeComponent();
            LoadSalesToGrid();
        }

        private void LoadSalesToGrid()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var purchases = context.Purchases.Take(50).ToList();
                int totalBooksSold = 0;
                decimal totalSales = 0;

                foreach (var purchase in purchases)
                {
                    dataGridView1.Rows.Add(
                        purchase.PurchaseId,
                        purchase.PurchaseDate.ToString("yyyy-MM-dd"),
                        purchase.BookTitle,
                        purchase.Quantity,
                        purchase.TotalPrice
                    );
                    totalBooksSold += purchase.Quantity;
                    totalSales += purchase.TotalPrice;
                }

                lblTotalBooksSold.Text = $"Total Books Sold: {totalBooksSold}";
                lblTotalSales.Text = $"Total Sales: ${totalSales:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}