namespace ComputerAccessoriesApp
{
    partial class ResultDispatchForm
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
            SuccesLabel = new Label();
            DoneButton = new Button();
            SuspendLayout();
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ErrorLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ErrorLabel.Location = new Point(12, 9);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(208, 53);
            ErrorLabel.TabIndex = 2;
            ErrorLabel.Text = "Результат";
            // 
            // SuccesLabel
            // 
            SuccesLabel.AutoSize = true;
            SuccesLabel.Font = new Font("Candara", 20.8153839F);
            SuccesLabel.ForeColor = Color.FromArgb(61, 65, 39);
            SuccesLabel.Location = new Point(113, 101);
            SuccesLabel.Name = "SuccesLabel";
            SuccesLabel.Size = new Size(164, 46);
            SuccesLabel.TabIndex = 3;
            SuccesLabel.Text = "Успешно";
            // 
            // DoneButton
            // 
            DoneButton.BackColor = Color.DarkOliveGreen;
            DoneButton.Cursor = Cursors.Hand;
            DoneButton.FlatStyle = FlatStyle.Popup;
            DoneButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoneButton.ForeColor = Color.White;
            DoneButton.Location = new Point(262, 213);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(117, 34);
            DoneButton.TabIndex = 4;
            DoneButton.Text = "Готово";
            DoneButton.UseVisualStyleBackColor = false;
            // 
            // ResultDispatchForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(391, 259);
            Controls.Add(DoneButton);
            Controls.Add(SuccesLabel);
            Controls.Add(ErrorLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultDispatchForm";
            Text = "ResultDispatchForm";
            MouseDown += ResultDispatchForm_MouseDown;
            MouseMove += ResultDispatchForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorLabel;
        private Label SuccesLabel;
        private Button DoneButton;
    }
}