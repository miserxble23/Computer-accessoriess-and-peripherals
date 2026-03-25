namespace ComputerAccessoriesApp
{
    public partial class ErrorForDispatchFor : Form
    {
        Point LastPoint;
        public ErrorForDispatchFor()
        {
            InitializeComponent();
        }
        private void ErrorForDispatchFor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void ErrorForDispatchFor_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
