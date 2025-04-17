using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models.DataLayer;
using Bookstore.Models;

namespace Bookstore
{
    public partial class CartForm : Form
    {
        private readonly int userId;

        public CartForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadCart();
        }

        private void LoadCart()
        {
            try
            {
                using var context = new BookstoreContext();
                dataGridView1.Rows.Clear();
                var cartItems = context.CartItems
                    .Include(c => c.Book)
                    .Where(c => c.UserId == userId)
                    .ToList();

                if (cartItems.Count == 0)
                {
                    lblTotal.Text = "Total: $0.00";
                    return;
                }

                decimal totalPrice = 0;
                foreach (var item in cartItems)
                {
                    decimal itemTotal = item.Book.Price * item.Quantity;
                    dataGridView1.Rows.Add(item.Book.Title, item.Quantity, $"${item.Book.Price:F2}", $"${itemTotal:F2}");
                    totalPrice += itemTotal;
                }
                lblTotal.Text = $"Total: ${totalPrice:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a payment method.", "Error");
                    return;
                }

                using var context = new BookstoreContext();
                var cartItems = context.CartItems
                    .Include(c => c.Book)
                    .Where(c => c.UserId == userId)
                    .ToList();

                if (cartItems.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.", "Error");
                    return;
                }

                foreach (var item in cartItems)
                {
                    if (item.Book.Stock < item.Quantity)
                    {
                        MessageBox.Show($"{item.Book.Title} has only {item.Book.Stock} in stock.", "Error");
                        return;
                    }
                    context.Purchases.Add(new Purchase
                    {
                        UserId = userId,
                        BookId = item.BookId,
                        BookTitle = item.Book.Title,
                        PurchaseDate = DateTime.Now,
                        Quantity = item.Quantity,
                        TotalPrice = item.Book.Price * item.Quantity,
                        PaymentMethod = cboPaymentMethod.SelectedItem.ToString()
                    });
                }
                context.CartItems.RemoveRange(cartItems);
                context.SaveChanges();
                LoadCart();
                MessageBox.Show($"Checkout completed !", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an item.", "Selection Error");
                    return;
                }

                string title = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                using var context = new BookstoreContext();
                var cartItem = context.CartItems
                    .Include(c => c.Book)
                    .FirstOrDefault(c => c.UserId == userId && c.Book.Title == title);

                if (cartItem != null)
                {
                    cartItem.Book.Stock += cartItem.Quantity;
                    context.CartItems.Remove(cartItem);
                    context.SaveChanges();
                    LoadCart();
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1) // Quantity
                {
                    string title = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString(), out int quantity) || quantity < 1)
                    {
                        MessageBox.Show("Quantity must be at least 1.", "Error");
                        LoadCart();
                        return;
                    }

                    using var context = new BookstoreContext();
                    var cartItem = context.CartItems
                        .Include(c => c.Book)
                        .FirstOrDefault(c => c.UserId == userId && c.Book.Title == title);

                    if (cartItem != null)
                    {
                        if (quantity > cartItem.Book.Stock)
                        {
                            MessageBox.Show($"{cartItem.Book.Title} has only {cartItem.Book.Stock} in stock.", "Error");
                            LoadCart();
                            return;
                        }
                        int delta = cartItem.Quantity - quantity;
                        cartItem.Book.Stock += delta;
                        cartItem.Quantity = quantity;
                        context.SaveChanges();
                    }
                    LoadCart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }
    }
}