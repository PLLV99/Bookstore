namespace Bookstore
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnEditBooks = new Button();
            btnSalesReport = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.Size = new Size(500, 38);
            label1.TabIndex = 4;
            label1.Text = "Admin Dashboard";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEditBooks
            // 
            btnEditBooks.Anchor = AnchorStyles.Top;
            btnEditBooks.Location = new Point(175, 100);
            btnEditBooks.Name = "btnEditBooks";
            btnEditBooks.Size = new Size(150, 30);
            btnEditBooks.TabIndex = 1;
            btnEditBooks.Text = "Manage Books";
            btnEditBooks.UseVisualStyleBackColor = true;
            btnEditBooks.Click += btnEditBooks_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.Anchor = AnchorStyles.Top;
            btnSalesReport.Location = new Point(175, 140);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(150, 30);
            btnSalesReport.TabIndex = 2;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top;
            btnLogout.Location = new Point(175, 180);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 30);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 251);
            Controls.Add(btnLogout);
            Controls.Add(btnSalesReport);
            Controls.Add(btnEditBooks);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            ResumeLayout(false);
        }
        #endregion

        private Label label1;
        private Button btnEditBooks;
        private Button btnSalesReport;
        private Button btnLogout;
    }
}