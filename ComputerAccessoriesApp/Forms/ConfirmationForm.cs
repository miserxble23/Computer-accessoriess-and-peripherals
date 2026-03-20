namespace ComputerAccessoriesApp
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }
        Point LastPoint;
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
            LastPoint=new Point(e.X, e.Y);
        }
    }
}
