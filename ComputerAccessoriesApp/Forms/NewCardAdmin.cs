using ComputerAccessoriesApp.Forms;
namespace ComputerAccessoriesApp
{
    public partial class CardAdmin : Form
    {
        Point LastPoint;
        Guid id;
        public CardAdmin()
        {
            InitializeComponent();
        }
        public CardAdmin(Guid id,string name, string category, string stock, string unit, string price, string purchaseprice, DateTime relevancemonth)
        {
            InitializeComponent();
            this.id = id;
            NameBox.Text = name;
            CategoryBox.Text = category;
            QuantityBox.Text = stock;
            UnitBox.Text = unit;
            PriceBox.Text = price;
            PurchasePriceBox.Text = purchaseprice;
            if (relevancemonth < DateTime.Now)
            {
                RelevanceBox.Text = (relevancemonth - DateTime.Now).ToString();
            }
            RelevanceBox.Text = relevancemonth.ToString();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                RelevanceBox.Text = product.ValidityMonths.ToString();
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            EditProduct edPr = new EditProduct(
                id,
                NameBox.Text,
                CategoryBox.Text,
                PriceBox.Text,
                this
            );
            this.Hide();
            edPr.Show();
            LoadProduct(id);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                var product = db.products.FirstOrDefault(p => p.id == id);
                if (product == null)
                {
                    return;
                }
                db.products.Remove(product);
                db.SaveChanges();
            }
            this.Close();
        }

        private void CardAdmin_VisibleChanged(object sender, EventArgs e)
        {
            LoadProduct(id);
        }
    }
}
