namespace ComputerAccessoriesApp
{
    partial class CardAdmin
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
            CardLabel = new Label();
            CancelButton = new Button();
            DeleteButton = new Button();
            ChangeButton = new Button();
            NameLabel = new Label();
            NameBox = new TextBox();
            QuantityLabel = new Label();
            QuantityBox = new TextBox();
            CategoryLabel = new Label();
            PriceLabel = new Label();
            PriceBox = new TextBox();
            PurchasePriceBox = new TextBox();
            PurchasePriceLabel = new Label();
            RelevanceBox = new TextBox();
            RelevanceLabel = new Label();
            CategoryBox = new TextBox();
            UnitBox = new TextBox();
            UnitLabel = new Label();
            SuspendLayout();
            // 
            // CardLabel
            // 
            CardLabel.AutoSize = true;
            CardLabel.Font = new Font("Candara", 22.1538467F);
            CardLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CardLabel.Location = new Point(205, 9);
            CardLabel.Name = "CardLabel";
            CardLabel.Size = new Size(291, 45);
            CardLabel.TabIndex = 1;
            CardLabel.Text = "Карточка товара";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(592, 358);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(91, 41);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkOliveGreen;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(479, 358);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 41);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = Color.DarkOliveGreen;
            ChangeButton.Cursor = Cursors.Hand;
            ChangeButton.FlatStyle = FlatStyle.Popup;
            ChangeButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeButton.ForeColor = Color.White;
            ChangeButton.Location = new Point(349, 358);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(114, 41);
            ChangeButton.TabIndex = 19;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Candara", 16.2769222F);
            NameLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NameLabel.Location = new Point(35, 60);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(131, 35);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Название";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(212, 222, 149);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(228, 60);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(455, 34);
            NameBox.TabIndex = 13;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Candara", 16.2769222F);
            QuantityLabel.ForeColor = Color.FromArgb(61, 65, 39);
            QuantityLabel.Location = new Point(35, 140);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(159, 35);
            QuantityLabel.TabIndex = 23;
            QuantityLabel.Text = "Количество";
            // 
            // QuantityBox
            // 
            QuantityBox.BackColor = Color.FromArgb(212, 222, 149);
            QuantityBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityBox.Font = new Font("Candara", 14.1846151F);
            QuantityBox.Location = new Point(228, 141);
            QuantityBox.Multiline = true;
            QuantityBox.Name = "QuantityBox";
            QuantityBox.ReadOnly = true;
            QuantityBox.Size = new Size(455, 34);
            QuantityBox.TabIndex = 24;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Candara", 16.2769222F);
            CategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CategoryLabel.Location = new Point(35, 100);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(144, 35);
            CategoryLabel.TabIndex = 5;
            CategoryLabel.Text = "Категория";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(35, 222);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(76, 35);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Цена";
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(228, 222);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.ReadOnly = true;
            PriceBox.Size = new Size(455, 34);
            PriceBox.TabIndex = 17;
            // 
            // PurchasePriceBox
            // 
            PurchasePriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PurchasePriceBox.BorderStyle = BorderStyle.FixedSingle;
            PurchasePriceBox.Font = new Font("Candara", 14.1846151F);
            PurchasePriceBox.Location = new Point(228, 262);
            PurchasePriceBox.Multiline = true;
            PurchasePriceBox.Name = "PurchasePriceBox";
            PurchasePriceBox.ReadOnly = true;
            PurchasePriceBox.Size = new Size(455, 34);
            PurchasePriceBox.TabIndex = 26;
            // 
            // PurchasePriceLabel
            // 
            PurchasePriceLabel.AutoSize = true;
            PurchasePriceLabel.Font = new Font("Candara", 16.2769222F);
            PurchasePriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PurchasePriceLabel.Location = new Point(35, 262);
            PurchasePriceLabel.Name = "PurchasePriceLabel";
            PurchasePriceLabel.Size = new Size(156, 35);
            PurchasePriceLabel.TabIndex = 25;
            PurchasePriceLabel.Text = "Закуп. цена";
            // 
            // RelevanceBox
            // 
            RelevanceBox.BackColor = Color.FromArgb(212, 222, 149);
            RelevanceBox.BorderStyle = BorderStyle.FixedSingle;
            RelevanceBox.Font = new Font("Candara", 14.1846151F);
            RelevanceBox.Location = new Point(228, 302);
            RelevanceBox.Multiline = true;
            RelevanceBox.Name = "RelevanceBox";
            RelevanceBox.ReadOnly = true;
            RelevanceBox.Size = new Size(455, 34);
            RelevanceBox.TabIndex = 28;
            // 
            // RelevanceLabel
            // 
            RelevanceLabel.AutoSize = true;
            RelevanceLabel.Font = new Font("Candara", 16.2769222F);
            RelevanceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            RelevanceLabel.Location = new Point(35, 301);
            RelevanceLabel.Name = "RelevanceLabel";
            RelevanceLabel.Size = new Size(196, 35);
            RelevanceLabel.TabIndex = 27;
            RelevanceLabel.Text = "Срок годности";
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.BorderStyle = BorderStyle.FixedSingle;
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.Location = new Point(228, 100);
            CategoryBox.Multiline = true;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.ReadOnly = true;
            CategoryBox.Size = new Size(455, 34);
            CategoryBox.TabIndex = 29;
            // 
            // UnitBox
            // 
            UnitBox.BackColor = Color.FromArgb(212, 222, 149);
            UnitBox.BorderStyle = BorderStyle.FixedSingle;
            UnitBox.Font = new Font("Candara", 14.1846151F);
            UnitBox.Location = new Point(228, 182);
            UnitBox.Multiline = true;
            UnitBox.Name = "UnitBox";
            UnitBox.ReadOnly = true;
            UnitBox.Size = new Size(455, 34);
            UnitBox.TabIndex = 31;
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Candara", 16.2769222F);
            UnitLabel.ForeColor = Color.FromArgb(61, 65, 39);
            UnitLabel.Location = new Point(35, 181);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(112, 35);
            UnitLabel.TabIndex = 30;
            UnitLabel.Text = "Ед. изм.";
            // 
            // CardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(711, 429);
            Controls.Add(UnitBox);
            Controls.Add(UnitLabel);
            Controls.Add(CategoryBox);
            Controls.Add(RelevanceBox);
            Controls.Add(RelevanceLabel);
            Controls.Add(PurchasePriceBox);
            Controls.Add(PurchasePriceLabel);
            Controls.Add(QuantityBox);
            Controls.Add(QuantityLabel);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteButton);
            Controls.Add(PriceBox);
            Controls.Add(NameBox);
            Controls.Add(PriceLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(CancelButton);
            Controls.Add(CardLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardAdmin";
            Text = "NewCardAdmin";
            VisibleChanged += CardAdmin_VisibleChanged;
            MouseDown += CardAdmin_MouseDown;
            MouseMove += CardAdmin_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CardLabel;
        private Button CancelButton;
        private Label NameLabel;
        private Label CategoryLabel;
        private Label PriceLabel;
        private TextBox NameBox;
        private TextBox PriceBox;
        private Button DeleteButton;
        private Button ChangeButton;
        private TextBox QuantityBox;
        private Label QuantityLabel;
        private TextBox PurchasePriceBox;
        private Label PurchasePriceLabel;
        private TextBox RelevanceBox;
        private Label RelevanceLabel;
        private TextBox CategoryBox;
        private TextBox UnitBox;
        private Label UnitLabel;
    }
}