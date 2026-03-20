namespace ComputerAccessoriesApp.Forms
{
    public partial class EditProduct : Form
    {
        Point LastPoint;
        public EditProduct()
        {
            InitializeComponent();
        }
        private void EditProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void EditProduct_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CardAdmin crAd=new CardAdmin();
            crAd.Show();
            this.Close();
        }
    }
}
