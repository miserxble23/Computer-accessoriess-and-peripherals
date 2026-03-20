namespace ComputerAccessoriesApp
{
    partial class CatalogForAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            StorekepLabel = new Label();
            SearchBoxAdmin = new TextBox();
            SearchButtonAdmin = new Button();
            ExitButton = new Button();
            DispatchButton = new Button();
            ProductsGridViewAdmin = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            NewCardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewAdmin).BeginInit();
            SuspendLayout();
            // 
            // StorekepLabel
            // 
            StorekepLabel.AutoSize = true;
            StorekepLabel.Font = new Font("Candara", 22.1538467F);
            StorekepLabel.ForeColor = Color.FromArgb(61, 65, 39);
            StorekepLabel.Location = new Point(12, 9);
            StorekepLabel.Name = "StorekepLabel";
            StorekepLabel.Size = new Size(314, 49);
            StorekepLabel.TabIndex = 0;
            StorekepLabel.Text = "Каталог товаров";
            // 
            // SearchBoxAdmin
            // 
            SearchBoxAdmin.BackColor = Color.FromArgb(212, 222, 149);
            SearchBoxAdmin.BorderStyle = BorderStyle.FixedSingle;
            SearchBoxAdmin.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBoxAdmin.Location = new Point(332, 83);
            SearchBoxAdmin.Name = "SearchBoxAdmin";
            SearchBoxAdmin.PlaceholderText = "  Поиск";
            SearchBoxAdmin.Size = new Size(352, 34);
            SearchBoxAdmin.TabIndex = 3;
            // 
            // SearchButtonAdmin
            // 
            SearchButtonAdmin.BackColor = Color.DarkOliveGreen;
            SearchButtonAdmin.Cursor = Cursors.Hand;
            SearchButtonAdmin.FlatStyle = FlatStyle.Popup;
            SearchButtonAdmin.Font = new Font("Candara", 12.1846151F);
            SearchButtonAdmin.ForeColor = Color.White;
            SearchButtonAdmin.Location = new Point(705, 83);
            SearchButtonAdmin.Name = "SearchButtonAdmin";
            SearchButtonAdmin.Size = new Size(111, 34);
            SearchButtonAdmin.TabIndex = 4;
            SearchButtonAdmin.Text = "Найти";
            SearchButtonAdmin.UseVisualStyleBackColor = false;
            SearchButtonAdmin.Click += SearchButtonAdmin_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkOliveGreen;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Candara", 12.1846151F);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(705, 24);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(111, 34);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // DispatchButton
            // 
            DispatchButton.BackColor = Color.DarkOliveGreen;
            DispatchButton.Cursor = Cursors.Hand;
            DispatchButton.FlatStyle = FlatStyle.Popup;
            DispatchButton.Font = new Font("Candara", 12.1846151F);
            DispatchButton.ForeColor = Color.White;
            DispatchButton.Location = new Point(545, 24);
            DispatchButton.Name = "DispatchButton";
            DispatchButton.Size = new Size(139, 34);
            DispatchButton.TabIndex = 6;
            DispatchButton.Text = "Отгрузка";
            DispatchButton.UseVisualStyleBackColor = false;
            DispatchButton.Click += DispatchButton_Click;
            // 
            // ProductsGridViewAdmin
            // 
            ProductsGridViewAdmin.BackgroundColor = Color.FromArgb(197, 227, 132);
            ProductsGridViewAdmin.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle1.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductsGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductsGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGridViewAdmin.Columns.AddRange(new DataGridViewColumn[] { ID, ProductName, Category, Quantity, Unit, Price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle2.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductsGridViewAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            ProductsGridViewAdmin.EnableHeadersVisualStyles = false;
            ProductsGridViewAdmin.Location = new Point(49, 143);
            ProductsGridViewAdmin.Name = "ProductsGridViewAdmin";
            ProductsGridViewAdmin.RowHeadersVisible = false;
            ProductsGridViewAdmin.RowHeadersWidth = 56;
            ProductsGridViewAdmin.Size = new Size(741, 363);
            ProductsGridViewAdmin.TabIndex = 8;
            ProductsGridViewAdmin.CellDoubleClick += ProductsGridViewAdmin_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.FillWeight = 112F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 80;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "name";
            ProductName.FillWeight = 112F;
            ProductName.HeaderText = "Название";
            ProductName.MinimumWidth = 7;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 146;
            // 
            // Category
            // 
            Category.DataPropertyName = "category";
            Category.FillWeight = 112F;
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 7;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 143;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "stock";
            Quantity.FillWeight = 112F;
            Quantity.HeaderText = "Остаток";
            Quantity.MinimumWidth = 7;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 123;
            // 
            // Unit
            // 
            Unit.DataPropertyName = "unit";
            Unit.FillWeight = 112F;
            Unit.HeaderText = "Ед. Изм.";
            Unit.MinimumWidth = 7;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            Unit.Width = 123;
            // 
            // Price
            // 
            Price.DataPropertyName = "price";
            Price.FillWeight = 112F;
            Price.HeaderText = "Цена(руб.)";
            Price.MinimumWidth = 7;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 123;
            // 
            // NewCardButton
            // 
            NewCardButton.BackColor = Color.DarkOliveGreen;
            NewCardButton.Cursor = Cursors.Hand;
            NewCardButton.FlatStyle = FlatStyle.Popup;
            NewCardButton.Font = new Font("Candara", 12.1846151F);
            NewCardButton.ForeColor = Color.White;
            NewCardButton.Location = new Point(332, 24);
            NewCardButton.Name = "NewCardButton";
            NewCardButton.Size = new Size(196, 34);
            NewCardButton.TabIndex = 9;
            NewCardButton.Text = "Новая карточка";
            NewCardButton.UseVisualStyleBackColor = false;
            // 
            // CatalogForAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(839, 530);
            Controls.Add(NewCardButton);
            Controls.Add(ProductsGridViewAdmin);
            Controls.Add(DispatchButton);
            Controls.Add(ExitButton);
            Controls.Add(SearchButtonAdmin);
            Controls.Add(SearchBoxAdmin);
            Controls.Add(StorekepLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CatalogForAdmin";
            Text = "catalogForStorekeepers";
            Load += CatalogForAdmin_Load;
            MouseDown += CatalogForAdmin_MouseDown;
            MouseMove += CatalogForAdmin_MouseMove;
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StorekepLabel;
        private TextBox SearchBoxAdmin;
        private Button SearchButtonAdmin;
        private Button ExitButton;
        private Button DispatchButton;
        private DataGridView ProductsGridViewAdmin;
        private Button NewCardButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
    }
}