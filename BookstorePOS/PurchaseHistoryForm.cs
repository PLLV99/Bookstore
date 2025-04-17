using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models.DataLayer;

namespace Bookstore
{
    public partial class PurchaseHistoryForm : Form
    {
        private readonly int userId;

        public PurchaseHistoryForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                using var context = new BookstoreContext();
                dataGridView1.Rows.Clear();
                var purchases = context.Purchases
                    .Where(p => p.UserId == userId)
                    .OrderByDescending(p => p.PurchaseDate)
                    .Take(50)
                    .ToList();

                if (purchases.Count == 0)
                {
                    MessageBox.Show("No purchase history found.", "Info");
                    return;
                }

                foreach (var purchase in purchases)
                {
                    dataGridView1.Rows.Add(
                        purchase.PurchaseId,
                        purchase.PurchaseDate.ToString("yyyy-MM-dd HH:mm"),
                        purchase.BookTitle,
                        purchase.Quantity,
                        $"${purchase.TotalPrice:F2}",
                        purchase.PaymentMethod
                    );
                }
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