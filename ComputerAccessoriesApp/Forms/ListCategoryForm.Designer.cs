namespace ComputerAccessoriesApp.Forms
{
    partial class ListCategoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BackButton = new Button();
            FindButton = new Button();
            ListCategoryLabel = new Label();
            FindBox = new TextBox();
            NewCategoryButton = new Button();
            EditPanel = new Panel();
            NameBox = new TextBox();
            DeleteButton = new Button();
            CancelButton = new Button();
            SaveButton = new Button();
            EditLabel = new Label();
            ListCategoryGridView = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListCategoryGridView).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkOliveGreen;
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Candara", 12.1846151F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(625, 22);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(110, 37);
            BackButton.TabIndex = 1;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.DarkOliveGreen;
            FindButton.Cursor = Cursors.Hand;
            FindButton.FlatStyle = FlatStyle.Popup;
            FindButton.Font = new Font("Candara", 12.1846151F);
            FindButton.ForeColor = Color.White;
            FindButton.Location = new Point(387, 83);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(110, 37);
            FindButton.TabIndex = 5;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // ListCategoryLabel
            // 
            ListCategoryLabel.AutoSize = true;
            ListCategoryLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListCategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ListCategoryLabel.Location = new Point(11, 9);
            ListCategoryLabel.Name = "ListCategoryLabel";
            ListCategoryLabel.Size = new Size(334, 49);
            ListCategoryLabel.TabIndex = 6;
            ListCategoryLabel.Text = "Список категорий";
            // 
            // FindBox
            // 
            FindBox.BackColor = Color.FromArgb(212, 222, 149);
            FindBox.BorderStyle = BorderStyle.FixedSingle;
            FindBox.Font = new Font("Candara", 14.1846151F);
            FindBox.Location = new Point(11, 83);
            FindBox.Name = "FindBox";
            FindBox.PlaceholderText = "  Поиск";
            FindBox.Size = new Size(358, 36);
            FindBox.TabIndex = 7;
            // 
            // NewCategoryButton
            // 
            NewCategoryButton.BackColor = Color.DarkOliveGreen;
            NewCategoryButton.Cursor = Cursors.Hand;
            NewCategoryButton.FlatStyle = FlatStyle.Popup;
            NewCategoryButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NewCategoryButton.ForeColor = Color.White;
            NewCategoryButton.Location = new Point(346, 22);
            NewCategoryButton.Name = "NewCategoryButton";
            NewCategoryButton.Size = new Size(186, 37);
            NewCategoryButton.TabIndex = 23;
            NewCategoryButton.Text = "Новая категория";
            NewCategoryButton.UseVisualStyleBackColor = false;
            NewCategoryButton.Click += NewCategoryButton_Click;
            // 
            // EditPanel
            // 
            EditPanel.BackColor = Color.FromArgb(212, 222, 149);
            EditPanel.BorderStyle = BorderStyle.FixedSingle;
            EditPanel.Controls.Add(NameBox);
            EditPanel.Controls.Add(DeleteButton);
            EditPanel.Controls.Add(CancelButton);
            EditPanel.Controls.Add(SaveButton);
            EditPanel.Controls.Add(EditLabel);
            EditPanel.Location = new Point(387, 138);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(347, 235);
            EditPanel.TabIndex = 24;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(197, 227, 132);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(3, 61);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "  Название";
            NameBox.Size = new Size(339, 36);
            NameBox.TabIndex = 21;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkOliveGreen;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(136, 127);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(99, 32);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(247, 127);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(95, 32);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkOliveGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(3, 127);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(123, 32);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditLabel
            // 
            EditLabel.AutoSize = true;
            EditLabel.Font = new Font("Candara", 16.1538467F);
            EditLabel.ForeColor = Color.FromArgb(61, 65, 39);
            EditLabel.Location = new Point(3, 10);
            EditLabel.Name = "EditLabel";
            EditLabel.Size = new Size(209, 33);
            EditLabel.TabIndex = 3;
            EditLabel.Text = "Редактирование";
            // 
            // ListCategoryGridView
            // 
            ListCategoryGridView.BackgroundColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle1.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ListCategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ListCategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListCategoryGridView.Columns.AddRange(new DataGridViewColumn[] { CategoryName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle2.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ListCategoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ListCategoryGridView.EnableHeadersVisualStyles = false;
            ListCategoryGridView.Location = new Point(12, 138);
            ListCategoryGridView.Name = "ListCategoryGridView";
            ListCategoryGridView.RowHeadersVisible = false;
            ListCategoryGridView.RowHeadersWidth = 56;
            ListCategoryGridView.Size = new Size(357, 355);
            ListCategoryGridView.TabIndex = 25;
            ListCategoryGridView.CellClick += ListCategoryGridView_CellClick;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "name";
            CategoryName.HeaderText = "Название";
            CategoryName.MinimumWidth = 7;
            CategoryName.Name = "CategoryName";
            CategoryName.Width = 380;
            // 
            // ListCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(746, 505);
            Controls.Add(ListCategoryGridView);
            Controls.Add(EditPanel);
            Controls.Add(NewCategoryButton);
            Controls.Add(FindBox);
            Controls.Add(ListCategoryLabel);
            Controls.Add(FindButton);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCategoryForm";
            Text = "ListCategoryForm";
            Load += ListCategoryForm_Load;
            MouseDown += ListCategoryForm_MouseDown;
            MouseMove += ListCategoryForm_MouseMove;
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListCategoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button FindButton;
        private Label ListCategoryLabel;
        private TextBox FindBox;
        private Button NewCategoryButton;
        private Panel EditPanel;
        private Label EditLabel;
        private Button SaveButton;
        private Button CancelButton;
        private Button DeleteButton;
        private TextBox NameBox;
        private DataGridView ListCategoryGridView;
        private DataGridViewTextBoxColumn CategoryName;
    }
}