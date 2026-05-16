using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComputerAccessoriesApp.Forms
{
    public partial class New_Buyer : Form
    {
        Point LastPoint;
        private void New_Buyer_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void New_Buyer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        public New_Buyer()
        {
            InitializeComponent();
        }

        private void buttonforcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show("Пробелы не допускаются в поле 'Паспортные данные'.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Вводить можно только цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
