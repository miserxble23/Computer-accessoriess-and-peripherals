namespace ComputerAccessoriesApp.Forms
{
    public partial class ListCategoryForm : Form
    {
        Point LastPoint;
        public ListCategoryForm()
        {
            InitializeComponent();
        }
        private void ListCategoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void ListCategoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.Show();
            this.Close();
        }
    }
}
