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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            BackButton = new Button();
            SendButton = new Button();
            DispatchLabel = new Label();
            FindBox = new TextBox();
            FindButton = new Button();
            BasketPanel = new Panel();
            textBoxresult = new TextBox();
            BasketGridView = new DataGridView();
            Namee = new DataGridViewTextBoxColumn();
            Quantityy = new DataGridViewTextBoxColumn();
            Pricee = new DataGridViewTextBoxColumn();
            BasketLabel = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            DispatchGridView = new DataGridView();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            buttonforcheck = new Button();
            buttonfornewbuyers = new Button();
            buttonforlogistic = new Button();
            textBoxforbuyers = new TextBox();
            textBoxregionf = new TextBox();
            textBoxcurrencyf = new TextBox();
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
            BackButton.Location = new Point(702, 630);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(126, 36);
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
            SendButton.Location = new Point(11, 631);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(139, 36);
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
            DispatchLabel.Location = new Point(11, 9);
            DispatchLabel.Name = "DispatchLabel";
            DispatchLabel.Size = new Size(307, 45);
            DispatchLabel.TabIndex = 2;
            DispatchLabel.Text = "Отгрузка товаров";
            // 
            // FindBox
            // 
            FindBox.BackColor = Color.FromArgb(212, 222, 149);
            FindBox.BorderStyle = BorderStyle.FixedSingle;
            FindBox.Font = new Font("Candara", 14.1846151F);
            FindBox.Location = new Point(324, 18);
            FindBox.Name = "FindBox";
            FindBox.PlaceholderText = "  Поиск";
            FindBox.Size = new Size(321, 36);
            FindBox.TabIndex = 3;
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.DarkOliveGreen;
            FindButton.Cursor = Cursors.Hand;
            FindButton.FlatStyle = FlatStyle.Popup;
            FindButton.Font = new Font("Candara", 12.1846151F);
            FindButton.ForeColor = Color.White;
            FindButton.Location = new Point(669, 17);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(159, 37);
            FindButton.TabIndex = 4;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // BasketPanel
            // 
            BasketPanel.BackColor = Color.FromArgb(212, 222, 149);
            BasketPanel.BorderStyle = BorderStyle.FixedSingle;
            BasketPanel.Controls.Add(textBoxresult);
            BasketPanel.Controls.Add(BasketGridView);
            BasketPanel.Controls.Add(BasketLabel);
            BasketPanel.Location = new Point(538, 78);
            BasketPanel.Name = "BasketPanel";
            BasketPanel.Size = new Size(290, 449);
            BasketPanel.TabIndex = 5;
            // 
            // textBoxresult
            // 
            textBoxresult.BackColor = Color.DarkOliveGreen;
            textBoxresult.BorderStyle = BorderStyle.FixedSingle;
            textBoxresult.Font = new Font("Candara", 13.8F);
            textBoxresult.ForeColor = Color.White;
            textBoxresult.Location = new Point(18, 381);
            textBoxresult.Name = "textBoxresult";
            textBoxresult.Size = new Size(222, 36);
            textBoxresult.TabIndex = 13;
            textBoxresult.Text = "Итог:";
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
            BasketGridView.Location = new Point(18, 56);
            BasketGridView.Name = "BasketGridView";
            BasketGridView.RowHeadersVisible = false;
            BasketGridView.RowHeadersWidth = 56;
            BasketGridView.Size = new Size(222, 308);
            BasketGridView.TabIndex = 4;
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
            Quantityy.HeaderText = "Кол-во";
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
            // DispatchGridView
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DispatchGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            DispatchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DispatchGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DispatchGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle4.Font = new Font("Candara", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DispatchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DispatchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DispatchGridView.Columns.AddRange(new DataGridViewColumn[] { ProductNameColumn, Category, Quantity, Unit, Price });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DispatchGridView.DefaultCellStyle = dataGridViewCellStyle5;
            DispatchGridView.EnableHeadersVisualStyles = false;
            DispatchGridView.Location = new Point(11, 78);
            DispatchGridView.Name = "DispatchGridView";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DispatchGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DispatchGridView.RowHeadersVisible = false;
            DispatchGridView.RowHeadersWidth = 56;
            DispatchGridView.Size = new Size(508, 449);
            DispatchGridView.TabIndex = 6;
            DispatchGridView.CellContentClick += DispatchGridView_CellContentClick;
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
            Category.Width = 147;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "stock";
            Quantity.FillWeight = 22.3751926F;
            Quantity.HeaderText = "Кол-во";
            Quantity.MinimumWidth = 7;
            Quantity.Name = "Quantity";
            Quantity.Width = 109;
            // 
            // Unit
            // 
            Unit.DataPropertyName = "unit";
            Unit.FillWeight = 22.3751926F;
            Unit.HeaderText = "Ед. Изм.";
            Unit.MinimumWidth = 7;
            Unit.Name = "Unit";
            Unit.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "price";
            Price.FillWeight = 22.3751926F;
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 7;
            Price.Name = "Price";
            Price.Width = 91;
            // 
            // buttonforcheck
            // 
            buttonforcheck.BackColor = Color.DarkOliveGreen;
            buttonforcheck.FlatStyle = FlatStyle.Popup;
            buttonforcheck.Font = new Font("Candara", 12.1846151F);
            buttonforcheck.ForeColor = Color.White;
            buttonforcheck.Location = new Point(75, 553);
            buttonforcheck.Name = "buttonforcheck";
            buttonforcheck.Size = new Size(138, 37);
            buttonforcheck.TabIndex = 7;
            buttonforcheck.Text = "Проверка";
            buttonforcheck.UseVisualStyleBackColor = false;
            buttonforcheck.Click += buttonforcheck_Click;
            // 
            // buttonfornewbuyers
            // 
            buttonfornewbuyers.BackColor = Color.DarkOliveGreen;
            buttonfornewbuyers.FlatStyle = FlatStyle.Popup;
            buttonfornewbuyers.Font = new Font("Candara", 12.1846151F);
            buttonfornewbuyers.ForeColor = Color.White;
            buttonfornewbuyers.Location = new Point(246, 553);
            buttonfornewbuyers.Name = "buttonfornewbuyers";
            buttonfornewbuyers.Size = new Size(212, 37);
            buttonfornewbuyers.TabIndex = 8;
            buttonfornewbuyers.Text = "Новый покупатель";
            buttonfornewbuyers.UseVisualStyleBackColor = false;
            buttonfornewbuyers.Click += buttonfornewbuyers_Click;
            // 
            // buttonforlogistic
            // 
            buttonforlogistic.BackColor = Color.DarkOliveGreen;
            buttonforlogistic.FlatStyle = FlatStyle.Popup;
            buttonforlogistic.Font = new Font("Candara", 12.1846151F);
            buttonforlogistic.ForeColor = Color.White;
            buttonforlogistic.Location = new Point(491, 553);
            buttonforlogistic.Name = "buttonforlogistic";
            buttonforlogistic.Size = new Size(141, 37);
            buttonforlogistic.TabIndex = 9;
            buttonforlogistic.Text = "Логистика";
            buttonforlogistic.UseVisualStyleBackColor = false;
            // 
            // textBoxforbuyers
            // 
            textBoxforbuyers.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforbuyers.BorderStyle = BorderStyle.FixedSingle;
            textBoxforbuyers.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxforbuyers.Location = new Point(167, 632);
            textBoxforbuyers.Name = "textBoxforbuyers";
            textBoxforbuyers.PlaceholderText = "Покупатель:";
            textBoxforbuyers.ReadOnly = true;
            textBoxforbuyers.Size = new Size(151, 36);
            textBoxforbuyers.TabIndex = 10;
            // 
            // textBoxregionf
            // 
            textBoxregionf.BackColor = Color.FromArgb(212, 222, 149);
            textBoxregionf.BorderStyle = BorderStyle.FixedSingle;
            textBoxregionf.Font = new Font("Candara", 13.8F);
            textBoxregionf.Location = new Point(352, 631);
            textBoxregionf.Name = "textBoxregionf";
            textBoxregionf.PlaceholderText = "Регион:";
            textBoxregionf.ReadOnly = true;
            textBoxregionf.Size = new Size(151, 36);
            textBoxregionf.TabIndex = 11;
            // 
            // textBoxcurrencyf
            // 
            textBoxcurrencyf.BackColor = Color.FromArgb(212, 222, 149);
            textBoxcurrencyf.BorderStyle = BorderStyle.FixedSingle;
            textBoxcurrencyf.Font = new Font("Candara", 13.8F);
            textBoxcurrencyf.Location = new Point(529, 632);
            textBoxcurrencyf.Name = "textBoxcurrencyf";
            textBoxcurrencyf.PlaceholderText = "Валюта:";
            textBoxcurrencyf.ReadOnly = true;
            textBoxcurrencyf.Size = new Size(151, 36);
            textBoxcurrencyf.TabIndex = 12;
            // 
            // DispatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(876, 725);
            Controls.Add(textBoxcurrencyf);
            Controls.Add(textBoxregionf);
            Controls.Add(textBoxforbuyers);
            Controls.Add(buttonforlogistic);
            Controls.Add(buttonfornewbuyers);
            Controls.Add(buttonforcheck);
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
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
        private Button buttonforcheck;
        private Button buttonfornewbuyers;
        private Button buttonforlogistic;
        private TextBox textBoxforbuyers;
        private TextBox textBoxregionf;
        private TextBox textBoxcurrencyf;
        private TextBox textBoxresult;
    }
}