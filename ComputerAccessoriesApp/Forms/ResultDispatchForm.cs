namespace ComputerAccessoriesApp
{
    public partial class ResultDispatchForm : Form
    {
        Point LastPoint;
        public ResultDispatchForm()
        {
            InitializeComponent();
        }
        private void ResultDispatchForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void ResultDispatchForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
