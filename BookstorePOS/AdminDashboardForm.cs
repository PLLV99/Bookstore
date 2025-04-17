using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private readonly int userId;
        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            ManageBook editForm = new ManageBook();
            editForm.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm salesReportForm = new SalesReportForm();
            salesReportForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
