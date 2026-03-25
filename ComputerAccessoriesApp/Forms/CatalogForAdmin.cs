using ComputerAccessoriesApp.Forms;
using System.Data;
namespace ComputerAccessoriesApp
{
    public partial class CatalogForAdmin : Form
    {
        Point LastPoint;
        public CatalogForAdmin()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            using (var db = new ProductsDbContext())
            {
                var products = db.Products.Select(p => new
                {
                    p.id,
                    p.name,
                    p.category,
                    p.stock,
                    p.unit,
                    p.Price
                }).ToList();
                ProductsGridViewAdmin.DataSource = products;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void CatalogForAdmin_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void ProductsGridViewAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = ProductsGridViewAdmin.Rows[e.RowIndex]; //[e.RowIndex] — берём строку по которой кликнули
            CardAdmin form = new CardAdmin(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString()); //Cells - это ячейки строки
            form.Show();
        }
        private void SearchButtonAdmin_Click(object sender, EventArgs e)
        {
            string search = SearchBoxAdmin.Text;

            using (var db = new ProductsDbContext())
            {
                var products = db.Products.Where(p => p.name.ToLower().Contains(search.ToLower())).Select(p => new
                {
                    p.id,
                    p.name,
                    p.category,
                    p.stock,
                    p.unit,
                    p.Price
                }).ToList();
                ProductsGridViewAdmin.DataSource = products;
            }
        }
        private void DispatchButton_Click(object sender, EventArgs e)
        {
            DispatchForm disp = new DispatchForm(this);
            disp.Show();
            this.Hide();
        }
        private void NewCardButton_Click(object sender, EventArgs e)
        {
            CreateProduct crPr = new CreateProduct(this);
            crPr.Show();
            this.Hide();
        }
    }
}
