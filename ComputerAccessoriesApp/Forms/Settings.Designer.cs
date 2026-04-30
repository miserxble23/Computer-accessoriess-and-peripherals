namespace ComputerAccessoriesApp
{
    partial class Settings
    {   /// <summary>
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
            SettingsLabel = new Label();
            SaveButton = new Button();
            CurrencyBox = new ComboBox();
            Currency = new Label();
            SuspendLayout();
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SettingsLabel.ForeColor = Color.FromArgb(61, 65, 39);
            SettingsLabel.Location = new Point(73, 9);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(356, 49);
            SettingsLabel.TabIndex = 1;
            SettingsLabel.Text = "Настройки Валюты";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkOliveGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Candara", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(303, 274);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(134, 39);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // CurrencyBox
            // 
            CurrencyBox.BackColor = Color.FromArgb(212, 222, 149);
            CurrencyBox.Font = new Font("Candara", 14.1846151F);
            CurrencyBox.FormattingEnabled = true;
            CurrencyBox.Location = new Point(176, 126);
            CurrencyBox.Name = "CurrencyBox";
            CurrencyBox.Size = new Size(253, 37);
            CurrencyBox.TabIndex = 4;
            // 
            // Currency
            // 
            Currency.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Currency.Location = new Point(31, 119);
            Currency.Name = "Currency";
            Currency.Size = new Size(128, 37);
            Currency.TabIndex = 5;
            Currency.Text = "Валюта:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(449, 400);
            Controls.Add(Currency);
            Controls.Add(CurrencyBox);
            Controls.Add(SaveButton);
            Controls.Add(SettingsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            MouseDown += Settings_MouseDown;
            MouseMove += Settings_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SettingsLabel;
        private Button SaveButton;
        private ComboBox CurrencyBox;
        private Label Currency;
    }
}