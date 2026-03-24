using ComputerAccessoriesApp.Forms;
namespace ComputerAccessoriesApp
{
    public partial class CardAdmin : Form
    {
        public CardAdmin()
        {
            InitializeComponent();
        }
        public CardAdmin(string id, string name, string category, string stock, string unit, string price)
        {
            InitializeComponent();
            IDBox.Text = id;
            NameBox.Text = name;
            CategoryBox.Text = category;
            StockBox.Text = stock;
            UnitBox.Text = unit;
            PriceBox.Text = price;
        }
        Point LastPoint;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CardAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void CardAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void LoadProduct(int id)
        {
            using (var db = new ProductsDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.id == id);
                if (product == null)
                    return;

                IDBox.Text = product.id.ToString();
                NameBox.Text = product.name;
                CategoryBox.Text = product.category;
                StockBox.Text = product.stock.ToString();
                UnitBox.Text = product.unit;
                PriceBox.Text = product.Price.ToString();
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDBox.Text, out int id))
                return;
            EditProduct edPr = new EditProduct(
                id,
                NameBox.Text,
                CategoryBox.Text,
                UnitBox.Text,
                PriceBox.Text
            );
            this.Hide();
            edPr.ShowDialog();
            LoadProduct(id);
            this.Show();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDBox.Text, out int id))
            {
                return;
            }
            using (var db = new ProductsDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.id == id);
                if (product == null)
                    return;
                db.Products.Remove(product);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
