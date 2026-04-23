namespace ComputerAccessoriesApp
{
    public partial class Settings : Form
    {
        Form parentForm;
        Point LastPoint;
        public Settings(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}
