using ComputerAccessoriesApp.Forms;
using System.Xml.Linq;
namespace ComputerAccessoriesApp
{
    public partial class CatalogForAdmin : Form
    {
        Point LastPoint;
        public CatalogForAdmin()
        {
            InitializeComponent();
            LoadProducts();
        }

        public virtual void LoadProducts()
        {
            using (var db = new DbContext())
            {
                var setting = db.currencysettings.FirstOrDefault();
                decimal rate = 1;
                string currencyCode = "RUB";

                if (setting != null)
                {
                    rate = setting.exchange_rate;
                    currencyCode = setting.currency_code;
                }

                var allProducts = db.products.ToList();
                var products = new List<object>();

                foreach (var p in allProducts)
                {
                    decimal price = currencyCode == "USD" ? Math.Round(p.Price / rate, 2) : p.Price;
                    decimal purchaseprice = currencyCode == "USD" ? Math.Round(p.purchaseprice / rate, 2) : p.purchaseprice;

                    products.Add(new
                    {
                        p.name,
                        p.category,
                        p.stock,
                        p.unit,
                        Price = price,
                        purchaseprice = purchaseprice,
                        p.ValidityStatus,
                        p.suppliedate
                    });
                }

                ProductsGridViewAdmin.DataSource = products;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new AuthorizationForm();
            form.Show();
            this.Close();
        }

        private void CatalogForAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void CatalogForAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void ProductsGridViewAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id;
            if (e.RowIndex < 0) return;
            var row = ProductsGridViewAdmin.Rows[e.RowIndex];
            using (var db = new DbContext())
            {
                var product = db.products.FirstOrDefault(p => p.name == row.Cells[0].Value.ToString());
                id = product.id;
            }
            CardAdmin form = new CardAdmin(
                id,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                (DateTime)row.Cells[7].Value
            );
            form.Show();
        }
        private void SearchButtonAdmin_Click(object sender, EventArgs e)
        {
            var search = SearchBoxAdmin.Text;

            using (var db = new DbContext())
            {
                var setting = db.currencysettings.FirstOrDefault();
                decimal rate = 1;
                string currencyCode = "RUB";

                if (setting != null)
                {
                    rate = setting.exchange_rate;
                    currencyCode = setting.currency_code;
                }
                var allProducts = db.products.ToList();
                var products = new List<object>();
                foreach (var p in allProducts)
                {
                    if (p.name.ToLower().Contains(search.ToLower()))
                    {
                        decimal price = currencyCode == "USD" ? Math.Round(p.Price / rate, 2) : p.Price;
                        decimal purchaseprice = currencyCode == "USD" ? Math.Round(p.purchaseprice / rate, 2) : p.purchaseprice;
                        products.Add(new
                        {
                            p.name,
                            p.category,
                            p.stock,
                            p.unit,
                            Price = price,
                            purchaseprice = purchaseprice,
                            p.ValidityStatus,
                            p.suppliedate
                        });
                    }
                }

                ProductsGridViewAdmin.DataSource = products;
            }
        }

        private void SupplieButton_Click(object sender, EventArgs e)
        {
            var supp = new SupplieForm(this);
            supp.Show();
            this.Hide();
        }

        private void NewCardButton_Click(object sender, EventArgs e)
        {
            var crPr = new CreateProduct(this);
            crPr.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            var repo = new Reports(this);
            repo.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var set = new Settings(this);
            set.Show();
            this.Hide();
        }

        private void CatalogForAdmin_VisibleChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void CatalogForAdmin_Activated(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}