namespace ComputerAccessoriesApp
{
    partial class AuthorizationForm
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
            authorizationLabel = new Label();
            LoginBoxAutho = new TextBox();
            PasswordBoxAutho = new TextBox();
            EnterButtonAutho = new Button();
            RegisterButtonAutho = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // authorizationLabel
            // 
            authorizationLabel.Dock = DockStyle.Top;
            authorizationLabel.Font = new Font("Candara", 22.1538467F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorizationLabel.ForeColor = Color.FromArgb(61, 65, 39);
            authorizationLabel.Location = new Point(0, 0);
            authorizationLabel.Name = "authorizationLabel";
            authorizationLabel.Size = new Size(391, 120);
            authorizationLabel.TabIndex = 0;
            authorizationLabel.Text = "Авторизация";
            authorizationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginBoxAutho
            // 
            LoginBoxAutho.BackColor = Color.FromArgb(212, 222, 149);
            LoginBoxAutho.BorderStyle = BorderStyle.FixedSingle;
            LoginBoxAutho.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBoxAutho.Location = new Point(53, 123);
            LoginBoxAutho.Name = "LoginBoxAutho";
            LoginBoxAutho.PlaceholderText = "  Введите логин";
            LoginBoxAutho.Size = new Size(283, 34);
            LoginBoxAutho.TabIndex = 1;
            // 
            // PasswordBoxAutho
            // 
            PasswordBoxAutho.BackColor = Color.FromArgb(212, 222, 149);
            PasswordBoxAutho.BorderStyle = BorderStyle.FixedSingle;
            PasswordBoxAutho.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBoxAutho.Location = new Point(53, 179);
            PasswordBoxAutho.Name = "PasswordBoxAutho";
            PasswordBoxAutho.PasswordChar = '●';
            PasswordBoxAutho.PlaceholderText = "  Введите пароль";
            PasswordBoxAutho.Size = new Size(283, 34);
            PasswordBoxAutho.TabIndex = 2;
            // 
            // EnterButtonAutho
            // 
            EnterButtonAutho.BackColor = Color.DarkOliveGreen;
            EnterButtonAutho.Cursor = Cursors.Hand;
            EnterButtonAutho.FlatAppearance.BorderColor = Color.Black;
            EnterButtonAutho.FlatStyle = FlatStyle.Popup;
            EnterButtonAutho.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnterButtonAutho.ForeColor = Color.White;
            EnterButtonAutho.Location = new Point(112, 255);
            EnterButtonAutho.Name = "EnterButtonAutho";
            EnterButtonAutho.Size = new Size(167, 44);
            EnterButtonAutho.TabIndex = 0;
            EnterButtonAutho.Text = "Войти";
            EnterButtonAutho.UseVisualStyleBackColor = false;
            EnterButtonAutho.Click += EnterButtonAutho_Click;
            // 
            // RegisterButtonAutho
            // 
            RegisterButtonAutho.BackColor = Color.DarkOliveGreen;
            RegisterButtonAutho.Cursor = Cursors.Hand;
            RegisterButtonAutho.FlatStyle = FlatStyle.Popup;
            RegisterButtonAutho.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterButtonAutho.ForeColor = Color.White;
            RegisterButtonAutho.Location = new Point(184, 394);
            RegisterButtonAutho.Name = "RegisterButtonAutho";
            RegisterButtonAutho.Size = new Size(185, 44);
            RegisterButtonAutho.TabIndex = 4;
            RegisterButtonAutho.Text = "Регистрация";
            RegisterButtonAutho.UseVisualStyleBackColor = false;
            RegisterButtonAutho.Click += RegisterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkOliveGreen;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatAppearance.BorderColor = Color.Black;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(345, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(46, 44);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 483);
            Controls.Add(ExitButton);
            Controls.Add(RegisterButtonAutho);
            Controls.Add(EnterButtonAutho);
            Controls.Add(PasswordBoxAutho);
            Controls.Add(LoginBoxAutho);
            Controls.Add(authorizationLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorizationForm";
            MouseDown += authorizationForm_MouseDown;
            MouseMove += authorizationForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label authorizationLabel;
        private TextBox LoginBoxAutho;
        private TextBox PasswordBoxAutho;
        private Button EnterButtonAutho;
        private Button RegisterButtonAutho;
        private Button ExitButton;
    }
}