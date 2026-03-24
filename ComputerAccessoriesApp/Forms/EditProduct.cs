using Products;

namespace ComputerAccessoriesApp.Forms
{
    public partial class EditProduct : Form
    {
        Point LastPoint;
        private int productId;
        public EditProduct()
        {
            InitializeComponent();
        }
        public EditProduct(int id, string name, string category, string unit, string price)
        {
            InitializeComponent();
            productId = id;
            NameBox.Text = name;
            CategoryBox.Text = category;
            UnitBox.Text = unit;
            PriceBox.Text = price;
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
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var db = new ProductsDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.id == productId);
                if (product == null)
                    return;

                product.name = NameBox.Text;
                product.category = CategoryBox.Text;
                product.unit = UnitBox.Text;

                if (decimal.TryParse(PriceBox.Text, out decimal price))
                {
                    product.Price = price;
                }
                else
                {
                    return;
                }
                db.SaveChanges();
            }

            this.Close();
        }
        private void ListCategoryButton_Click(object sender, EventArgs e)
        {
            ListCategoryForm list = new ListCategoryForm();
            list.ShowDialog();
            this.Hide();
        }
    }
}
