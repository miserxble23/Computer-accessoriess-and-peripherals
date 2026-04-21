using Products;
namespace ComputerAccessoriesApp.Forms
{
    public partial class CreateProduct : Form
    {
        Point LastPoint;
        private ComputerAccessoriesApp.CatalogForAdmin parentForm;
        public CreateProduct(ComputerAccessoriesApp.CatalogForAdmin form)
        {
            InitializeComponent();
            parentForm = form;
            this.Load += CreateProduct_Load;
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            LoadElementsToCategoryBox();
        }
        public void LoadElementsToCategoryBox()
        {
            using (var db = new DbContext())
            {
                List<string> products = db.categories.Select(p => p.name).ToList();
                CategoryBox.DataSource = products;
            }
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
            var LiCt = new ListCategoryForm(this);
            LiCt.Show();
            this.Hide();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(CategoryBox.Text) ||
                string.IsNullOrWhiteSpace(PriceBox.Text))
            {
                return;
            }
            if (!decimal.TryParse(PriceBox.Text, out decimal price) || price < 0)
            {
                var error = new ErrorForm();
                error.ShowDialog();
                return;
            }
            ConfirmationForm confirm = new ConfirmationForm();
            confirm.ShowDialog();
            if (!confirm.IsConfirmed)
            {
                return;
            }
            using (var db = new DbContext())
            {
                var product = new Product
                {
                    name = NameBox.Text,
                    category = CategoryBox.Text,
                    stock = 0,
                    unit = "шт.",
                    Price = price
                };
                db.products.Add(product);
                db.SaveChanges();
            }
            var result = new ResultDispatchForm();
            result.ShowDialog();
            parentForm.Show();
            parentForm.LoadProducts();
            this.Close();
        }
    }
}
