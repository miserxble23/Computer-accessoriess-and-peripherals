namespace ComputerAccessoriesApp
{
    partial class Reports
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
            ReportsLabel = new Label();
            SearchBoxStorekep = new TextBox();
            FilterButton = new Button();
            ExitButton = new Button();
            ProductsGridViewStorekep = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Relevance = new DataGridViewTextBoxColumn();
            Sale = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            ExportButton = new Button();
            TotalBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewStorekep).BeginInit();
            SuspendLayout();
            // 
            // ReportsLabel
            // 
            ReportsLabel.AutoSize = true;
            ReportsLabel.Font = new Font("Candara", 22.1538467F);
            ReportsLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ReportsLabel.Location = new Point(12, 30);
            ReportsLabel.Name = "ReportsLabel";
            ReportsLabel.Size = new Size(311, 45);
            ReportsLabel.TabIndex = 0;
            ReportsLabel.Text = "История отгрузок";
            // 
            // SearchBoxStorekep
            // 
            SearchBoxStorekep.BackColor = Color.FromArgb(212, 222, 149);
            SearchBoxStorekep.BorderStyle = BorderStyle.FixedSingle;
            SearchBoxStorekep.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBoxStorekep.Location = new Point(451, 89);
            SearchBoxStorekep.Name = "SearchBoxStorekep";
            SearchBoxStorekep.PlaceholderText = "  Покупатель";
            SearchBoxStorekep.Size = new Size(178, 32);
            SearchBoxStorekep.TabIndex = 3;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.DarkOliveGreen;
            FilterButton.Cursor = Cursors.Hand;
            FilterButton.FlatStyle = FlatStyle.Popup;
            FilterButton.Font = new Font("Candara", 12.1846151F);
            FilterButton.ForeColor = Color.White;
            FilterButton.Location = new Point(635, 87);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(99, 32);
            FilterButton.TabIndex = 4;
            FilterButton.Text = "Фильтр";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += SearchButtonStorekep_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkOliveGreen;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Candara", 12.1846151F);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(635, 546);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(99, 32);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
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
            ProductsGridViewStorekep.Location = new Point(12, 144);
            ProductsGridViewStorekep.Name = "ProductsGridViewStorekep";
            ProductsGridViewStorekep.RowHeadersVisible = false;
            ProductsGridViewStorekep.RowHeadersWidth = 56;
            ProductsGridViewStorekep.Size = new Size(722, 318);
            ProductsGridViewStorekep.TabIndex = 7;
            ProductsGridViewStorekep.CellDoubleClick += ProductsGridViewStorekep_CellDoubleClick;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "name";
            ProductName.FillWeight = 112F;
            ProductName.HeaderText = "Дата";
            ProductName.MinimumWidth = 7;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 146;
            // 
            // Category
            // 
            Category.DataPropertyName = "category";
            Category.FillWeight = 112F;
            Category.HeaderText = "Покупатель";
            Category.MinimumWidth = 7;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 143;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "stock";
            Quantity.FillWeight = 112F;
            Quantity.HeaderText = "Товар";
            Quantity.MinimumWidth = 7;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 123;
            // 
            // Unit
            // 
            Unit.DataPropertyName = "unit";
            Unit.FillWeight = 112F;
            Unit.HeaderText = "Кол-во";
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
            Relevance.HeaderText = "Закуп. цена";
            Relevance.MinimumWidth = 7;
            Relevance.Name = "Relevance";
            Relevance.Width = 123;
            // 
            // Sale
            // 
            Sale.HeaderText = "Прибыль";
            Sale.MinimumWidth = 6;
            Sale.Name = "Sale";
            Sale.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Candara", 12.1846151F);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(212, 222, 149);
            dateTimePicker1.Font = new Font("Candara", 12.1846151F);
            dateTimePicker1.Location = new Point(12, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 32);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Candara", 12.1846151F);
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(212, 222, 149);
            dateTimePicker2.Font = new Font("Candara", 12.1846151F);
            dateTimePicker2.Location = new Point(265, 89);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(180, 32);
            dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 22.1538467F);
            label1.ForeColor = Color.FromArgb(61, 65, 39);
            label1.Location = new Point(216, 79);
            label1.Name = "label1";
            label1.Size = new Size(29, 45);
            label1.TabIndex = 10;
            label1.Text = "-";
            // 
            // ExportButton
            // 
            ExportButton.BackColor = Color.DarkOliveGreen;
            ExportButton.Cursor = Cursors.Hand;
            ExportButton.FlatStyle = FlatStyle.Popup;
            ExportButton.Font = new Font("Candara", 12.1846151F);
            ExportButton.ForeColor = Color.White;
            ExportButton.Location = new Point(12, 546);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(99, 32);
            ExportButton.TabIndex = 11;
            ExportButton.Text = "Экспорт";
            ExportButton.UseVisualStyleBackColor = false;
            // 
            // TotalBox
            // 
            TotalBox.BackColor = Color.FromArgb(212, 222, 149);
            TotalBox.BorderStyle = BorderStyle.FixedSingle;
            TotalBox.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TotalBox.Location = new Point(556, 486);
            TotalBox.Name = "TotalBox";
            TotalBox.PlaceholderText = "Итого";
            TotalBox.Size = new Size(178, 32);
            TotalBox.TabIndex = 12;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 582);
            Controls.Add(TotalBox);
            Controls.Add(ExportButton);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(ProductsGridViewStorekep);
            Controls.Add(ExitButton);
            Controls.Add(FilterButton);
            Controls.Add(SearchBoxStorekep);
            Controls.Add(ReportsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            MouseDown += Reports_MouseDown;
            MouseMove += Reports_MouseMove;
            ((System.ComponentModel.ISupportInitialize)ProductsGridViewStorekep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportsLabel;
        private TextBox SearchBoxStorekep;
        private Button FilterButton;
        private Button ExitButton;
        private DataGridView ProductsGridViewStorekep;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Relevance;
        private DataGridViewTextBoxColumn Sale;
        private Button ExportButton;
        private TextBox TotalBox;
    }
}