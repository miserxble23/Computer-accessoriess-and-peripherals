namespace ComputerAccessoriesApp.Forms
{
    partial class EditProduct
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
            EditProductLabel = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            NameLabel = new Label();
            CategoryLabel = new Label();
            UnitLabel = new Label();
            PriceLabel = new Label();
            NameBox = new TextBox();
            CategoryBox = new TextBox();
            UnitBox = new TextBox();
            PriceBox = new TextBox();
            ListCategoryButton = new Button();
            PurcharePriceLabel = new Label();
            RelevanceLabel = new Label();
            QuantityLabel = new Label();
            RelevanceBox = new TextBox();
            PurcharePriceBox = new TextBox();
            QuantityBox = new TextBox();
            SuspendLayout();
            // 
            // EditProductLabel
            // 
            EditProductLabel.AutoSize = true;
            EditProductLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditProductLabel.ForeColor = Color.FromArgb(61, 65, 39);
            EditProductLabel.Location = new Point(163, 9);
            EditProductLabel.Name = "EditProductLabel";
            EditProductLabel.Size = new Size(445, 49);
            EditProductLabel.TabIndex = 5;
            EditProductLabel.Text = "Редактирование товара";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(512, 439);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(173, 32);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Candara", 16.2769222F);
            NameLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NameLabel.Location = new Point(50, 107);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(131, 35);
            NameLabel.TabIndex = 10;
            NameLabel.Text = "Название";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Candara", 16.2769222F);
            CategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CategoryLabel.Location = new Point(50, 148);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(144, 35);
            CategoryLabel.TabIndex = 11;
            CategoryLabel.Text = "Категория";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Candara", 16.2769222F);
            UnitLabel.ForeColor = Color.FromArgb(61, 65, 39);
            UnitLabel.Location = new Point(50, 228);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(116, 35);
            UnitLabel.TabIndex = 12;
            UnitLabel.Text = "Ед. Изм.";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(50, 268);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(76, 35);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "Цена";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(212, 222, 149);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(230, 108);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(455, 34);
            NameBox.TabIndex = 14;
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.BorderStyle = BorderStyle.FixedSingle;
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.Location = new Point(230, 148);
            CategoryBox.Multiline = true;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(455, 34);
            CategoryBox.TabIndex = 15;
            // 
            // UnitBox
            // 
            UnitBox.BackColor = Color.FromArgb(212, 222, 149);
            UnitBox.BorderStyle = BorderStyle.FixedSingle;
            UnitBox.Font = new Font("Candara", 14.1846151F);
            UnitBox.Location = new Point(230, 228);
            UnitBox.Multiline = true;
            UnitBox.Name = "UnitBox";
            UnitBox.ReadOnly = true;
            UnitBox.Size = new Size(455, 34);
            UnitBox.TabIndex = 17;
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(230, 268);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(455, 34);
            PriceBox.TabIndex = 18;
            // 
            // ListCategoryButton
            // 
            ListCategoryButton.BackColor = Color.DarkOliveGreen;
            ListCategoryButton.Cursor = Cursors.Hand;
            ListCategoryButton.FlatStyle = FlatStyle.Popup;
            ListCategoryButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListCategoryButton.ForeColor = Color.White;
            ListCategoryButton.Location = new Point(273, 439);
            ListCategoryButton.Name = "ListCategoryButton";
            ListCategoryButton.Size = new Size(188, 32);
            ListCategoryButton.TabIndex = 23;
            ListCategoryButton.Text = "Список категорий";
            ListCategoryButton.UseVisualStyleBackColor = false;
            ListCategoryButton.Click += ListCategoryButton_Click;
            // 
            // PurcharePriceLabel
            // 
            PurcharePriceLabel.AutoSize = true;
            PurcharePriceLabel.Font = new Font("Candara", 16.2769222F);
            PurcharePriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PurcharePriceLabel.Location = new Point(50, 308);
            PurcharePriceLabel.Name = "PurcharePriceLabel";
            PurcharePriceLabel.Size = new Size(156, 35);
            PurcharePriceLabel.TabIndex = 33;
            PurcharePriceLabel.Text = "Закуп. цена";
            // 
            // RelevanceLabel
            // 
            RelevanceLabel.AutoSize = true;
            RelevanceLabel.Font = new Font("Candara", 16.2769222F);
            RelevanceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            RelevanceLabel.Location = new Point(50, 348);
            RelevanceLabel.Name = "RelevanceLabel";
            RelevanceLabel.Size = new Size(181, 35);
            RelevanceLabel.TabIndex = 32;
            RelevanceLabel.Text = "Актуальность";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Candara", 16.2769222F);
            QuantityLabel.ForeColor = Color.FromArgb(61, 65, 39);
            QuantityLabel.Location = new Point(50, 187);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(159, 35);
            QuantityLabel.TabIndex = 31;
            QuantityLabel.Text = "Количество";
            // 
            // RelevanceBox
            // 
            RelevanceBox.BackColor = Color.FromArgb(212, 222, 149);
            RelevanceBox.BorderStyle = BorderStyle.FixedSingle;
            RelevanceBox.Font = new Font("Candara", 14.1846151F);
            RelevanceBox.Location = new Point(230, 348);
            RelevanceBox.Multiline = true;
            RelevanceBox.Name = "RelevanceBox";
            RelevanceBox.Size = new Size(455, 34);
            RelevanceBox.TabIndex = 36;
            // 
            // PurcharePriceBox
            // 
            PurcharePriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PurcharePriceBox.BorderStyle = BorderStyle.FixedSingle;
            PurcharePriceBox.Font = new Font("Candara", 14.1846151F);
            PurcharePriceBox.Location = new Point(230, 308);
            PurcharePriceBox.Multiline = true;
            PurcharePriceBox.Name = "PurcharePriceBox";
            PurcharePriceBox.ReadOnly = true;
            PurcharePriceBox.Size = new Size(455, 34);
            PurcharePriceBox.TabIndex = 35;
            // 
            // QuantityBox
            // 
            QuantityBox.BackColor = Color.FromArgb(212, 222, 149);
            QuantityBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityBox.Font = new Font("Candara", 14.1846151F);
            QuantityBox.Location = new Point(230, 188);
            QuantityBox.Multiline = true;
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(455, 34);
            QuantityBox.TabIndex = 34;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 505);
            Controls.Add(RelevanceBox);
            Controls.Add(PurcharePriceBox);
            Controls.Add(QuantityBox);
            Controls.Add(PurcharePriceLabel);
            Controls.Add(RelevanceLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(ListCategoryButton);
            Controls.Add(PriceBox);
            Controls.Add(UnitBox);
            Controls.Add(CategoryBox);
            Controls.Add(NameBox);
            Controls.Add(PriceLabel);
            Controls.Add(UnitLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(EditProductLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProduct";
            Text = "EditCategory";
            MouseDown += EditProduct_MouseDown;
            MouseMove += EditProduct_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditProductLabel;
        private Button CancelButton;
        private Button SaveButton;
        private Label NameLabel;
        private Label CategoryLabel;
        private Label UnitLabel;
        private Label PriceLabel;
        private TextBox NameBox;
        private TextBox CategoryBox;
        private TextBox UnitBox;
        private TextBox PriceBox;
        private Button ListCategoryButton;
        private Label PurcharePriceLabel;
        private Label RelevanceLabel;
        private Label QuantityLabel;
        private TextBox RelevanceBox;
        private TextBox PurcharePriceBox;
        private TextBox QuantityBox;
    }
}