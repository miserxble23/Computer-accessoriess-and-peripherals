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
            ID = new DataGridViewTextBoxColumn();
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
            BackButton.Location = new Point(703, 23);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(124, 39);
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
            FindButton.Location = new Point(435, 87);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(124, 39);
            FindButton.TabIndex = 5;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = false;
            // 
            // ListCategoryLabel
            // 
            ListCategoryLabel.AutoSize = true;
            ListCategoryLabel.Font = new Font("Candara", 23.8153839F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListCategoryLabel.ForeColor = Color.FromArgb(61, 65, 39);
            ListCategoryLabel.Location = new Point(12, 9);
            ListCategoryLabel.Name = "ListCategoryLabel";
            ListCategoryLabel.Size = new Size(358, 53);
            ListCategoryLabel.TabIndex = 6;
            ListCategoryLabel.Text = "Список категорий";
            // 
            // FindBox
            // 
            FindBox.BackColor = Color.FromArgb(212, 222, 149);
            FindBox.BorderStyle = BorderStyle.FixedSingle;
            FindBox.Font = new Font("Candara", 14.1846151F);
            FindBox.Location = new Point(12, 87);
            FindBox.Name = "FindBox";
            FindBox.PlaceholderText = "  Поиск";
            FindBox.Size = new Size(402, 39);
            FindBox.TabIndex = 7;
            // 
            // NewCategoryButton
            // 
            NewCategoryButton.BackColor = Color.DarkOliveGreen;
            NewCategoryButton.Cursor = Cursors.Hand;
            NewCategoryButton.FlatStyle = FlatStyle.Popup;
            NewCategoryButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NewCategoryButton.ForeColor = Color.White;
            NewCategoryButton.Location = new Point(389, 23);
            NewCategoryButton.Name = "NewCategoryButton";
            NewCategoryButton.Size = new Size(209, 39);
            NewCategoryButton.TabIndex = 23;
            NewCategoryButton.Text = "Новая категория";
            NewCategoryButton.UseVisualStyleBackColor = false;
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
            EditPanel.Location = new Point(435, 145);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(362, 247);
            EditPanel.TabIndex = 24;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(197, 227, 132);
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Candara", 14.1846151F);
            NameBox.Location = new Point(19, 64);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "  Название";
            NameBox.Size = new Size(316, 39);
            NameBox.TabIndex = 21;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkOliveGreen;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(137, 133);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 34);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkOliveGreen;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(248, 133);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(109, 34);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkOliveGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(3, 133);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(128, 34);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // EditLabel
            // 
            EditLabel.AutoSize = true;
            EditLabel.Font = new Font("Candara", 16.1538467F);
            EditLabel.ForeColor = Color.FromArgb(61, 65, 39);
            EditLabel.Location = new Point(3, 10);
            EditLabel.Name = "EditLabel";
            EditLabel.Size = new Size(236, 37);
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
            ListCategoryGridView.Columns.AddRange(new DataGridViewColumn[] { ID, CategoryName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(197, 227, 132);
            dataGridViewCellStyle2.Font = new Font("Candara", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ListCategoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ListCategoryGridView.EnableHeadersVisualStyles = false;
            ListCategoryGridView.Location = new Point(12, 145);
            ListCategoryGridView.Name = "ListCategoryGridView";
            ListCategoryGridView.RowHeadersVisible = false;
            ListCategoryGridView.RowHeadersWidth = 56;
            ListCategoryGridView.Size = new Size(402, 373);
            ListCategoryGridView.TabIndex = 25;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            // 
            // Name
            // 
            CategoryName.DataPropertyName = "name";
            CategoryName.HeaderText = "Название";
            CategoryName.MinimumWidth = 7;
            CategoryName.Name = "Name";
            CategoryName.Width = 299;
            // 
            // ListCategoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(186, 192, 149);
            ClientSize = new Size(839, 530);
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CategoryName;
    }
}