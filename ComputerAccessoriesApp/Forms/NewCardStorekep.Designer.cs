namespace ComputerAccessoriesApp
{
    partial class CardStorekep
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
            NameLabel = new Label();
            NameBox = new TextBox();
            CategoryLabel = new Label();
            CategoryBox = new TextBox();
            QuantityLabel = new Label();
            QuantityBox = new TextBox();
            UnitLabel = new Label();
            UnitBox = new TextBox();
            PriceLabel = new Label();
            PriceBox = new TextBox();
            RelevanceLabel = new Label();
            RelevanceBox = new TextBox();
            SuspendLayout();
            // 
            // CardLabel
            // 
            CardLabel.AutoSize = true;
            CardLabel.Font = new Font("Candara", 22.1538467F);
            CardLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CardLabel.Location = new Point(214, 9);
            CardLabel.Name = "CardLabel";
            CardLabel.Size = new Size(291, 45);
            CardLabel.TabIndex = 0;
            CardLabel.Text = "Карточка товара";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(579, 376);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(91, 41);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Candara", 16.2769222F);
            NameLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NameLabel.Location = new Point(37, 62);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(131, 35);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Название";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(212, 222, 149);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(213, 63);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(455, 34);
            NameBox.TabIndex = 12;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Candara", 16.2769222F);
            CategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CategoryLabel.Location = new Point(38, 102);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(144, 35);
            CategoryLabel.TabIndex = 4;
            CategoryLabel.Text = "Категория";
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.BorderStyle = BorderStyle.FixedSingle;
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.Location = new Point(213, 103);
            CategoryBox.Multiline = true;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.ReadOnly = true;
            CategoryBox.Size = new Size(455, 34);
            CategoryBox.TabIndex = 11;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Candara", 16.2769222F);
            QuantityLabel.ForeColor = Color.FromArgb(61, 65, 39);
            QuantityLabel.Location = new Point(38, 142);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(159, 35);
            QuantityLabel.TabIndex = 14;
            QuantityLabel.Text = "Количество";
            // 
            // QuantityBox
            // 
            QuantityBox.BackColor = Color.FromArgb(212, 222, 149);
            QuantityBox.BorderStyle = BorderStyle.FixedSingle;
            QuantityBox.Font = new Font("Candara", 14.1846151F);
            QuantityBox.Location = new Point(214, 143);
            QuantityBox.Multiline = true;
            QuantityBox.Name = "QuantityBox";
            QuantityBox.ReadOnly = true;
            QuantityBox.Size = new Size(455, 34);
            QuantityBox.TabIndex = 18;
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Candara", 16.2769222F);
            UnitLabel.ForeColor = Color.FromArgb(61, 65, 39);
            UnitLabel.Location = new Point(38, 182);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(112, 35);
            UnitLabel.TabIndex = 20;
            UnitLabel.Text = "Ед. изм.";
            // 
            // UnitBox
            // 
            UnitBox.BackColor = Color.FromArgb(212, 222, 149);
            UnitBox.BorderStyle = BorderStyle.FixedSingle;
            UnitBox.Font = new Font("Candara", 14.1846151F);
            UnitBox.Location = new Point(215, 183);
            UnitBox.Multiline = true;
            UnitBox.Name = "UnitBox";
            UnitBox.ReadOnly = true;
            UnitBox.Size = new Size(455, 34);
            UnitBox.TabIndex = 21;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(38, 225);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(76, 35);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Цена";
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(215, 226);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.ReadOnly = true;
            PriceBox.Size = new Size(455, 34);
            PriceBox.TabIndex = 13;
            // 
            // RelevanceLabel
            // 
            RelevanceLabel.AutoSize = true;
            RelevanceLabel.Font = new Font("Candara", 16.2769222F);
            RelevanceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            RelevanceLabel.Location = new Point(37, 265);
            RelevanceLabel.Name = "RelevanceLabel";
            RelevanceLabel.Size = new Size(181, 35);
            RelevanceLabel.TabIndex = 15;
            RelevanceLabel.Text = "Актуальность";
            // 
            // RelevanceBox
            // 
            RelevanceBox.BackColor = Color.FromArgb(212, 222, 149);
            RelevanceBox.BorderStyle = BorderStyle.FixedSingle;
            RelevanceBox.Font = new Font("Candara", 14.1846151F);
            RelevanceBox.Location = new Point(215, 266);
            RelevanceBox.Multiline = true;
            RelevanceBox.Name = "RelevanceBox";
            RelevanceBox.ReadOnly = true;
            RelevanceBox.Size = new Size(455, 34);
            RelevanceBox.TabIndex = 17;
            // 
            // CardStorekep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(711, 429);
            Controls.Add(UnitBox);
            Controls.Add(UnitLabel);
            Controls.Add(QuantityBox);
            Controls.Add(RelevanceBox);
            Controls.Add(RelevanceLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(PriceBox);
            Controls.Add(NameBox);
            Controls.Add(CategoryBox);
            Controls.Add(PriceLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(CancelButton);
            Controls.Add(CardLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardStorekep";
            Text = "NewCardStorekep";
            MouseDown += CardStorekep_MouseDown;
            MouseMove += CardStorekep_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CardLabel;
        private Button CancelButton;
        private Label NameLabel;
        private Label CategoryLabel;
        private Label PriceLabel;
        private TextBox CategoryBox;
        private TextBox NameBox;
        private TextBox PriceBox;
        private TextBox QuantityBox;
        private TextBox RelevanceBox;
        private Label RelevanceLabel;
        private Label QuantityLabel;
        private TextBox UnitBox;
        private Label UnitLabel;
    }
}