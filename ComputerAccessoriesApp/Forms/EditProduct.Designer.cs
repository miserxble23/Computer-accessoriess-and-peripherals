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
            ConfirmationLabel = new Label();
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
            SuspendLayout();
            // 
            // ConfirmationLabel
            // 
            ConfirmationLabel.AutoSize = true;
            ConfirmationLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConfirmationLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ConfirmationLabel.Location = new Point(183, 9);
            ConfirmationLabel.Name = "ConfirmationLabel";
            ConfirmationLabel.Size = new Size(473, 53);
            ConfirmationLabel.TabIndex = 5;
            ConfirmationLabel.Text = "Редактирование товара";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(650, 461);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(98, 34);
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
            SaveButton.Location = new Point(56, 461);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(126, 34);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Candara", 16.2769222F);
            NameLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NameLabel.Location = new Point(56, 112);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(142, 37);
            NameLabel.TabIndex = 10;
            NameLabel.Text = "Название";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Candara", 16.2769222F);
            CategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            CategoryLabel.Location = new Point(56, 168);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(154, 37);
            CategoryLabel.TabIndex = 11;
            CategoryLabel.Text = "Категория";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Candara", 16.2769222F);
            UnitLabel.ForeColor = Color.FromArgb(61, 65, 39);
            UnitLabel.Location = new Point(56, 306);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(126, 37);
            UnitLabel.TabIndex = 12;
            UnitLabel.Text = "Ед. Изм.";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Candara", 16.2769222F);
            PriceLabel.ForeColor = Color.FromArgb(61, 65, 39);
            PriceLabel.Location = new Point(56, 367);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(82, 37);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "Цена";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(212, 222, 149);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(236, 113);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(512, 36);
            NameBox.TabIndex = 14;
            // 
            // CategoryBox
            // 
            CategoryBox.BackColor = Color.FromArgb(212, 222, 149);
            CategoryBox.BorderStyle = BorderStyle.FixedSingle;
            CategoryBox.Font = new Font("Candara", 14.1846151F);
            CategoryBox.Location = new Point(236, 169);
            CategoryBox.Multiline = true;
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(512, 36);
            CategoryBox.TabIndex = 15;
            // 
            // UnitBox
            // 
            UnitBox.BackColor = Color.FromArgb(212, 222, 149);
            UnitBox.BorderStyle = BorderStyle.FixedSingle;
            UnitBox.Font = new Font("Candara", 14.1846151F);
            UnitBox.Location = new Point(236, 306);
            UnitBox.Multiline = true;
            UnitBox.Name = "UnitBox";
            UnitBox.Size = new Size(512, 36);
            UnitBox.TabIndex = 17;
            // 
            // PriceBox
            // 
            PriceBox.BackColor = Color.FromArgb(212, 222, 149);
            PriceBox.BorderStyle = BorderStyle.FixedSingle;
            PriceBox.Font = new Font("Candara", 14.1846151F);
            PriceBox.Location = new Point(236, 368);
            PriceBox.Multiline = true;
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(512, 36);
            PriceBox.TabIndex = 18;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(839, 530);
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
            Controls.Add(ConfirmationLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProduct";
            Text = "EditCategory";
            MouseDown += EditProduct_MouseDown;
            MouseMove += EditProduct_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConfirmationLabel;
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
    }
}