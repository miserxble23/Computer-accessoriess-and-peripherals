namespace ComputerAccessoriesApp
{
    public partial class ConfirmationForm : Form
    {
        Point LastPoint;
        public bool IsConfirmed { get; private set; } = false;
        public ConfirmationForm()
        {
            InitializeComponent();
        }
        private void ConfirmationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void ConfirmationForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void YesButton_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();
        }
    }
}
