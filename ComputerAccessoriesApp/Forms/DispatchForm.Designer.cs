namespace ComputerAccessoriesApp
{
    partial class DispatchForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BackButton = new Button();
            SendButton = new Button();
            DispatchLabel = new Label();
            FindBox = new TextBox();
            FindButton = new Button();
            BasketPanel = new Panel();
            BasketGridView = new DataGridView();
            BasketLabel = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            DispatchGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Namee = new DataGridViewTextBoxColumn();
            Quantityy = new DataGridViewTextBoxColumn();
            Pricee = new DataGridViewTextBoxColumn();
            BasketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BasketGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DispatchGridView).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkOliveGreen;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Candara", 12.1846151F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(664, 445);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(124, 43);
            BackButton.TabIndex = 0;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.DarkOliveGreen;
            SendButton.Cursor = Cursors.Hand;
            SendButton.FlatStyle = FlatStyle.Popup;
            SendButton.Font = new Font("Candara", 12.1846151F);
            SendButton.ForeColor = Color.White;
            SendButton.Location = new Point(12, 445);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(124, 43);
            SendButton.TabIndex = 1;
            SendButton.Text = "Отправить";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // DispatchLabel
            // 
            DispatchLabel.AutoSize = true;
            DispatchLabel.Font = new Font("Candara", 22.1538467F);
            DispatchLabel.ForeColor = Color.FromArgb(61, 65, 39);
            DispatchLabel.Location = new Point(12, 9);
            DispatchLabel.Name = "DispatchLabel";
            DispatchLabel.Size = new Size(335, 49);
            DispatchLabel.TabIndex = 2;
            DispatchLabel.Text = "Отгрузка товаров";
            // 
            // FindBox
            // 
            FindBox.BackColor = Color.FromArgb(212, 222, 149);
            FindBox.BorderStyle = BorderStyle.FixedSingle;
            FindBox.Font = new Font("Candara", 14.1846151F);
            FindBox.Location = new Point(353, 17);
            FindBox.Name = "FindBox";
            FindBox.PlaceholderText = "  Поиск";
            FindBox.Size = new Size(280, 39);
            FindBox.TabIndex = 3;
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.DarkOliveGreen;
            FindButton.Cursor = Cursors.Hand;
            FindButton.FlatStyle = FlatStyle.Popup;
            FindButton.Font = new Font("Candara", 12.1846151F);
            FindButton.ForeColor = Color.White;
            FindButton.Location = new Point(664, 15);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(124, 43);
            FindButton.TabIndex = 4;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // BasketPanel
            // 
            BasketPanel.BackColor = Color.FromArgb(212, 222, 149);
            BasketPanel.BorderStyle = BorderStyle.FixedSingle;
            BasketPanel.Controls.Add(BasketGridView);
            BasketPanel.Controls.Add(BasketLabel);
            BasketPanel.Location = new Point(506, 82);
            BasketPanel.Name = "BasketPanel";
            BasketPanel.Size = new Size(271, 344);
            BasketPanel.TabIndex = 5;
            // 
            // BasketGridView
            // 
            BasketGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle1.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BasketGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BasketGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BasketGridView.Columns.AddRange(new DataGridViewColumn[] { Namee, Quantityy, Pricee });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle2.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BasketGridView.DefaultCellStyle = dataGridViewCellStyle2;
            BasketGridView.EnableHeadersVisualStyles = false;
            BasketGridView.Location = new Point(20, 59);
            BasketGridView.Name = "BasketGridView";
            BasketGridView.RowHeadersVisible = false;
            BasketGridView.RowHeadersWidth = 56;
            BasketGridView.Size = new Size(225, 263);
            BasketGridView.TabIndex = 4;
            // 
            // BasketLabel
            // 
            BasketLabel.AutoSize = true;
            BasketLabel.Font = new Font("Candara", 16.1538467F);
            BasketLabel.ForeColor = Color.FromArgb(61, 65, 39);
            BasketLabel.Location = new Point(3, 10);
            BasketLabel.Name = "BasketLabel";
            BasketLabel.Size = new Size(129, 37);
            BasketLabel.TabIndex = 3;
            BasketLabel.Text = "Корзина";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // DispatchGridView
            // 
            DispatchGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle3.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DispatchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DispatchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DispatchGridView.Columns.AddRange(new DataGridViewColumn[] { ID, ProductNameColumn, Category, Quantity, Unit, Price });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle4.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DispatchGridView.DefaultCellStyle = dataGridViewCellStyle4;
            DispatchGridView.EnableHeadersVisualStyles = false;
            DispatchGridView.Location = new Point(12, 82);
            DispatchGridView.Name = "DispatchGridView";
            DispatchGridView.RowHeadersVisible = false;
            DispatchGridView.RowHeadersWidth = 56;
            DispatchGridView.Size = new Size(470, 344);
            DispatchGridView.TabIndex = 6;
            DispatchGridView.CellContentClick += DispatchGridView_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.FillWeight = 42.37726F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            ID.Width = 33;
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.DataPropertyName = "name";
            ProductNameColumn.FillWeight = 160.826859F;
            ProductNameColumn.HeaderText = "Название";
            ProductNameColumn.MinimumWidth = 7;
            ProductNameColumn.Name = "ProductNameColumn";
            ProductNameColumn.Width = 135;
            // 
            // Category
            // 
            Category.DataPropertyName = "category";
            Category.FillWeight = 329.670319F;
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 7;
            Category.Name = "Category";
            Category.Width = 135;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "stock";
            Quantity.FillWeight = 22.3751926F;
            Quantity.HeaderText = "Количество";
            Quantity.MinimumWidth = 7;
            Quantity.Name = "Quantity";
            Quantity.Width = 67;
            // 
            // Unit
            // 
            Unit.DataPropertyName = "unit";
            Unit.FillWeight = 22.3751926F;
            Unit.HeaderText = "Ед. Изм.";
            Unit.MinimumWidth = 7;
            Unit.Name = "Unit";
            Unit.Width = 67;
            // 
            // Price
            // 
            Price.DataPropertyName = "price";
            Price.FillWeight = 22.3751926F;
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 7;
            Price.Name = "Price";
            Price.Width = 67;
            // 
            // Namee
            // 
            Namee.HeaderText = "Название";
            Namee.MinimumWidth = 7;
            Namee.Name = "Namee";
            Namee.Width = 85;
            // 
            // Quantityy
            // 
            Quantityy.HeaderText = "Количество";
            Quantityy.MinimumWidth = 7;
            Quantityy.Name = "Quantityy";
            Quantityy.Width = 80;
            // 
            // Pricee
            // 
            Pricee.HeaderText = "Цена";
            Pricee.MinimumWidth = 7;
            Pricee.Name = "Pricee";
            Pricee.Width = 57;
            // 
            // DispatchForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(800, 500);
            Controls.Add(DispatchGridView);
            Controls.Add(BasketPanel);
            Controls.Add(FindButton);
            Controls.Add(FindBox);
            Controls.Add(DispatchLabel);
            Controls.Add(SendButton);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DispatchForm";
            Text = "DispatchForm";
            MouseDown += DispatchForm_MouseDown;
            MouseMove += DispatchForm_MouseMove;
            BasketPanel.ResumeLayout(false);
            BasketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BasketGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DispatchGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button SendButton;
        private Label DispatchLabel;
        private TextBox FindBox;
        private Button FindButton;
        private Panel BasketPanel;
        private Label BasketLabel;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView DispatchGridView;
        private DataGridView BasketGridView;
        private DataGridViewTextBoxColumn Namee;
        private DataGridViewTextBoxColumn Quantityy;
        private DataGridViewTextBoxColumn Pricee;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
    }
}