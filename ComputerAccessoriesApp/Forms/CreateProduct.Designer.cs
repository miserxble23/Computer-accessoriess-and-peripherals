namespace ComputerAccessoriesApp.Forms
{
    partial class CreateProduct
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
            CreateProductLabel = new Label();
            NameLabel = new Label();
            CategoryLabel = new Label();
            UnitLabel = new Label();
            PriceLabel = new Label();
            NameBox = new TextBox();
            CategoryBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            ListCategoryButton = new Button();
            QuantityLabel = new Label();
            QuantityBox = new TextBox();
            PriceBox = new TextBox();
            UnitBox = new TextBox();
            RelevanceBox = new TextBox();
            PurchasePriceBox = new TextBox();
            RelevanceLabel = new Label();
            PurcharePriceLabel = new Label();
            SuspendLayout();
            // 
            // CreateProductLabel
            // 
            CreateProductLabel.AutoSize = true;
            CreateProductLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateProductLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CreateProductLabel.Location = new Point(221, 9);
            CreateProductLabel.Name = "CreateProductLabel";
            CreateProductLabel.Size = new Size(300, 49);
            CreateProductLabel.TabIndex = 6;
            CreateProductLabel.Text = "Новая карточка";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Candara", 16.2769222F);
            NameLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NameLabel.Location = new Point(50, 72);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(131, 35);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Название";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Candara", 16.2769222F);
            CategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CategoryLabel.Location = new Point(50, 112);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(144, 35);
            CategoryLabel.TabIndex = 12;
            CategoryLabel.Text = "Категория";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Candara", 16.2769222F);
            UnitLabel.ForeColor = Color.FromArgb(61, 65, 39);
            UnitLabel.Location = new Point(50, 192);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(116, 35);
            UnitLabel.TabIndex = 13;
            UnitLabel.Text = "Ед. Изм.";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(50, 232);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(76, 35);
            PriceLabel.TabIndex = 14;
            PriceLabel.Text = "Цена";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(212, 222, 149);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(235, 74);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "  Введите название";
            NameBox.Size = new Size(455, 34);
            NameBox.TabIndex = 15;
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.BorderStyle = BorderStyle.FixedSingle;
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.Location = new Point(235, 114);
            CategoryBox.Multiline = true;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.PlaceholderText = "  Введите категорию";
            CategoryBox.Size = new Size(455, 34);
            CategoryBox.TabIndex = 16;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkOliveGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(50, 439);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(173, 32);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(517, 439);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(173, 32);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ListCategoryButton
            // 
            ListCategoryButton.BackColor = Color.DarkOliveGreen;
            ListCategoryButton.Cursor = Cursors.Hand;
            ListCategoryButton.FlatStyle = FlatStyle.Popup;
            ListCategoryButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListCategoryButton.ForeColor = Color.White;
            ListCategoryButton.Location = new Point(275, 439);
            ListCategoryButton.Name = "ListCategoryButton";
            ListCategoryButton.Size = new Size(192, 32);
            ListCategoryButton.TabIndex = 22;
            ListCategoryButton.Text = "Список категорий";
            ListCategoryButton.UseVisualStyleBackColor = false;
            ListCategoryButton.Click += ListCategoryButton_Click;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Candara", 16.2769222F);
            QuantityLabel.ForeColor = Color.FromArgb(61, 65, 39);
            QuantityLabel.Location = new Point(50, 154);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(159, 35);
            QuantityLabel.TabIndex = 23;
            QuantityLabel.Text = "Количество";
            // 
            // QuantityBox
            // 
            QuantityBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
            QuantityBox.BackColor = Color.FromArgb(212, 222, 149);
            QuantityBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityBox.Font = new Font("Candara", 14.1846151F);
            QuantityBox.Location = new Point(235, 154);
            QuantityBox.Multiline = true;
            QuantityBox.Name = "QuantityBox";
            QuantityBox.PlaceholderText = "  Введите количество товара";
            QuantityBox.Size = new Size(455, 34);
            QuantityBox.TabIndex = 24;
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(235, 234);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.PlaceholderText = "  Введите цену";
            PriceBox.Size = new Size(455, 34);
            PriceBox.TabIndex = 26;
            PriceBox.TextChanged += this.PriceBox_TextChanged;
            //
            // UnitBox
            // 
            UnitBox.BackColor = Color.FromArgb(212, 222, 149);
            UnitBox.BorderStyle = BorderStyle.FixedSingle;
            UnitBox.Font = new Font("Candara", 14.1846151F);
            UnitBox.Location = new Point(235, 194);
            UnitBox.Multiline = true;
            UnitBox.Name = "UnitBox";
            UnitBox.PlaceholderText = "  Выберите единицу измерения";
            UnitBox.ReadOnly = true;
            UnitBox.Size = new Size(455, 34);
            UnitBox.TabIndex = 25;
            UnitBox.TextChanged += UnitBox_TextChanged;
            // 
            // RelevanceBox
            // 
            RelevanceBox.BackColor = Color.FromArgb(212, 222, 149);
            RelevanceBox.BorderStyle = BorderStyle.FixedSingle;
            RelevanceBox.Font = new Font("Candara", 14.1846151F);
            RelevanceBox.Location = new Point(235, 314);
            RelevanceBox.Multiline = true;
            RelevanceBox.Name = "RelevanceBox";
            RelevanceBox.PlaceholderText = "  Введите срок годности";
            RelevanceBox.Size = new Size(455, 34);
            RelevanceBox.TabIndex = 28;
            RelevanceBox.TextChanged += this.RelevanceBox_TextChanged;
            // 
            // PurchasePriceBox
            // 
            PurchasePriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PurchasePriceBox.BorderStyle = BorderStyle.FixedSingle;
            PurchasePriceBox.Font = new Font("Candara", 14.1846151F);
            PurchasePriceBox.Location = new Point(235, 274);
            PurchasePriceBox.Multiline = true;
            PurchasePriceBox.Name = "PurchasePriceBox";
            PurchasePriceBox.PlaceholderText = "  Введите закупочную цену";
            PurchasePriceBox.ReadOnly = true;
            PurchasePriceBox.Size = new Size(455, 34);
            PurchasePriceBox.TabIndex = 27;
            PurchasePriceBox.TextChanged += this.PurchasePriceBox_TextChanged;
            // 
            // RelevanceLabel
            // 
            RelevanceLabel.AutoSize = true;
            RelevanceLabel.Font = new Font("Candara", 16.2769222F);
            RelevanceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            RelevanceLabel.Location = new Point(50, 307);
            RelevanceLabel.Name = "RelevanceLabel";
            RelevanceLabel.Size = new Size(181, 35);
            RelevanceLabel.TabIndex = 29;
            RelevanceLabel.Text = "Актуальность";
            // 
            // PurcharePriceLabel
            // 
            PurcharePriceLabel.AutoSize = true;
            PurcharePriceLabel.Font = new Font("Candara", 16.2769222F);
            PurcharePriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PurcharePriceLabel.Location = new Point(50, 272);
            PurcharePriceLabel.Name = "PurcharePriceLabel";
            PurcharePriceLabel.Size = new Size(156, 35);
            PurcharePriceLabel.TabIndex = 30;
            PurcharePriceLabel.Text = "Закуп. цена";
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 505);
            Controls.Add(PurcharePriceLabel);
            Controls.Add(RelevanceLabel);
            Controls.Add(RelevanceBox);
            Controls.Add(PurchasePriceBox);
            Controls.Add(PriceBox);
            Controls.Add(UnitBox);
            Controls.Add(QuantityBox);
            Controls.Add(QuantityLabel);
            Controls.Add(ListCategoryButton);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(CategoryBox);
            Controls.Add(NameBox);
            Controls.Add(PriceLabel);
            Controls.Add(UnitLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(CreateProductLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateProduct";
            Text = "CreateProdusct";
            MouseDown += CreateProduct_MouseDown;
            MouseMove += CreateProduct_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateProductLabel;
        private Label NameLabel;
        private Label CategoryLabel;
        private Label UnitLabel;
        private Label PriceLabel;
        private TextBox NameBox;
        private TextBox CategoryBox;
        private Button SaveButton;
        private Button CancelButton;
        private Button ListCategoryButton;
        private Label QuantityLabel;
        private TextBox QuantityBox;
        private TextBox PriceBox;
        private TextBox UnitBox;
        private TextBox RelevanceBox;
        private TextBox PurchasePriceBox;
        private Label RelevanceLabel;
        private Label PurcharePriceLabel;
    }
}