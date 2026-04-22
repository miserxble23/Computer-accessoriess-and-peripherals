namespace ComputerAccessoriesApp
{
    partial class SupplieForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            BackButton = new Button();
            SendButton = new Button();
            SupplieLabel = new Label();
            FindBox = new TextBox();
            FindButton = new Button();
            BasketPanel = new Panel();
            DeleteButton = new Button();
            BasketGridView = new DataGridView();
            Namee = new DataGridViewTextBoxColumn();
            Quantityy = new DataGridViewTextBoxColumn();
            Pricee = new DataGridViewTextBoxColumn();
            BasketLabel = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            SupplieGridView = new DataGridView();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            ImportButton = new Button();
            NewCardButton = new Button();
            panel1 = new Panel();
            DateBox = new DateTimePicker();
            RelevanceBox = new TextBox();
            PurchasePriceBox = new TextBox();
            QuantityBox = new TextBox();
            AddButton = new Button();
            BasketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BasketGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SupplieGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkOliveGreen;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Candara", 12.1846151F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(771, 424);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(110, 41);
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
            SendButton.Location = new Point(11, 424);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(214, 41);
            SendButton.TabIndex = 1;
            SendButton.Text = " Оформить отправку";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // SupplieLabel
            // 
            SupplieLabel.AutoSize = true;
            SupplieLabel.Font = new Font("Candara", 22.1538467F);
            SupplieLabel.ForeColor = Color.FromArgb(61, 65, 39);
            SupplieLabel.Location = new Point(11, 9);
            SupplieLabel.Name = "SupplieLabel";
            SupplieLabel.Size = new Size(310, 45);
            SupplieLabel.TabIndex = 2;
            SupplieLabel.Text = "Поставка товаров";
            // 
            // FindBox
            // 
            FindBox.BackColor = Color.FromArgb(212, 222, 149);
            FindBox.BorderStyle = BorderStyle.FixedSingle;
            FindBox.Font = new Font("Candara", 14.1846151F);
            FindBox.Location = new Point(338, 19);
            FindBox.Name = "FindBox";
            FindBox.PlaceholderText = "  Поиск";
            FindBox.Size = new Size(420, 36);
            FindBox.TabIndex = 3;
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.DarkOliveGreen;
            FindButton.Cursor = Cursors.Hand;
            FindButton.FlatStyle = FlatStyle.Popup;
            FindButton.Font = new Font("Candara", 12.1846151F);
            FindButton.ForeColor = Color.White;
            FindButton.Location = new Point(771, 17);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(110, 41);
            FindButton.TabIndex = 4;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // BasketPanel
            // 
            BasketPanel.BackColor = Color.FromArgb(152, 159, 105);
            BasketPanel.Controls.Add(DeleteButton);
            BasketPanel.Controls.Add(BasketGridView);
            BasketPanel.Controls.Add(BasketLabel);
            BasketPanel.ImeMode = ImeMode.On;
            BasketPanel.Location = new Point(640, 75);
            BasketPanel.Name = "BasketPanel";
            BasketPanel.Size = new Size(241, 328);
            BasketPanel.TabIndex = 5;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkOliveGreen;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Candara", 11.1846151F);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(130, 289);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(88, 34);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Убрать";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // BasketGridView
            // 
            BasketGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            BasketGridView.BorderStyle = BorderStyle.None;
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
            BasketGridView.ImeMode = ImeMode.NoControl;
            BasketGridView.Location = new Point(18, 56);
            BasketGridView.Name = "BasketGridView";
            BasketGridView.RowHeadersVisible = false;
            BasketGridView.RowHeadersWidth = 56;
            BasketGridView.Size = new Size(200, 227);
            BasketGridView.TabIndex = 4;
            // 
            // Namee
            // 
            Namee.HeaderText = "Название";
            Namee.MinimumWidth = 6;
            Namee.Name = "Namee";
            Namee.Width = 80;
            // 
            // Quantityy
            // 
            Quantityy.HeaderText = "Кол-во";
            Quantityy.MinimumWidth = 7;
            Quantityy.Name = "Quantityy";
            Quantityy.Width = 64;
            // 
            // Pricee
            // 
            Pricee.HeaderText = "Цена";
            Pricee.MinimumWidth = 7;
            Pricee.Name = "Pricee";
            Pricee.Width = 57;
            // 
            // BasketLabel
            // 
            BasketLabel.AutoSize = true;
            BasketLabel.Font = new Font("Candara", 16.1538467F);
            BasketLabel.ForeColor = Color.FromArgb(61, 65, 39);
            BasketLabel.Location = new Point(3, 10);
            BasketLabel.Name = "BasketLabel";
            BasketLabel.Size = new Size(114, 33);
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
            // SupplieGridView
            // 
            SupplieGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle3.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SupplieGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SupplieGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplieGridView.Columns.AddRange(new DataGridViewColumn[] { ProductNameColumn, Category, Unit });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle4.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            SupplieGridView.DefaultCellStyle = dataGridViewCellStyle4;
            SupplieGridView.EnableHeadersVisualStyles = false;
            SupplieGridView.Location = new Point(13, 10);
            SupplieGridView.Name = "SupplieGridView";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Candara", 14F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            SupplieGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            SupplieGridView.RowHeadersVisible = false;
            SupplieGridView.RowHeadersWidth = 56;
            SupplieGridView.Size = new Size(339, 258);
            SupplieGridView.TabIndex = 6;
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
            // Unit
            // 
            Unit.DataPropertyName = "unit";
            Unit.FillWeight = 22.3751926F;
            Unit.HeaderText = "Ед. Изм.";
            Unit.MinimumWidth = 7;
            Unit.Name = "Unit";
            Unit.Width = 67;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = Color.DarkOliveGreen;
            ImportButton.Cursor = Cursors.Hand;
            ImportButton.FlatStyle = FlatStyle.Popup;
            ImportButton.Font = new Font("Candara", 12.1846151F);
            ImportButton.ForeColor = Color.White;
            ImportButton.Location = new Point(300, 424);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(162, 41);
            ImportButton.TabIndex = 7;
            ImportButton.Text = "Импорт файла";
            ImportButton.UseVisualStyleBackColor = false;
            // 
            // NewCardButton
            // 
            NewCardButton.BackColor = Color.DarkOliveGreen;
            NewCardButton.Cursor = Cursors.Hand;
            NewCardButton.FlatStyle = FlatStyle.Popup;
            NewCardButton.Font = new Font("Candara", 12.1846151F);
            NewCardButton.ForeColor = Color.White;
            NewCardButton.Location = new Point(536, 424);
            NewCardButton.Name = "NewCardButton";
            NewCardButton.Size = new Size(147, 41);
            NewCardButton.TabIndex = 8;
            NewCardButton.Text = "Новый товар";
            NewCardButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(152, 159, 105);
            panel1.Controls.Add(DateBox);
            panel1.Controls.Add(RelevanceBox);
            panel1.Controls.Add(PurchasePriceBox);
            panel1.Controls.Add(QuantityBox);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(SupplieGridView);
            panel1.ImeMode = ImeMode.On;
            panel1.Location = new Point(12, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 328);
            panel1.TabIndex = 9;
            // 
            // DateBox
            // 
            DateBox.CalendarMonthBackground = Color.FromArgb(212, 222, 149);
            DateBox.Font = new Font("Candara", 14.1846151F);
            DateBox.Location = new Point(371, 185);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(228, 36);
            DateBox.TabIndex = 14;
            // 
            // RelevanceBox
            // 
            RelevanceBox.BackColor = Color.FromArgb(212, 222, 149);
            RelevanceBox.BorderStyle = BorderStyle.FixedSingle;
            RelevanceBox.Font = new Font("Candara", 14.1846151F);
            RelevanceBox.Location = new Point(371, 125);
            RelevanceBox.Name = "RelevanceBox";
            RelevanceBox.PlaceholderText = " Актуальность";
            RelevanceBox.Size = new Size(228, 36);
            RelevanceBox.TabIndex = 12;
            // 
            // PurchasePriceBox
            // 
            PurchasePriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PurchasePriceBox.BorderStyle = BorderStyle.FixedSingle;
            PurchasePriceBox.Font = new Font("Candara", 14.1846151F);
            PurchasePriceBox.Location = new Point(371, 73);
            PurchasePriceBox.Name = "PurchasePriceBox";
            PurchasePriceBox.PlaceholderText = " Закупочная цена";
            PurchasePriceBox.Size = new Size(228, 36);
            PurchasePriceBox.TabIndex = 11;
            // 
            // QuantityBox
            // 
            QuantityBox.BackColor = Color.FromArgb(212, 222, 149);
            QuantityBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityBox.Font = new Font("Candara", 14.1846151F);
            QuantityBox.Location = new Point(371, 20);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.PlaceholderText = " Количество";
            QuantityBox.Size = new Size(228, 36);
            QuantityBox.TabIndex = 10;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkOliveGreen;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Font = new Font("Candara", 11.1846151F);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(13, 280);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 34);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить в корзину";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // SupplieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(924, 476);
            Controls.Add(panel1);
            Controls.Add(NewCardButton);
            Controls.Add(ImportButton);
            Controls.Add(BasketPanel);
            Controls.Add(FindButton);
            Controls.Add(FindBox);
            Controls.Add(SupplieLabel);
            Controls.Add(SendButton);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplieForm";
            Text = "SupplieForm";
            MouseDown += SupplieForm_MouseDown;
            MouseMove += SupplieForm_MouseMove;
            BasketPanel.ResumeLayout(false);
            BasketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BasketGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SupplieGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button SendButton;
        private Label SupplieLabel;
        private TextBox FindBox;
        private Button FindButton;
        private Panel BasketPanel;
        private Label BasketLabel;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView SupplieGridView;
        private DataGridView BasketGridView;
        private Button ImportButton;
        private Button DeleteButton;
        private Button NewCardButton;
        private Panel panel1;
        private DataGridViewTextBoxColumn Namee;
        private DataGridViewTextBoxColumn Quantityy;
        private DataGridViewTextBoxColumn Pricee;
        private TextBox PurchasePriceBox;
        private TextBox QuantityBox;
        private Button AddButton;
        private TextBox RelevanceBox;
        private DateTimePicker DateBox;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Unit;
    }
}