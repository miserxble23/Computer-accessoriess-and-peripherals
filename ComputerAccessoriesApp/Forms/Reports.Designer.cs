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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ReportsLabel = new Label();
            FilterBox = new TextBox();
            FilterButton = new Button();
            ExitButton = new Button();
            ReportsGridView = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            PurchasePrice = new DataGridViewTextBoxColumn();
            Impact = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            ExportButton = new Button();
            TotalBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ReportsGridView).BeginInit();
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
            // FilterBox
            // 
            FilterBox.BackColor = Color.FromArgb(212, 222, 149);
            FilterBox.BorderStyle = BorderStyle.FixedSingle;
            FilterBox.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FilterBox.Location = new Point(451, 89);
            FilterBox.Name = "FilterBox";
            FilterBox.PlaceholderText = "  Покупатель";
            FilterBox.Size = new Size(178, 32);
            FilterBox.TabIndex = 3;
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
            // ReportsGridView
            // 
            ReportsGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            ReportsGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle3.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ReportsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ReportsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsGridView.Columns.AddRange(new DataGridViewColumn[] { Date, Customer, product, Quantity, Price, PurchasePrice, Impact });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle4.Font = new Font("Candara", 10.1846151F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ReportsGridView.DefaultCellStyle = dataGridViewCellStyle4;
            ReportsGridView.EnableHeadersVisualStyles = false;
            ReportsGridView.Location = new Point(12, 144);
            ReportsGridView.Name = "ReportsGridView";
            ReportsGridView.RowHeadersVisible = false;
            ReportsGridView.RowHeadersWidth = 56;
            ReportsGridView.Size = new Size(722, 318);
            ReportsGridView.TabIndex = 7;
            // 
            // Date
            // 
            Date.DataPropertyName = "date";
            Date.FillWeight = 112F;
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 7;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 146;
            // 
            // Customer
            // 
            Customer.DataPropertyName = "customer";
            Customer.FillWeight = 112F;
            Customer.HeaderText = "Покупатель";
            Customer.MinimumWidth = 7;
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.Width = 143;
            // 
            // product
            // 
            product.DataPropertyName = "product_id";
            product.FillWeight = 112F;
            product.HeaderText = "Товар";
            product.MinimumWidth = 7;
            product.Name = "product";
            product.ReadOnly = true;
            product.Width = 123;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "quantity";
            Quantity.FillWeight = 112F;
            Quantity.HeaderText = "Кол-во";
            Quantity.MinimumWidth = 7;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 123;
            // 
            // Price
            // 
            Price.DataPropertyName = "saleprice";
            Price.FillWeight = 112F;
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 7;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 123;
            // 
            // PurchasePrice
            // 
            PurchasePrice.DataPropertyName = "purchaseprice";
            PurchasePrice.FillWeight = 112F;
            PurchasePrice.HeaderText = "Закуп. цена";
            PurchasePrice.MinimumWidth = 7;
            PurchasePrice.Name = "PurchasePrice";
            PurchasePrice.Width = 123;
            // 
            // Impact
            // 
            Impact.DataPropertyName = "impactsum";
            Impact.HeaderText = "Прибыль";
            Impact.MinimumWidth = 6;
            Impact.Name = "Impact";
            Impact.Width = 125;
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
            Controls.Add(ReportsGridView);
            Controls.Add(ExitButton);
            Controls.Add(FilterButton);
            Controls.Add(FilterBox);
            Controls.Add(ReportsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            MouseDown += Reports_MouseDown;
            MouseMove += Reports_MouseMove;
            ((System.ComponentModel.ISupportInitialize)ReportsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportsLabel;
        private TextBox FilterBox;
        private Button FilterButton;
        private Button ExitButton;
        private DataGridView ReportsGridView;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button ExportButton;
        private TextBox TotalBox;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn PurchasePrice;
        private DataGridViewTextBoxColumn Impact;
    }
}