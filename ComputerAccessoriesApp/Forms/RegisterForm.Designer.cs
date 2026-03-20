namespace ComputerAccessoriesApp
{
    partial class RegisterForm
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
            RegisterLabel = new Label();
            LoginBoxReg = new TextBox();
            PasswordBoxReg = new TextBox();
            CodeBoxReg = new TextBox();
            RegisterButtonReg = new Button();
            AuthorizationButtonReg = new Button();
            SuspendLayout();
            // 
            // RegisterLabel
            // 
            RegisterLabel.Font = new Font("Candara", 22.1538467F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterLabel.ForeColor = Color.FromArgb(61, 65, 39);
            RegisterLabel.Location = new Point(0, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(391, 120);
            RegisterLabel.TabIndex = 0;
            RegisterLabel.Text = "Регистрация";
            RegisterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginBoxReg
            // 
            LoginBoxReg.BackColor = Color.FromArgb(212, 222, 149);
            LoginBoxReg.BorderStyle = BorderStyle.FixedSingle;
            LoginBoxReg.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBoxReg.Location = new Point(53, 123);
            LoginBoxReg.Name = "LoginBoxReg";
            LoginBoxReg.PlaceholderText = "  Введите логин";
            LoginBoxReg.Size = new Size(283, 34);
            LoginBoxReg.TabIndex = 2;
            // 
            // PasswordBoxReg
            // 
            PasswordBoxReg.BackColor = Color.FromArgb(212, 222, 149);
            PasswordBoxReg.BorderStyle = BorderStyle.FixedSingle;
            PasswordBoxReg.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBoxReg.Location = new Point(53, 179);
            PasswordBoxReg.Name = "PasswordBoxReg";
            PasswordBoxReg.PasswordChar = '●';
            PasswordBoxReg.PlaceholderText = "  Введите пароль";
            PasswordBoxReg.Size = new Size(283, 34);
            PasswordBoxReg.TabIndex = 3;
            // 
            // CodeBoxReg
            // 
            CodeBoxReg.BackColor = Color.FromArgb(212, 222, 149);
            CodeBoxReg.BorderStyle = BorderStyle.FixedSingle;
            CodeBoxReg.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodeBoxReg.Location = new Point(53, 234);
            CodeBoxReg.Name = "CodeBoxReg";
            CodeBoxReg.PlaceholderText = "  Введите код";
            CodeBoxReg.Size = new Size(283, 34);
            CodeBoxReg.TabIndex = 4;
            // 
            // RegisterButtonReg
            // 
            RegisterButtonReg.BackColor = Color.DarkOliveGreen;
            RegisterButtonReg.Cursor = Cursors.Hand;
            RegisterButtonReg.FlatStyle = FlatStyle.Popup;
            RegisterButtonReg.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterButtonReg.ForeColor = Color.White;
            RegisterButtonReg.Location = new Point(51, 304);
            RegisterButtonReg.Name = "RegisterButtonReg";
            RegisterButtonReg.Size = new Size(288, 44);
            RegisterButtonReg.TabIndex = 0;
            RegisterButtonReg.Text = "Зарегистрироваться";
            RegisterButtonReg.UseVisualStyleBackColor = false;
            RegisterButtonReg.Click += RegisterButtonReg_Click;
            // 
            // AuthorizationButtonReg
            // 
            AuthorizationButtonReg.BackColor = Color.DarkOliveGreen;
            AuthorizationButtonReg.Cursor = Cursors.Hand;
            AuthorizationButtonReg.FlatStyle = FlatStyle.Popup;
            AuthorizationButtonReg.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorizationButtonReg.ForeColor = Color.White;
            AuthorizationButtonReg.Location = new Point(182, 394);
            AuthorizationButtonReg.Name = "AuthorizationButtonReg";
            AuthorizationButtonReg.Size = new Size(187, 44);
            AuthorizationButtonReg.TabIndex = 6;
            AuthorizationButtonReg.Text = "Авторизация";
            AuthorizationButtonReg.UseVisualStyleBackColor = false;
            AuthorizationButtonReg.Click += AuthorizationButtonReg_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 483);
            Controls.Add(AuthorizationButtonReg);
            Controls.Add(RegisterButtonReg);
            Controls.Add(CodeBoxReg);
            Controls.Add(PasswordBoxReg);
            Controls.Add(LoginBoxReg);
            Controls.Add(RegisterLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            MouseDown += registerForm_MouseDown;
            MouseMove += registerForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegisterLabel;
        private TextBox LoginBoxReg;
        private TextBox PasswordBoxReg;
        private TextBox CodeBoxReg;
        private Button RegisterButtonReg;
        private Button AuthorizationButtonReg;
    }
}