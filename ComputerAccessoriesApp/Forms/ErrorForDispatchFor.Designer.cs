namespace ComputerAccessoriesApp
{
    partial class ErrorForDispatchFor
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
            NotEnoughLabel = new Label();
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
            ErrorLabel.TabIndex = 1;
            ErrorLabel.Text = "Ошибка";
            // 
            // NotEnoughLabel
            // 
            NotEnoughLabel.AutoSize = true;
            NotEnoughLabel.Font = new Font("Candara", 18.2769222F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NotEnoughLabel.ForeColor = Color.FromArgb(61, 65, 39);
            NotEnoughLabel.Location = new Point(31, 111);
            NotEnoughLabel.Name = "NotEnoughLabel";
            NotEnoughLabel.Size = new Size(329, 40);
            NotEnoughLabel.TabIndex = 2;
            NotEnoughLabel.Text = "Недостаточно товара";
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
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Закрыть";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ErrorForDispatchFor
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 259);
            Controls.Add(ExitButton);
            Controls.Add(NotEnoughLabel);
            Controls.Add(ErrorLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorForDispatchFor";
            Text = "ErrorForDispatchFor";
            MouseDown += ErrorForDispatchFor_MouseDown;
            MouseMove += ErrorForDispatchFor_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorLabel;
        private Label NotEnoughLabel;
        private Button ExitButton;
    }
}