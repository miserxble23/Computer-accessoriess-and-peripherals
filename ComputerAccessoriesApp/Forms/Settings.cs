namespace ComputerAccessoriesApp
{
    public partial class Settings : Form
    {
        Point LastPoint;
        public Settings()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
