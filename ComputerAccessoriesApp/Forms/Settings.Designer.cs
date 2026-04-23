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
            SuspendLayout();
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SettingsLabel.ForeColor = Color.FromArgb(61, 65, 39);
            SettingsLabel.Location = new Point(73, 9);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(210, 49);
            SettingsLabel.TabIndex = 1;
            SettingsLabel.Text = "Настройки";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkOliveGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(198, 203);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(126, 32);
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
            CurrencyBox.Location = new Point(52, 92);
            CurrencyBox.Name = "CurrencyBox";
            CurrencyBox.Size = new Size(253, 37);
            CurrencyBox.TabIndex = 4;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(348, 247);
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
    }
}