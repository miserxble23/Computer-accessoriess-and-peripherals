using ComputerAccessoriesApp.Forms;
namespace ComputerAccessoriesApp
{
    public partial class CardAdmin : Form
    {
        Point LastPoint;
        private Guid _id;
        public CardAdmin()
        {
            InitializeComponent();
        }
        public CardAdmin(string name, string category, string stock, string unit, string price, string relevancemonth, string purchaseprice)
        {
            InitializeComponent();
            NameBox.Text = name;
            CategoryBox.Text = category;
            QuantityBox.Text = stock;
            UnitBox.Text = unit;
            PriceBox.Text = price;
            PurchasePriceBox.Text = purchaseprice;
            RelevanceBox.Text = relevancemonth;
        }
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
        private void LoadProduct(Guid id)
        {
            using (var db = new DbContext())
            {
                var product = db.products.FirstOrDefault(p => p.id == id);
                if (product == null)
                {
                    return;
                }
                NameBox.Text = product.name;
                QuantityBox.Text = product.stock.ToString();
                CategoryBox.Text = product.category;
                PriceBox.Text = product.Price.ToString();
                PurchasePriceBox.Text = product.purchaseprice.ToString();
                RelevanceBox.Text = product.relevancemonth.ToString();
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            EditProduct edPr = new EditProduct(
                _id,
                NameBox.Text,
                CategoryBox.Text,
                PriceBox.Text
            );
            this.Hide();
            edPr.ShowDialog();
            LoadProduct(_id);
            this.Show();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                var product = db.products.FirstOrDefault(p => p.id == _id);
                if (product == null)
                {
                    return;
                }
                db.products.Remove(product);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
