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
            PriceLabel = new Label();
            NameBox = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            ListCategoryButton = new Button();
            PriceBox = new TextBox();
            PurcharePriceLabel = new Label();
            CategoryBox = new ComboBox();
            SuspendLayout();
            // 
            // CreateProductLabel
            // 
            CreateProductLabel.AutoSize = true;
            CreateProductLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateProductLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CreateProductLabel.Location = new Point(235, 9);
            CreateProductLabel.Name = "CreateProductLabel";
            CreateProductLabel.Size = new Size(248, 49);
            CreateProductLabel.TabIndex = 6;
            CreateProductLabel.Text = "Новый товар";
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
            CategoryLabel.Location = new Point(50, 146);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(144, 35);
            CategoryLabel.TabIndex = 12;
            CategoryLabel.Text = "Категория";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(50, 210);
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
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkOliveGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(50, 316);
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
            CancelButton.Location = new Point(498, 316);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(192, 32);
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
            ListCategoryButton.Location = new Point(262, 316);
            ListCategoryButton.Name = "ListCategoryButton";
            ListCategoryButton.Size = new Size(192, 32);
            ListCategoryButton.TabIndex = 22;
            ListCategoryButton.Text = "Список категорий";
            ListCategoryButton.UseVisualStyleBackColor = false;
            ListCategoryButton.Click += ListCategoryButton_Click;
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(235, 211);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.PlaceholderText = "  Введите цену";
            PriceBox.Size = new Size(455, 34);
            PriceBox.TabIndex = 26;
            // 
            // PurcharePriceLabel
            // 
            PurcharePriceLabel.AutoSize = true;
            PurcharePriceLabel.Font = new Font("Candara", 16.2769222F);
            PurcharePriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PurcharePriceLabel.Location = new Point(50, 297);
            PurcharePriceLabel.Name = "PurcharePriceLabel";
            PurcharePriceLabel.Size = new Size(0, 35);
            PurcharePriceLabel.TabIndex = 30;
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.ForeColor = Color.DimGray;
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Location = new Point(235, 146);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(455, 37);
            CategoryBox.TabIndex = 31;
            CategoryBox.Text = "Выберите категорию";
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 388);
            Controls.Add(CategoryBox);
            Controls.Add(PurcharePriceLabel);
            Controls.Add(PriceBox);
            Controls.Add(ListCategoryButton);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(NameBox);
            Controls.Add(PriceLabel);
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
        private Label PriceLabel;
        private TextBox NameBox;
        private Button SaveButton;
        private Button CancelButton;
        private Button ListCategoryButton;
        private TextBox PriceBox;
        private Label PurcharePriceLabel;
        private ComboBox CategoryBox;
    }
}