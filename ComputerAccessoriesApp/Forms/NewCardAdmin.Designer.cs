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
            IDLabel = new Label();
            NameLabel = new Label();
            CategoryLabel = new Label();
            StockLabel = new Label();
            UnitLabel = new Label();
            PriceLabel = new Label();
            IDBox = new TextBox();
            NameBox = new TextBox();
            CategoryBox = new TextBox();
            StockBox = new TextBox();
            UnitBox = new TextBox();
            PriceBox = new TextBox();
            DeleteButton = new Button();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // CardLabel
            // 
            CardLabel.AutoSize = true;
            CardLabel.Font = new Font("Candara", 22.1538467F);
            CardLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CardLabel.Location = new Point(241, 9);
            CardLabel.Name = "CardLabel";
            CardLabel.Size = new Size(318, 49);
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
            CancelButton.Location = new Point(651, 395);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 43);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IDLabel.ForeColor = Color.FromArgb(61, 65, 39);
            IDLabel.Location = new Point(64, 63);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(42, 36);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Candara", 16.2769222F);
            NameLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NameLabel.Location = new Point(62, 115);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(142, 37);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Название";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Candara", 16.2769222F);
            CategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CategoryLabel.Location = new Point(62, 165);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(154, 37);
            CategoryLabel.TabIndex = 5;
            CategoryLabel.Text = "Категория";
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Candara", 16.2769222F);
            StockLabel.ForeColor = Color.FromArgb(61, 65, 39);
            StockLabel.Location = new Point(62, 219);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(171, 37);
            StockLabel.TabIndex = 6;
            StockLabel.Text = "Количество";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Candara", 16.2769222F);
            UnitLabel.ForeColor = Color.FromArgb(61, 65, 39);
            UnitLabel.Location = new Point(62, 278);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(126, 37);
            UnitLabel.TabIndex = 7;
            UnitLabel.Text = "Ед. Изм.";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(64, 342);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(82, 37);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Цена";
            // 
            // IDBox
            // 
            IDBox.BackColor = Color.FromArgb(212, 222, 149);
            IDBox.BorderStyle = BorderStyle.FixedSingle;
            IDBox.Font = new Font("Candara", 14.1846151F);
            IDBox.Location = new Point(241, 64);
            IDBox.Multiline = true;
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(512, 36);
            IDBox.TabIndex = 9;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(212, 222, 149);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(241, 116);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(512, 36);
            NameBox.TabIndex = 13;
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.BorderStyle = BorderStyle.FixedSingle;
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.Location = new Point(241, 166);
            CategoryBox.Multiline = true;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.ReadOnly = true;
            CategoryBox.Size = new Size(512, 36);
            CategoryBox.TabIndex = 14;
            // 
            // StockBox
            // 
            StockBox.BackColor = Color.FromArgb(212, 222, 149);
            StockBox.BorderStyle = BorderStyle.FixedSingle;
            StockBox.Font = new Font("Candara", 14.1846151F);
            StockBox.Location = new Point(241, 219);
            StockBox.Multiline = true;
            StockBox.Name = "StockBox";
            StockBox.ReadOnly = true;
            StockBox.Size = new Size(512, 36);
            StockBox.TabIndex = 15;
            // 
            // UnitBox
            // 
            UnitBox.BackColor = Color.FromArgb(212, 222, 149);
            UnitBox.BorderStyle = BorderStyle.FixedSingle;
            UnitBox.Font = new Font("Candara", 14.1846151F);
            UnitBox.Location = new Point(241, 279);
            UnitBox.Multiline = true;
            UnitBox.Name = "UnitBox";
            UnitBox.ReadOnly = true;
            UnitBox.Size = new Size(512, 36);
            UnitBox.TabIndex = 16;
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(241, 343);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.ReadOnly = true;
            PriceBox.Size = new Size(512, 36);
            PriceBox.TabIndex = 17;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkOliveGreen;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(522, 395);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 43);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = Color.DarkOliveGreen;
            ChangeButton.Cursor = Cursors.Hand;
            ChangeButton.FlatStyle = FlatStyle.Popup;
            ChangeButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChangeButton.ForeColor = Color.White;
            ChangeButton.Location = new Point(369, 395);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(122, 43);
            ChangeButton.TabIndex = 19;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = false;
            // 
            // CardAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteButton);
            Controls.Add(PriceBox);
            Controls.Add(UnitBox);
            Controls.Add(StockBox);
            Controls.Add(CategoryBox);
            Controls.Add(NameBox);
            Controls.Add(IDBox);
            Controls.Add(PriceLabel);
            Controls.Add(UnitLabel);
            Controls.Add(StockLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(IDLabel);
            Controls.Add(CancelButton);
            Controls.Add(CardLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardAdmin";
            Text = "NewCardAdmin";
            MouseDown += CardAdmin_MouseDown;
            MouseMove += CardAdmin_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CardLabel;
        private Button CancelButton;
        private Label IDLabel;
        private Label NameLabel;
        private Label CategoryLabel;
        private Label StockLabel;
        private Label UnitLabel;
        private Label PriceLabel;
        private TextBox IDBox;
        private TextBox NameBox;
        private TextBox CategoryBox;
        private TextBox StockBox;
        private TextBox UnitBox;
        private TextBox PriceBox;
        private Button DeleteButton;
        private Button ChangeButton;
    }
}