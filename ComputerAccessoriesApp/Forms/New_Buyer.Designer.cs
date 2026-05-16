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
            textBoxforpassport = new TextBox();
            textBoxforINN = new TextBox();
            textBoxforSNILS = new TextBox();
            buttonforkeep = new Button();
            buttonforcancel = new Button();
            SuspendLayout();
            // 
            // labelnew_buyer
            // 
            labelnew_buyer.Font = new Font("Candara", 24F);
            labelnew_buyer.Location = new Point(314, 23);
            labelnew_buyer.Name = "labelnew_buyer";
            labelnew_buyer.Size = new Size(364, 70);
            labelnew_buyer.TabIndex = 0;
            labelnew_buyer.Text = "Новый покупатель";
            // 
            // labelindividual
            // 
            labelindividual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelindividual.Location = new Point(341, 93);
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
            labelname.Location = new Point(79, 315);
            labelname.Name = "labelname";
            labelname.Size = new Size(72, 38);
            labelname.TabIndex = 3;
            labelname.Text = "Имя";
            // 
            // labelsurname
            // 
            labelsurname.AutoSize = true;
            labelsurname.Font = new Font("Segoe UI", 16.2F);
            labelsurname.Location = new Point(79, 446);
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
            textBoxforlastname.Location = new Point(86, 253);
            textBoxforlastname.Name = "textBoxforlastname";
            textBoxforlastname.Size = new Size(409, 36);
            textBoxforlastname.TabIndex = 5;
            // 
            // textBoxforsurname
            // 
            textBoxforsurname.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforsurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxforsurname.Font = new Font("Candara", 14.1846151F);
            textBoxforsurname.Location = new Point(86, 501);
            textBoxforsurname.Name = "textBoxforsurname";
            textBoxforsurname.PlaceholderText = "При наличии";
            textBoxforsurname.Size = new Size(416, 36);
            textBoxforsurname.TabIndex = 6;
            // 
            // textBoxforname
            // 
            textBoxforname.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforname.BorderStyle = BorderStyle.FixedSingle;
            textBoxforname.Font = new Font("Candara", 14.1846151F);
            textBoxforname.Location = new Point(86, 370);
            textBoxforname.Name = "textBoxforname";
            textBoxforname.Size = new Size(409, 36);
            textBoxforname.TabIndex = 7;
            // 
            // labelforINN
            // 
            labelforINN.Font = new Font("Segoe UI", 16.2F);
            labelforINN.Location = new Point(548, 315);
            labelforINN.Name = "labelforINN";
            labelforINN.Size = new Size(78, 38);
            labelforINN.TabIndex = 8;
            labelforINN.Text = "ИНН";
            // 
            // labelforSNILS
            // 
            labelforSNILS.Font = new Font("Segoe UI", 16.2F);
            labelforSNILS.Location = new Point(545, 446);
            labelforSNILS.Name = "labelforSNILS";
            labelforSNILS.Size = new Size(111, 38);
            labelforSNILS.TabIndex = 9;
            labelforSNILS.Text = "СНИЛС";
            // 
            // labelforpassport
            // 
            labelforpassport.Font = new Font("Segoe UI", 16.2F);
            labelforpassport.Location = new Point(548, 195);
            labelforpassport.Name = "labelforpassport";
            labelforpassport.Size = new Size(278, 38);
            labelforpassport.TabIndex = 10;
            labelforpassport.Text = "Паспортные данные";
            // 
            // textBoxforpassport
            // 
            textBoxforpassport.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforpassport.BorderStyle = BorderStyle.FixedSingle;
            textBoxforpassport.Font = new Font("Candara", 14.1846151F);
            textBoxforpassport.Location = new Point(548, 253);
            textBoxforpassport.MaxLength = 10;
            textBoxforpassport.Name = "textBoxforpassport";
            textBoxforpassport.PlaceholderText = "Введите серию и номер без пробела";
            textBoxforpassport.Size = new Size(416, 36);
            textBoxforpassport.TabIndex = 11;
            textBoxforpassport.KeyPress += textBoxPassport_KeyPress;
            // 
            // textBoxforINN
            // 
            textBoxforINN.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforINN.BorderStyle = BorderStyle.FixedSingle;
            textBoxforINN.Font = new Font("Candara", 14.1846151F);
            textBoxforINN.Location = new Point(548, 370);
            textBoxforINN.MaxLength = 12;
            textBoxforINN.Name = "textBoxforINN";
            textBoxforINN.Size = new Size(416, 36);
            textBoxforINN.TabIndex = 12;
            textBoxforINN.KeyPress += textBox2forINN_KeyPress;
            // 
            // textBoxforSNILS
            // 
            textBoxforSNILS.BackColor = Color.FromArgb(212, 222, 149);
            textBoxforSNILS.BorderStyle = BorderStyle.FixedSingle;
            textBoxforSNILS.Font = new Font("Candara", 14.1846151F);
            textBoxforSNILS.Location = new Point(545, 501);
            textBoxforSNILS.MaxLength = 11;
            textBoxforSNILS.Name = "textBoxforSNILS";
            textBoxforSNILS.Size = new Size(416, 36);
            textBoxforSNILS.TabIndex = 13;
            textBoxforSNILS.KeyPress += textBoxforSNILS_KeyPress;
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
            buttonforkeep.Click += buttonforkeep_Click;
            // 
            // buttonforcancel
            // 
            buttonforcancel.BackColor = Color.DarkOliveGreen;
            buttonforcancel.FlatStyle = FlatStyle.Popup;
            buttonforcancel.Font = new Font("Candara", 12.1846151F);
            buttonforcancel.ForeColor = Color.White;
            buttonforcancel.Location = new Point(835, 597);
            buttonforcancel.Name = "buttonforcancel";
            buttonforcancel.Size = new Size(129, 36);
            buttonforcancel.TabIndex = 15;
            buttonforcancel.Text = "Отмена";
            buttonforcancel.UseVisualStyleBackColor = false;
            buttonforcancel.Click += buttonforcancel_Click;
            // 
            // New_Buyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(1030, 737);
            Controls.Add(buttonforcancel);
            Controls.Add(buttonforkeep);
            Controls.Add(textBoxforSNILS);
            Controls.Add(textBoxforINN);
            Controls.Add(textBoxforpassport);
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
        private TextBox textBoxforpassport;
        private TextBox textBoxforINN;
        private TextBox textBoxforSNILS;
        private Button buttonforkeep;
        private Button buttonforcancel;
    }
}