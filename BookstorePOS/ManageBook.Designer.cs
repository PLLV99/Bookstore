namespace Bookstore
{
    partial class ManageBook
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxTitle = new TextBox();
            txtBoxAuthor = new TextBox();
            txtBoxISBN = new TextBox();
            txtBoxPrice = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            label6 = new Label();
            txtBoxStock = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 0;
            label1.Text = "ManageBook";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 130);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 195);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 1;
            label4.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 259);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 1;
            label5.Text = "Price:";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(89, 69);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(200, 27);
            txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(89, 127);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(200, 27);
            txtBoxAuthor.TabIndex = 2;
            // 
            // txtBoxISBN
            // 
            txtBoxISBN.Location = new Point(89, 192);
            txtBoxISBN.Name = "txtBoxISBN";
            txtBoxISBN.Size = new Size(200, 27);
            txtBoxISBN.TabIndex = 3;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(89, 256);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(200, 27);
            txtBoxPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 361);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(115, 361);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(65, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(199, 361);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(115, 412);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Author, ISBN, Price, Stock });
            dataGridView1.Location = new Point(313, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(853, 321);
            dataGridView1.TabIndex = 4;
            // 
            // Title
            // 
            Title.FillWeight = 195F;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 50;
            Title.Name = "Title";
            // 
            // Author
            // 
            Author.FillWeight = 155F;
            Author.HeaderText = "Author";
            Author.MinimumWidth = 50;
            Author.Name = "Author";
            // 
            // ISBN
            // 
            ISBN.FillWeight = 120F;
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 50;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            // 
            // Price
            // 
            Price.FillWeight = 70F;
            Price.HeaderText = "Price ($)";
            Price.MinimumWidth = 50;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.FillWeight = 70F;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 50;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 306);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 1;
            label6.Text = "Stock:";
            // 
            // txtBoxStock
            // 
            txtBoxStock.Location = new Point(89, 303);
            txtBoxStock.Name = "txtBoxStock";
            txtBoxStock.Size = new Size(200, 27);
            txtBoxStock.TabIndex = 5;
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxStock);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxISBN);
            Controls.Add(txtBoxAuthor);
            Controls.Add(label6);
            Controls.Add(txtBoxTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyForm";
            Text = "ManageBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxTitle;
        private TextBox txtBoxAuthor;
        private TextBox txtBoxISBN;
        private TextBox txtBoxPrice;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBack;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txtBoxStock;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
    }
}