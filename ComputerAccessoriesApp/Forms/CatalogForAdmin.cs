using ComputerAccessoriesApp.Forms;
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
                var products = db.products.Select(p => new
                {
                    p.name,
                    p.category,
                    p.stock,
                    p.unit,
                    p.Price,
                    p.purchaseprice,
                    p.ValidityStatus,
                    p.suppliedate
                }).ToList();
                ProductsGridViewAdmin.DataSource = products;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new AuthorizationForm();
            form.Show();
            this.Close();
            //Application.Exit();
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
            if (e.RowIndex < 0) return;
            var row = ProductsGridViewAdmin.Rows[e.RowIndex]; //[e.RowIndex] — берём строку по которой кликнули
            CardAdmin form = new CardAdmin(
                row.Cells[0].Value.ToString(),//Cells - это ячейки строки
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
                var products = db.products.Where(p => p.name.ToLower().Contains(search.ToLower())).Select(p => new
                {
                    p.name,
                    p.category,
                    p.stock,
                    p.unit,
                    p.Price,
                    p.purchaseprice
                }).ToList();
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
    }
}
