using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Bookstore
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["BookstoreConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    string username = txtUsername.Text.Trim().ToLower();
                    string password = txtPassword.Text.Trim();
                    string role = comboRole.SelectedItem?.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT UserId, Username, Password, Role FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@Role", role);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int userId = reader.GetInt32(0);
                                    Form nextForm = role == "Admin" ? new AdminDashboardForm(userId) : new SearchPurchaseForm(userId);
                                    this.Hide();
                                    nextForm.ShowDialog(); 
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No account or incorrect details. Please try again.", "Login Failed");
                                    ClearControls();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    string username = txtUsername.Text.Trim().ToLower();
                    string password = txtPassword.Text.Trim();
                    string role = "User";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@Username", username);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Username already exists.", "Signup Failed");
                                ClearControls();
                                return;
                            }
                        }

                        string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Username", username);
                            insertCmd.Parameters.AddWithValue("@Password", password);
                            insertCmd.Parameters.AddWithValue("@Role", role);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Signup successful! Please login.", "Success");
                    ClearControls();
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtUsername.Text, "Username") +
                            Validator.IsPresent(txtPassword.Text, "Password") +
                            Validator.IsPresent(comboRole.SelectedItem?.ToString(), "Role") +
                            Validator.IsLengthValid(txtUsername.Text, "Username", 50);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtUsername.Focus();
            }
            return success;
        }

        private void ClearControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            comboRole.SelectedIndex = -1;
            txtUsername.Focus();
        }

        private void HandleGeneralError(Exception ex)
        {
            string userMessage = ex is SqlException ? "A database error occurred. Please try again later." : ex.Message;
            MessageBox.Show(userMessage, "Error");
        }
    }
}