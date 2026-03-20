namespace ComputerAccessoriesApp
{
    public partial class DispatchForm : Form
    {
        private Form parentForm;
        Point LastPoint;
        public DispatchForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
        private void DispatchForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void DispatchForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
