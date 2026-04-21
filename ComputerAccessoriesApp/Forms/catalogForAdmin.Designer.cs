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
            NewCardButton = new Button();
            SettingsButton = new Button();
            DispatchsButton = new Button();
            ProductsGridViewAdmin = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            PurchasePrice = new DataGridViewTextBoxColumn();
            Relevance = new DataGridViewTextBoxColumn();
            Sale = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewAdmin).BeginInit();
            SuspendLayout();
            // 
            // StorekepLabel
            // 
            StorekepLabel.Font = new Font("Candara", 22.1538467F);
            StorekepLabel.ForeColor = Color.FromArgb(61, 65, 39);
            StorekepLabel.Location = new Point(22, 21);
            StorekepLabel.Name = "StorekepLabel";
            StorekepLabel.Size = new Size(155, 90);
            StorekepLabel.TabIndex = 0;
            StorekepLabel.Text = "Каталог товаров";
            // 
            // SearchBoxAdmin
            // 
            SearchBoxAdmin.BackColor = Color.FromArgb(212, 222, 149);
            SearchBoxAdmin.BorderStyle = BorderStyle.FixedSingle;
            SearchBoxAdmin.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBoxAdmin.Location = new Point(171, 79);
            SearchBoxAdmin.Name = "SearchBoxAdmin";
            SearchBoxAdmin.PlaceholderText = "  Поиск";
            SearchBoxAdmin.Size = new Size(429, 32);
            SearchBoxAdmin.TabIndex = 3;
            // 
            // SearchButtonAdmin
            // 
            SearchButtonAdmin.BackColor = Color.DarkOliveGreen;
            SearchButtonAdmin.Cursor = Cursors.Hand;
            SearchButtonAdmin.FlatStyle = FlatStyle.Popup;
            SearchButtonAdmin.Font = new Font("Candara", 12.1846151F);
            SearchButtonAdmin.ForeColor = Color.White;
            SearchButtonAdmin.Location = new Point(606, 77);
            SearchButtonAdmin.Name = "SearchButtonAdmin";
            SearchButtonAdmin.Size = new Size(99, 32);
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
            ExitButton.Location = new Point(606, 496);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(99, 32);
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
            DispatchButton.Location = new Point(351, 33);
            DispatchButton.Name = "DispatchButton";
            DispatchButton.Size = new Size(106, 32);
            DispatchButton.TabIndex = 6;
            DispatchButton.Text = "Поставка";
            DispatchButton.UseVisualStyleBackColor = false;
            DispatchButton.Click += DispatchButton_Click;
            // 
            // NewCardButton
            // 
            NewCardButton.BackColor = Color.DarkOliveGreen;
            NewCardButton.Cursor = Cursors.Hand;
            NewCardButton.FlatStyle = FlatStyle.Popup;
            NewCardButton.Font = new Font("Candara", 12.1846151F);
            NewCardButton.ForeColor = Color.White;
            NewCardButton.Location = new Point(171, 33);
            NewCardButton.Name = "NewCardButton";
            NewCardButton.Size = new Size(174, 32);
            NewCardButton.TabIndex = 9;
            NewCardButton.Text = "Новая карточка";
            NewCardButton.UseVisualStyleBackColor = false;
            NewCardButton.Click += NewCardButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.DarkOliveGreen;
            SettingsButton.Cursor = Cursors.Hand;
            SettingsButton.FlatStyle = FlatStyle.Popup;
            SettingsButton.Font = new Font("Candara", 12.1846151F);
            SettingsButton.ForeColor = Color.White;
            SettingsButton.Location = new Point(463, 33);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(137, 32);
            SettingsButton.TabIndex = 10;
            SettingsButton.Text = "Настройки";
            SettingsButton.UseVisualStyleBackColor = false;
            // 
            // DispatchsButton
            // 
            DispatchsButton.BackColor = Color.DarkOliveGreen;
            DispatchsButton.Cursor = Cursors.Hand;
            DispatchsButton.FlatStyle = FlatStyle.Popup;
            DispatchsButton.Font = new Font("Candara", 12.1846151F);
            DispatchsButton.ForeColor = Color.White;
            DispatchsButton.Location = new Point(606, 33);
            DispatchsButton.Name = "DispatchsButton";
            DispatchsButton.Size = new Size(99, 32);
            DispatchsButton.TabIndex = 11;
            DispatchsButton.Text = "Отчёты";
            DispatchsButton.UseVisualStyleBackColor = false;
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
            ProductsGridViewAdmin.Columns.AddRange(new DataGridViewColumn[] { ProductName, Category, Quantity, Unit, Price, PurchasePrice, Relevance, Sale });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle2.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductsGridViewAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            ProductsGridViewAdmin.EnableHeadersVisualStyles = false;
            ProductsGridViewAdmin.Location = new Point(44, 132);
            ProductsGridViewAdmin.Name = "ProductsGridViewAdmin";
            ProductsGridViewAdmin.RowHeadersVisible = false;
            ProductsGridViewAdmin.RowHeadersWidth = 56;
            ProductsGridViewAdmin.Size = new Size(661, 346);
            ProductsGridViewAdmin.TabIndex = 8;
            ProductsGridViewAdmin.CellDoubleClick += ProductsGridViewAdmin_CellDoubleClick;
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
            Quantity.HeaderText = "Количество";
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
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 7;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 123;
            // 
            // PurchasePrice
            // 
            PurchasePrice.HeaderText = "Закуп. цена";
            PurchasePrice.MinimumWidth = 6;
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.Width = 125;
            // 
            // Relevance
            // 
            Relevance.HeaderText = "Актуальность";
            Relevance.MinimumWidth = 6;
            Relevance.Name = "Relevance";
            Relevance.Width = 125;
            // 
            // Sale
            // 
            Sale.HeaderText = "Скидка";
            Sale.MinimumWidth = 6;
            Sale.Name = "Sale";
            Sale.Width = 125;
            // 
            // CatalogForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 540);
            Controls.Add(DispatchsButton);
            Controls.Add(SettingsButton);
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
        private Button NewCardButton;
        private Button SettingsButton;
        private Button DispatchsButton;
        private DataGridView ProductsGridViewAdmin;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn PurchasePrice;
        private DataGridViewTextBoxColumn Relevance;
        private DataGridViewTextBoxColumn Sale;
    }
}