namespace ComputerAccessoriesApp
{
    partial class ErrorForm
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
            ErrorLabel = new Label();
            FalseDataLabel = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ErrorLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ErrorLabel.Location = new Point(12, 9);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(174, 53);
            ErrorLabel.TabIndex = 0;
            ErrorLabel.Text = "Ошибка";
            // 
            // FalseDataLabel
            // 
            FalseDataLabel.AutoSize = true;
            FalseDataLabel.Font = new Font("Candara", 18.2769222F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FalseDataLabel.ForeColor = Color.FromArgb(61, 65, 39);
            FalseDataLabel.Location = new Point(46, 107);
            FalseDataLabel.Name = "FalseDataLabel";
            FalseDataLabel.Size = new Size(276, 40);
            FalseDataLabel.TabIndex = 1;
            FalseDataLabel.Text = "Неверные данные";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkOliveGreen;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(262, 213);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(117, 34);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Закрыть";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 259);
            Controls.Add(ExitButton);
            Controls.Add(FalseDataLabel);
            Controls.Add(ErrorLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorForm";
            Text = "ErrorWorm";
            MouseDown += ErrorForm_MouseDown;
            MouseMove += ErrorForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorLabel;
        private Label FalseDataLabel;
        private Button ExitButton;
    }
}