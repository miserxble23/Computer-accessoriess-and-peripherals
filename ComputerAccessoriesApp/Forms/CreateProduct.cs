using Products;
namespace ComputerAccessoriesApp.Forms
{
    public partial class CreateProduct : Form
    {
        Point LastPoint;
        private CatalogForAdmin parentForm;
        public CreateProduct(CatalogForAdmin form)
        {
            InitializeComponent();
            parentForm = form;
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
            parentForm.Show();
            this.Close();
        }
        public void SetCategory(string category)
        {
            CategoryBox.Text = category;
        }
        private void ListCategoryButton_Click(object sender, EventArgs e)
        {
            ListCategoryForm LiCt = new ListCategoryForm(this);
            LiCt.Show();
            this.Hide();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(CategoryBox.Text) ||
                string.IsNullOrWhiteSpace(UnitBox.Text) ||
                string.IsNullOrWhiteSpace(PriceBox.Text))
            {
                return;
            }
            if (!decimal.TryParse(PriceBox.Text, out decimal price) || price < 0)
            {
                ErrorForm error = new ErrorForm();
                error.ShowDialog();
                return;
            }
            ConfirmationForm confirm = new ConfirmationForm();
            confirm.ShowDialog();
            if (!confirm.IsConfirmed)
                return;
            using (var db = new ProductsDbContext())
            {
                Product product = new Product
                {
                    name = NameBox.Text,
                    category = CategoryBox.Text,
                    stock = 0,
                    unit = UnitBox.Text,
                    Price = price
                };
                db.Products.Add(product);
                db.SaveChanges();
            }
            ResultDispatchForm result = new ResultDispatchForm();
            result.ShowDialog();
            parentForm.Show();
            parentForm.RefreshProducts();
            this.Close();
        }
    }
}
