using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models.DataLayer;
using Bookstore.Models;

namespace Bookstore
{
    public partial class SearchPurchaseForm : Form
    {
        private readonly int userId;

        public SearchPurchaseForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using var context = new BookstoreContext();
                dataGridView1.Rows.Clear();
                string title = txtSearchByTitle.Text.Trim();
                var books = context.Books
                    .Where(b => string.IsNullOrEmpty(title) || b.Title.Contains(title))
                    .Take(50)
                    .ToList();

                if (books.Count == 0)
                {
                    MessageBox.Show("No books found.", "Info");
                    return;
                }

                foreach (var book in books)
                {
                    int rowIndex = dataGridView1.Rows.Add(book.Title, book.Author, $"${book.Price:F2}", book.Stock);
                    dataGridView1.Rows[rowIndex].Tag = book.BookId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void txtSearchByTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadBooks();
                e.SuppressKeyPress = true;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a book.", "Selection Error");
                    return;
                }

                int bookId = (int)dataGridView1.SelectedRows[0].Tag;
                using var context = new BookstoreContext();
                var book = context.Books.Find(bookId);

                if (book == null || book.Stock <= 0)
                {
                    MessageBox.Show("Book not available.", "Error");
                    return;
                }

                var cartItem = context.CartItems.FirstOrDefault(c => c.UserId == userId && c.BookId == bookId);
                if (cartItem == null)
                {
                    context.CartItems.Add(new CartItem
                    {
                        UserId = userId,
                        BookId = bookId,
                        Quantity = 1
                    });
                }
                else
                {
                    cartItem.Quantity++;
                }
                book.Stock--;
                context.SaveChanges();
                LoadBooks();
                MessageBox.Show($"{book.Title} added to cart!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            try
            {
                using var historyForm = new PurchaseHistoryForm(userId);
                historyForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred.", "Error");
            }
        }
        private void btnViewCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(userId);
            cartForm.ShowDialog();
            LoadBooks();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}