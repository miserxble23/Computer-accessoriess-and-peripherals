namespace ComputerAccessoriesApp
{
    partial class ConfirmationForm
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
            SuccesLabel = new Label();
            YesButton = new Button();
            NoButton = new Button();
            SuspendLayout();
            // 
            // ConfirmationLabel
            // 
            ConfirmationLabel.AutoSize = true;
            ConfirmationLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConfirmationLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ConfirmationLabel.Location = new Point(12, 9);
            ConfirmationLabel.Name = "ConfirmationLabel";
            ConfirmationLabel.Size = new Size(328, 53);
            ConfirmationLabel.TabIndex = 3;
            ConfirmationLabel.Text = "Подтверждение";
            // 
            // SuccesLabel
            // 
            SuccesLabel.AutoSize = true;
            SuccesLabel.Font = new Font("Candara", 20.8153839F);
            SuccesLabel.ForeColor = Color.FromArgb(61, 65, 39);
            SuccesLabel.Location = new Point(81, 106);
            SuccesLabel.Name = "SuccesLabel";
            SuccesLabel.Size = new Size(229, 46);
            SuccesLabel.TabIndex = 4;
            SuccesLabel.Text = "Вы уверены?";
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.DarkOliveGreen;
            YesButton.Cursor = Cursors.Hand;
            YesButton.FlatStyle = FlatStyle.Popup;
            YesButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            YesButton.ForeColor = Color.White;
            YesButton.Location = new Point(12, 213);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(67, 34);
            YesButton.TabIndex = 5;
            YesButton.Text = "Да";
            YesButton.UseVisualStyleBackColor = false;
            YesButton.Click += YesButton_Click;
            // 
            // NoButton
            // 
            NoButton.BackColor = Color.DarkOliveGreen;
            NoButton.Cursor = Cursors.Hand;
            NoButton.FlatStyle = FlatStyle.Popup;
            NoButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NoButton.ForeColor = Color.White;
            NoButton.Location = new Point(312, 213);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(67, 34);
            NoButton.TabIndex = 6;
            NoButton.Text = "Нет";
            NoButton.UseVisualStyleBackColor = false;
            NoButton.Click += NoButton_Click;
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 259);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(SuccesLabel);
            Controls.Add(ConfirmationLabel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmationForm";
            Text = "ConfirmationForm";
            MouseDown += ConfirmationForm_MouseDown;
            MouseMove += ConfirmationForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConfirmationLabel;
        private Label SuccesLabel;
        private Button YesButton;
        private Button NoButton;
    }
}