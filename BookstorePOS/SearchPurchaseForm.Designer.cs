namespace Bookstore
{
    partial class SearchPurchaseForm
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
            label2 = new Label();
            txtSearchByTitle = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btnAddToCart = new Button();
            btnViewHistory = new Button();
            btnBack = new Button();
            btnViewCart = new Button();
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
            label1.Size = new Size(192, 38);
            label1.TabIndex = 7;
            label1.Text = "Search Books";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 6;
            label2.Text = "Search by Title:";
            // 
            // txtSearchByTitle
            // 
            txtSearchByTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchByTitle.Location = new Point(135, 60);
            txtSearchByTitle.Name = "txtSearchByTitle";
            txtSearchByTitle.Size = new Size(338, 27);
            txtSearchByTitle.TabIndex = 5;
            txtSearchByTitle.KeyDown += txtSearchByTitle_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(479, 57);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Price, Stock });
            dataGridView1.Location = new Point(20, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(741, 348);
            dataGridView1.TabIndex = 3;
            // 
            // Title
            // 
            Title.FillWeight = 140F;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.FillWeight = 120F;
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Price
            // 
            Price.FillWeight = 60F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.FillWeight = 60F;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Top;
            btnAddToCart.Location = new Point(63, 454);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(100, 30);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Anchor = AnchorStyles.Top;
            btnViewHistory.Location = new Point(373, 454);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(100, 30);
            btnViewHistory.TabIndex = 1;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.Location = new Point(594, 454);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Anchor = AnchorStyles.Top;
            btnViewCart.Location = new Point(207, 454);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(120, 30);
            btnViewCart.TabIndex = 9;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // SearchPurchaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 496);
            Controls.Add(btnViewCart);
            Controls.Add(btnBack);
            Controls.Add(btnViewHistory);
            Controls.Add(btnAddToCart);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchByTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SearchPurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchByTitle;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnAddToCart;
        private Button btnViewHistory;
        private Button btnBack;
        private Button btnViewCart;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
    }
}