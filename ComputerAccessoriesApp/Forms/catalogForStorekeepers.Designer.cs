namespace ComputerAccessoriesApp
{
    partial class CatalogForStorekeepers
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
            AdminLabel = new Label();
            SearchBoxStorekep = new TextBox();
            SearchButtonStorekep = new Button();
            ExitButton = new Button();
            DispatchButton = new Button();
            ProductsGridViewStorekep = new DataGridView();
            ArrivalButton = new Button();
            SupplieButton = new Button();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Relevance = new DataGridViewTextBoxColumn();
            Sale = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewStorekep).BeginInit();
            SuspendLayout();
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Candara", 22.1538467F);
            AdminLabel.ForeColor = Color.FromArgb(61, 65, 39);
            AdminLabel.Location = new Point(12, 22);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(288, 45);
            AdminLabel.TabIndex = 0;
            AdminLabel.Text = "Каталог товаров";
            // 
            // SearchBoxStorekep
            // 
            SearchBoxStorekep.BackColor = Color.FromArgb(212, 222, 149);
            SearchBoxStorekep.BorderStyle = BorderStyle.FixedSingle;
            SearchBoxStorekep.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBoxStorekep.Location = new Point(285, 79);
            SearchBoxStorekep.Name = "SearchBoxStorekep";
            SearchBoxStorekep.PlaceholderText = "  Поиск";
            SearchBoxStorekep.Size = new Size(313, 32);
            SearchBoxStorekep.TabIndex = 3;
            // 
            // SearchButtonStorekep
            // 
            SearchButtonStorekep.BackColor = Color.DarkOliveGreen;
            SearchButtonStorekep.Cursor = Cursors.Hand;
            SearchButtonStorekep.FlatStyle = FlatStyle.Popup;
            SearchButtonStorekep.Font = new Font("Candara", 12.1846151F);
            SearchButtonStorekep.ForeColor = Color.White;
            SearchButtonStorekep.Location = new Point(604, 79);
            SearchButtonStorekep.Name = "SearchButtonStorekep";
            SearchButtonStorekep.Size = new Size(99, 32);
            SearchButtonStorekep.TabIndex = 4;
            SearchButtonStorekep.Text = "Найти";
            SearchButtonStorekep.UseVisualStyleBackColor = false;
            SearchButtonStorekep.Click += SearchButtonStorekep_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkOliveGreen;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Candara", 12.1846151F);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(604, 496);
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
            DispatchButton.Location = new Point(474, 34);
            DispatchButton.Name = "DispatchButton";
            DispatchButton.Size = new Size(124, 32);
            DispatchButton.TabIndex = 6;
            DispatchButton.Text = "Отгрузка";
            DispatchButton.UseVisualStyleBackColor = false;
            DispatchButton.Click += DispatchButton_Click;
            // 
            // ProductsGridViewStorekep
            // 
            ProductsGridViewStorekep.BackgroundColor = Color.FromArgb(197, 227, 132);
            ProductsGridViewStorekep.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle1.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductsGridViewStorekep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductsGridViewStorekep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGridViewStorekep.Columns.AddRange(new DataGridViewColumn[] { ProductName, Category, Quantity, Unit, Price, Relevance, Sale });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle2.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductsGridViewStorekep.DefaultCellStyle = dataGridViewCellStyle2;
            ProductsGridViewStorekep.EnableHeadersVisualStyles = false;
            ProductsGridViewStorekep.Location = new Point(44, 136);
            ProductsGridViewStorekep.Name = "ProductsGridViewStorekep";
            ProductsGridViewStorekep.RowHeadersVisible = false;
            ProductsGridViewStorekep.RowHeadersWidth = 56;
            ProductsGridViewStorekep.Size = new Size(659, 346);
            ProductsGridViewStorekep.TabIndex = 7;
            ProductsGridViewStorekep.CellDoubleClick += ProductsGridViewStorekep_CellDoubleClick;
            // 
            // ArrivalButton
            // 
            ArrivalButton.BackColor = Color.DarkOliveGreen;
            ArrivalButton.Cursor = Cursors.Hand;
            ArrivalButton.FlatStyle = FlatStyle.Popup;
            ArrivalButton.Font = new Font("Candara", 12.1846151F);
            ArrivalButton.ForeColor = Color.White;
            ArrivalButton.Location = new Point(604, 34);
            ArrivalButton.Name = "ArrivalButton";
            ArrivalButton.Size = new Size(99, 32);
            ArrivalButton.TabIndex = 8;
            ArrivalButton.Text = "Приход";
            ArrivalButton.UseVisualStyleBackColor = false;
            // 
            // SupplieButton
            // 
            SupplieButton.BackColor = Color.DarkOliveGreen;
            SupplieButton.Cursor = Cursors.Hand;
            SupplieButton.FlatStyle = FlatStyle.Popup;
            SupplieButton.Font = new Font("Candara", 12.1846151F);
            SupplieButton.ForeColor = Color.White;
            SupplieButton.Location = new Point(306, 35);
            SupplieButton.Name = "SupplieButton";
            SupplieButton.Size = new Size(162, 32);
            SupplieButton.TabIndex = 9;
            SupplieButton.Text = "Поставка";
            SupplieButton.UseVisualStyleBackColor = false;
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
            // Relevance
            // 
            Relevance.FillWeight = 112F;
            Relevance.HeaderText = "Актуальность";
            Relevance.MinimumWidth = 7;
            Relevance.Name = "Relevance";
            Relevance.Width = 123;
            // 
            // Sale
            // 
            Sale.HeaderText = "Скидка";
            Sale.MinimumWidth = 6;
            Sale.Name = "Sale";
            Sale.Width = 125;
            // 
            // CatalogForStorekeepers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 540);
            Controls.Add(SupplieButton);
            Controls.Add(ArrivalButton);
            Controls.Add(ProductsGridViewStorekep);
            Controls.Add(DispatchButton);
            Controls.Add(ExitButton);
            Controls.Add(SearchButtonStorekep);
            Controls.Add(SearchBoxStorekep);
            Controls.Add(AdminLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CatalogForStorekeepers";
            Text = "catalogForStorekeepers";
            Load += CatalogForStorekeepers_Load;
            MouseDown += CatalogForStorekeepers_MouseDown;
            MouseMove += CatalogForStorekeepers_MouseMove;
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewStorekep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminLabel;
        private TextBox SearchBoxStorekep;
        private Button SearchButtonStorekep;
        private Button ExitButton;
        private Button DispatchButton;
        private DataGridView ProductsGridViewStorekep;
        private Button ArrivalButton;
        private Button SupplieButton;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Relevance;
        private DataGridViewTextBoxColumn Sale;
    }
}