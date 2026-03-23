namespace ComputerAccessoriesApp.Forms
{
    public partial class CreateProduct : Form
    {
        Point LastPoint;
        public CreateProduct()
        {
            InitializeComponent();
        }
        private void CreateProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void CreateProduct_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CatalogForAdmin ctForAd = new CatalogForAdmin();
            ctForAd.Show();
            this.Close();
        }
        private void ListCategoryButton_Click(object sender, EventArgs e)
        {
            ListCategoryForm LiCt = new ListCategoryForm();
            LiCt.Show();
            this.Close();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
