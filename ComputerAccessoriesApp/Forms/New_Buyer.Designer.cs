namespace ComputerAccessoriesApp.Forms
{
    partial class New_Buyer
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
            labelnew_buyer = new Label();
            labelindividual = new Label();
            labellastname = new Label();
            labelname = new Label();
            labelsurname = new Label();
            textBoxforlastname = new TextBox();
            textBoxforsurname = new TextBox();
            textBoxforname = new TextBox();
            labelforINN = new Label();
            labelforSNILS = new Label();
            labelforpassport = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonforkeep = new Button();
            buttonforcancel = new Button();
            SuspendLayout();
            // 
            // labelnew_buyer
            // 
            labelnew_buyer.Font = new Font("Candara", 24F);
            labelnew_buyer.Location = new Point(185, 23);
            labelnew_buyer.Name = "labelnew_buyer";
            labelnew_buyer.Size = new Size(364, 70);
            labelnew_buyer.TabIndex = 0;
            labelnew_buyer.Text = "Новый покупатель";
            // 
            // labelindividual
            // 
            labelindividual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelindividual.Location = new Point(209, 93);
            labelindividual.Name = "labelindividual";
            labelindividual.Size = new Size(315, 60);
            labelindividual.TabIndex = 1;
            labelindividual.Text = "Физическое лицо";
            // 
            // labellastname
            // 
            labellastname.AutoSize = true;
            labellastname.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellastname.Location = new Point(79, 195);
            labellastname.Name = "labellastname";
            labellastname.Size = new Size(132, 38);
            labellastname.TabIndex = 2;
            labellastname.Text = "Фамилия";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Font = new Font("Segoe UI", 16.2F);
            labelname.Location = new Point(86, 315);
            labelname.Name = "labelname";
            labelname.Size = new Size(72, 38);
            labelname.TabIndex = 3;
            labelname.Text = "Имя";
            // 
            // labelsurname
            // 
            labelsurname.AutoSize = true;
            labelsurname.Font = new Font("Segoe UI", 16.2F);
            labelsurname.Location = new Point(86, 446);
            labelsurname.Name = "labelsurname";
            labelsurname.Size = new Size(135, 38);
            labelsurname.TabIndex = 4;
            labelsurname.Text = "Отчество";
            // 
            // textBoxforlastname
            // 
            textBoxforlastname.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforlastname.BorderStyle = BorderStyle.FixedSingle;
            textBoxforlastname.Font = new Font("Candara", 14.1846151F);
            textBoxforlastname.Location = new Point(86, 248);
            textBoxforlastname.Name = "textBoxforlastname";
            textBoxforlastname.Size = new Size(265, 36);
            textBoxforlastname.TabIndex = 5;
            // 
            // textBoxforsurname
            // 
            textBoxforsurname.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforsurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxforsurname.Font = new Font("Candara", 14.1846151F);
            textBoxforsurname.Location = new Point(86, 506);
            textBoxforsurname.Name = "textBoxforsurname";
            textBoxforsurname.Size = new Size(265, 36);
            textBoxforsurname.TabIndex = 6;
            // 
            // textBoxforname
            // 
            textBoxforname.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforname.BorderStyle = BorderStyle.FixedSingle;
            textBoxforname.Font = new Font("Candara", 14.1846151F);
            textBoxforname.Location = new Point(86, 370);
            textBoxforname.Name = "textBoxforname";
            textBoxforname.Size = new Size(265, 36);
            textBoxforname.TabIndex = 7;
            // 
            // labelforINN
            // 
            labelforINN.Font = new Font("Segoe UI", 16.2F);
            labelforINN.Location = new Point(471, 315);
            labelforINN.Name = "labelforINN";
            labelforINN.Size = new Size(78, 38);
            labelforINN.TabIndex = 8;
            labelforINN.Text = "ИНН";
            // 
            // labelforSNILS
            // 
            labelforSNILS.Font = new Font("Segoe UI", 16.2F);
            labelforSNILS.Location = new Point(471, 446);
            labelforSNILS.Name = "labelforSNILS";
            labelforSNILS.Size = new Size(111, 38);
            labelforSNILS.TabIndex = 9;
            labelforSNILS.Text = "СНИЛС";
            // 
            // labelforpassport
            // 
            labelforpassport.Font = new Font("Segoe UI", 16.2F);
            labelforpassport.Location = new Point(471, 195);
            labelforpassport.Name = "labelforpassport";
            labelforpassport.Size = new Size(278, 38);
            labelforpassport.TabIndex = 10;
            labelforpassport.Text = "Паспортные данные";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(212, 222, 149);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Candara", 14.1846151F);
            textBox1.Location = new Point(471, 248);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите сирию и номер";
            textBox1.Size = new Size(265, 36);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(212, 222, 149);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Candara", 14.1846151F);
            textBox2.Location = new Point(471, 370);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 36);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(212, 222, 149);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Candara", 14.1846151F);
            textBox3.Location = new Point(471, 506);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 36);
            textBox3.TabIndex = 13;
            // 
            // buttonforkeep
            // 
            buttonforkeep.BackColor = Color.DarkOliveGreen;
            buttonforkeep.FlatStyle = FlatStyle.Popup;
            buttonforkeep.Font = new Font("Candara", 12.1846151F);
            buttonforkeep.ForeColor = Color.White;
            buttonforkeep.Location = new Point(86, 614);
            buttonforkeep.Name = "buttonforkeep";
            buttonforkeep.Size = new Size(129, 36);
            buttonforkeep.TabIndex = 14;
            buttonforkeep.Text = "Сохранить";
            buttonforkeep.UseVisualStyleBackColor = false;
            // 
            // buttonforcancel
            // 
            buttonforcancel.BackColor = Color.DarkOliveGreen;
            buttonforcancel.FlatStyle = FlatStyle.Popup;
            buttonforcancel.Font = new Font("Candara", 12.1846151F);
            buttonforcancel.ForeColor = Color.White;
            buttonforcancel.Location = new Point(607, 614);
            buttonforcancel.Name = "buttonforcancel";
            buttonforcancel.Size = new Size(129, 36);
            buttonforcancel.TabIndex = 15;
            buttonforcancel.Text = "Отмена";
            buttonforcancel.UseVisualStyleBackColor = false;
            // 
            // New_Buyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(890, 681);
            Controls.Add(buttonforcancel);
            Controls.Add(buttonforkeep);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelforpassport);
            Controls.Add(labelforSNILS);
            Controls.Add(labelforINN);
            Controls.Add(textBoxforname);
            Controls.Add(textBoxforsurname);
            Controls.Add(textBoxforlastname);
            Controls.Add(labelsurname);
            Controls.Add(labelname);
            Controls.Add(labellastname);
            Controls.Add(labelindividual);
            Controls.Add(labelnew_buyer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "New_Buyer";
            Text = "New_Buyer";
            MouseDown += New_Buyer_MouseDown;
            MouseMove += New_Buyer_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnew_buyer;
        private Label labelindividual;
        private Label labellastname;
        private Label labelname;
        private Label labelsurname;
        private TextBox textBoxforlastname;
        private TextBox textBoxforsurname;
        private TextBox textBoxforname;
        private Label labelforINN;
        private Label labelforSNILS;
        private Label labelforpassport;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonforkeep;
        private Button buttonforcancel;
    }
}