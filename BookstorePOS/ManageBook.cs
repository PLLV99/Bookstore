using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;
using Bookstore.Models.DataLayer;

namespace Bookstore
{
    public partial class ManageBook : Form
    {

        public ManageBook()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            LoadBooksToGrid();
        }

        private void LoadBooksToGrid()
        {
            dataGridView1.Rows.Clear();
            using var context = new BookstoreContext();
            var books = context.Books.ToList();
            foreach (var book in books)
            {
                dataGridView1.Rows.Add(book.Title, book.Author, book.ISBN, book.Price, book.Stock);
            }
        }

        private bool ValidateInput(string title, string author, string isbn, string priceText, string stockText, string originalIsbn)
        {
            string errorMessage = "";
            using var context = new BookstoreContext();

            errorMessage += Validator.IsPresent(title, "Title") +
                            Validator.IsPresent(author, "Author") +
                            Validator.IsPresent(isbn, "ISBN") +
                            Validator.IsLengthValid(title, "Title", 100) +
                            Validator.IsLengthValid(author, "Author", 100) +
                            Validator.IsLengthValid(isbn, "ISBN", 13) +
                            Validator.IsDecimal(priceText, "Price") +
                            Validator.IsInt32(stockText, "Stock");

            if (isbn != originalIsbn && context.Books.Any(b => b.ISBN == isbn))
            {
                errorMessage += "ISBN already exists." + Validator.LineEnd;
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Input Error");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtBoxTitle.Text.Trim();
                string author = txtBoxAuthor.Text.Trim();
                string isbn = txtBoxISBN.Text.Trim();
                string priceText = txtBoxPrice.Text.Trim();
                string stockText = txtBoxStock.Text.Trim();

                if (!ValidateInput(title, author, isbn, priceText, stockText, null))
                    return;

                using var context = new BookstoreContext();
                context.Books.Add(new Book
                {
                    Title = title,
                    Author = author,
                    ISBN = isbn,
                    Price = decimal.Parse(priceText),
                    Stock = int.Parse(stockText)
                });
                context.SaveChanges();
                LoadBooksToGrid();
                ClearControls();
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book.", "Selection Error");
                return;
            }

            try
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string isbn = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
                using var context = new BookstoreContext();
                var book = context.Books.FirstOrDefault(b => b.ISBN == isbn);

                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error");
                    return;
                }

                string title = txtBoxTitle.Text.Trim();
                string author = txtBoxAuthor.Text.Trim();
                string newIsbn = txtBoxISBN.Text.Trim();
                string priceText = txtBoxPrice.Text.Trim();
                string stockText = txtBoxStock.Text.Trim();

                if (!ValidateInput(title, author, newIsbn, priceText, stockText, isbn))
                    return;
                if (MessageBox.Show($"Update {book.Title}?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    book.Title = title;
                    book.Author = author;
                    book.ISBN = newIsbn;
                    book.Price = decimal.Parse(priceText);
                    book.Stock = int.Parse(stockText);
                    context.SaveChanges();
                    LoadBooksToGrid();
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book.", "Selection Error");
                return;
            }

            try
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string isbn = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
                using var context = new BookstoreContext();
                var book = context.Books.FirstOrDefault(b => b.ISBN == isbn);

                if (book == null)
                {
                    MessageBox.Show("Book not found.", "Error");
                    return;
                }

                if (MessageBox.Show($"Delete {book.Title}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    LoadBooksToGrid();
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                txtBoxTitle.Text = dataGridView1.Rows[selectedIndex].Cells[0].Value?.ToString();
                txtBoxAuthor.Text = dataGridView1.Rows[selectedIndex].Cells[1].Value?.ToString();
                txtBoxISBN.Text = dataGridView1.Rows[selectedIndex].Cells[2].Value?.ToString();
                txtBoxPrice.Text = dataGridView1.Rows[selectedIndex].Cells[3].Value?.ToString();
                txtBoxStock.Text = dataGridView1.Rows[selectedIndex].Cells[4].Value?.ToString();
            }
        }
        private void ClearControls()
        {
            txtBoxTitle.Clear();
            txtBoxAuthor.Clear();
            txtBoxISBN.Clear();
            txtBoxPrice.Clear();
            txtBoxStock.Clear();
            txtBoxTitle.Focus();
        }
        private void HandleError(Exception ex)
        {
            MessageBox.Show("An error occurred.", "Error");
        }
    }
}