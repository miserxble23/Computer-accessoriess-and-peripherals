using System.Data;
namespace ComputerAccessoriesApp
{
    public partial class Reports : Form
    {
        Point LastPoint;
        private Form parentForm;
        public Reports(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadProducts();
        }
        private void LoadProducts()
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
                    p.relevancemonth,
                    p.purchaseprice
                }).ToList();
                ProductsGridViewStorekep.DataSource = products;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new AuthorizationForm();
            form.Show();
            this.Close();
        }
        private void Reports_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void Reports_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void ProductsGridViewStorekep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = ProductsGridViewStorekep.Rows[e.RowIndex]; //[e.RowIndex] — берём строку по которой кликнули
            CardStorekep form = new CardStorekep(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(), //Cells - это ячейки строки
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()
            );
            form.Show();
        }
        private void SearchButtonStorekep_Click(object sender, EventArgs e)
        {
            var search = SearchBoxStorekep.Text;
            using (var db = new DbContext())
            {
                var products = db.products.Where(p => p.name.ToLower().Contains(search.ToLower())).Select(p => new
                {
                    p.name,
                    p.category,
                    p.stock,
                    p.unit,
                    p.Price
                }).ToList();
                ProductsGridViewStorekep.DataSource = products;
            }
        }
        private void DispatchButton_Click(object sender, EventArgs e)
        {
            var disp = new DispatchForm(this);
            disp.Show();
            this.Hide();
        }

    }
}
