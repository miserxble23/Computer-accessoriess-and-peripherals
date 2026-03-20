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
            BackButton = new Button();
            SendButton = new Button();
            DispatchLabel = new Label();
            FindBox = new TextBox();
            FindButton = new Button();
            BasketPanel = new Panel();
            BasketLabel = new Label();
            BasketPanel.SuspendLayout();
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
            // 
            // BasketPanel
            // 
            BasketPanel.BackColor = Color.FromArgb(212, 222, 149);
            BasketPanel.BorderStyle = BorderStyle.FixedSingle;
            BasketPanel.Controls.Add(BasketLabel);
            BasketPanel.Location = new Point(506, 82);
            BasketPanel.Name = "BasketPanel";
            BasketPanel.Size = new Size(271, 344);
            BasketPanel.TabIndex = 5;
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
            // DispatchForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(800, 500);
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
    }
}