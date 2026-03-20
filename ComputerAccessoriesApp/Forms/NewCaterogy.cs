namespace ComputerAccessoriesApp.Forms
{
    public partial class NewCaterogy : Form
    {
        Point LastPoint;
        public NewCaterogy()
        {
            InitializeComponent();
        }
        private void NewCaterogy_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void NewCaterogy_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}
