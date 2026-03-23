namespace ComputerAccessoriesApp
{
    public partial class DispatchForm : Form
    {
        private Form parentForm;
        Point LastPoint;
        public DispatchForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadProducts();
        }
        private void DispatchForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void LoadProducts()
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
                    p.price
                }).ToList();
                DispatchGridView.DataSource = products;
            }
        }
        private void DispatchForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            string search = FindBox.Text;

            using (var db = new ProductsDbContext())
            {
                var products = db.Products.Where(p => p.name.ToLower().Contains(search.ToLower())).Select(p => new
                {
                    p.id,
                    p.name,
                    p.category,
                    p.stock,
                    p.unit,
                    p.price
                }).ToList();
                DispatchGridView.DataSource = products;
            }
        }
        private void DispatchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = DispatchGridView.Rows[e.RowIndex]; //[e.RowIndex] — берём строку по которой кликнули
            string name = row.Cells["ProductNameColumn"].Value.ToString(); //Cells - это ячейки строки
            string stockText = row.Cells["Quantity"].Value.ToString(); //Cells - это ячейки строки
            string price = row.Cells["Price"].Value.ToString(); //Cells - это ячейки строки
            if (!int.TryParse(stockText, out int stock)) return;
            if (stock <= 0) return;
            for (int i = 0; i < BasketGridView.Rows.Count; i++)
            {
                if (BasketGridView.Rows[i].Cells["Namee"].Value == null) continue;
                if (BasketGridView.Rows[i].Cells["Namee"].Value.ToString() == name)
                {
                    string countText = BasketGridView.Rows[i].Cells["Quantityy"].Value.ToString();
                    if (!int.TryParse(countText, out int count)) return;
                    if (count < stock)
                    {
                        BasketGridView.Rows[i].Cells["Quantityy"].Value = count + 1;
                    }
                    return;
                }
            }
            BasketGridView.Rows.Add(name, 1, price);
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            ConfirmationForm confirm = new ConfirmationForm();
            confirm.ShowDialog();
            if (!confirm.IsConfirmed) return;

            using (var db = new ProductsDbContext())
            {
                for (int i = 0; i < BasketGridView.Rows.Count; i++)
                {
                    if (BasketGridView.Rows[i].Cells["Namee"].Value == null) continue;
                    string name = BasketGridView.Rows[i].Cells["Namee"].Value.ToString();
                    string countText = BasketGridView.Rows[i].Cells["Quantityy"].Value.ToString();
                    if (!int.TryParse(countText, out int count)) continue;
                    var product = db.Products.FirstOrDefault(p => p.name == name);
                    if (product == null) continue;
                    if (product.stock < count)
                    {
                        ErrorForDispatchFor error = new ErrorForDispatchFor();
                        error.ShowDialog();
                        return;
                    }
                }
                for (int i = 0; i < BasketGridView.Rows.Count; i++)
                {
                    if (BasketGridView.Rows[i].Cells["Namee"].Value == null) continue;
                    string name = BasketGridView.Rows[i].Cells["Namee"].Value.ToString();
                    string countText = BasketGridView.Rows[i].Cells["Quantityy"].Value.ToString();
                    if (!int.TryParse(countText, out int count)) continue;
                    var product = db.Products.FirstOrDefault(p => p.name == name);
                    if (product == null) continue;
                    product.stock -= count;
                }
                db.SaveChanges();
            }
            BasketGridView.Rows.Clear();
            LoadProducts();
            ResultDispatchForm result = new ResultDispatchForm();
            result.ShowDialog();
        }
    }
}
