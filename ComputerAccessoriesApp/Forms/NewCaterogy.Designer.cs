namespace ComputerAccessoriesApp.Forms
{
    partial class NewCaterogy
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
            this.SaveButton = new Button();
            CancelButton = new Button();
            LoginBoxReg = new TextBox();
            SuspendLayout();
            // 
            // ConfirmationLabel
            // 
            ConfirmationLabel.AutoSize = true;
            ConfirmationLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConfirmationLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ConfirmationLabel.Location = new Point(12, 9);
            ConfirmationLabel.Name = "ConfirmationLabel";
            ConfirmationLabel.Size = new Size(340, 53);
            ConfirmationLabel.TabIndex = 4;
            ConfirmationLabel.Text = "Новая категория";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = Color.DarkOliveGreen;
            this.SaveButton.Cursor = Cursors.Hand;
            this.SaveButton.FlatStyle = FlatStyle.Popup;
            this.SaveButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.SaveButton.ForeColor = Color.White;
            this.SaveButton.Location = new Point(12, 213);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new Size(126, 34);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(281, 213);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(98, 34);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // LoginBoxReg
            // 
            LoginBoxReg.BackColor = Color.FromArgb(212, 222, 149);
            LoginBoxReg.BorderStyle = BorderStyle.FixedSingle;
            LoginBoxReg.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBoxReg.Location = new Point(54, 112);
            LoginBoxReg.Name = "LoginBoxReg";
            LoginBoxReg.PlaceholderText = "  Введите название";
            LoginBoxReg.Size = new Size(283, 34);
            LoginBoxReg.TabIndex = 8;
            // 
            // NewCaterogy
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 259);
            Controls.Add(LoginBoxReg);
            Controls.Add(CancelButton);
            Controls.Add(this.SaveButton);
            Controls.Add(ConfirmationLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewCaterogy";
            Text = "NewCaterogy";
            MouseDown += NewCaterogy_MouseDown;
            MouseMove += NewCaterogy_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConfirmationLabel;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox LoginBoxReg;
    }
}