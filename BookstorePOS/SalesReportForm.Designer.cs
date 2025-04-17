namespace Bookstore
{
    partial class SalesReportForm
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            BookTitle = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            lblTotalBooksSold = new Label();
            lblTotalSales = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(280, 20);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 4;
            label1.Text = "Sales Report";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Date, BookTitle, Qty, TotalPrice });
            dataGridView1.Location = new Point(82, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(653, 265);
            dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // BookTitle
            // 
            BookTitle.HeaderText = "Book Title";
            BookTitle.MinimumWidth = 6;
            BookTitle.Name = "BookTitle";
            BookTitle.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.Location = new Point(350, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 30);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTotalBooksSold
            // 
            lblTotalBooksSold.AutoSize = true;
            lblTotalBooksSold.Location = new Point(123, 335);
            lblTotalBooksSold.Name = "lblTotalBooksSold";
            lblTotalBooksSold.Size = new Size(135, 20);
            lblTotalBooksSold.TabIndex = 1;
            lblTotalBooksSold.Text = "Total Books Sold: 0";
            lblTotalBooksSold.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(529, 335);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(122, 20);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "Total Sales: $0.00";
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(lblTotalSales);
            Controls.Add(lblTotalBooksSold);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SalesReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Label lblTotalBooksSold;
        private Label lblTotalSales;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}