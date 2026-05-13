namespace ComputerAccessoriesApp.Forms
{
    partial class Contactor_Verification
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
            label1 = new Label();
            label2 = new Label();
            textBoxforcontragent = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 30);
            label1.Name = "label1";
            label1.Size = new Size(215, 63);
            label1.TabIndex = 0;
            label1.Text = "Проверка";
            // 
            // label2
            // 
            label2.Font = new Font("Candara", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 118);
            label2.Name = "label2";
            label2.Size = new Size(167, 44);
            label2.TabIndex = 1;
            label2.Text = "Контрагент:";
            // 
            // textBoxforcontragent
            // 
            textBoxforcontragent.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforcontragent.BorderStyle = BorderStyle.FixedSingle;
            textBoxforcontragent.Font = new Font("Candara", 14.1846151F);
            textBoxforcontragent.Location = new Point(182, 165);
            textBoxforcontragent.Name = "textBoxforcontragent";
            textBoxforcontragent.Size = new Size(383, 36);
            textBoxforcontragent.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Candara", 12.1846151F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(593, 165);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
            button1.TabIndex = 3;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Font = new Font("Candara", 16.2F);
            label3.Location = new Point(182, 233);
            label3.Name = "label3";
            label3.Size = new Size(107, 54);
            label3.TabIndex = 4;
            label3.Text = "ИНН:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(212, 222, 149);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Candara", 14.1846151F);
            textBox1.Location = new Point(182, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 36);
            textBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOliveGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Candara", 12.1846151F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(593, 290);
            button3.Name = "button3";
            button3.Size = new Size(129, 36);
            button3.TabIndex = 7;
            button3.Text = "Проверить";
            button3.UseVisualStyleBackColor = false;
            // 
            // Contactor_Verification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(982, 607);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBoxforcontragent);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contactor_Verification";
            Text = "Contactor_Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxforcontragent;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
    }
}