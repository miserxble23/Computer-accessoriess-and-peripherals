using ComputerAccessoriesApp.Classes;
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

        private void buttonforkeep_Click(object sender, EventArgs e)
        {
            if (textBoxforlastname.Text == string.Empty || textBoxforINN.Text == string.Empty || textBoxforpassport.Text == string.Empty || textBoxforname.Text == string.Empty || textBoxforSNILS.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Buyer buyer = new Buyer();
            buyer.Id = Guid.NewGuid();
            buyer.Lastname = textBoxforlastname.Text;
            buyer.Name = textBoxforname.Text;
            buyer.Surname = textBoxforsurname.Text;
            buyer.Passport = textBoxforpassport.Text;
            buyer.INN = textBoxforINN.Text;
            buyer.SNILS = textBoxforSNILS.Text;
            try
            {
                using (DbContext db_for_buyer = new DbContext())
                {
                    db_for_buyer.buyers.Add(buyer);
                    db_for_buyer.SaveChanges();
                }
                MessageBox.Show("Покупатель сохранён!");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при сохранении: " + exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ;
        }
        private void textBox2forINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show("Пробелы не допускаются в поле 'ИНН'.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Вводить можно только цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxforSNILS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show("Пробелы не допускаются в поле 'СНИЛС'.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

