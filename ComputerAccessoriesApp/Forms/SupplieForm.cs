namespace ComputerAccessoriesApp
{
    public partial class SupplieForm : Form
    {
        private Form parentForm;
        Point LastPoint;
        public SupplieForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadProducts();
        }
        private void SupplieForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
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
                    p.Price
                }).ToList();
                SupplieGridView.DataSource = products;
            }
        }
        private void SupplieForm_MouseMove(object sender, MouseEventArgs e)
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
            var search = FindBox.Text;

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
                SupplieGridView.DataSource = products;
            }
        }
        private void SupplieGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = SupplieGridView.Rows[e.RowIndex]; //[e.RowIndex] — берём строку по которой кликнули
            var name = row.Cells["ProductNameColumn"].Value.ToString(); //Cells - это ячейки строки
            var stockText = row.Cells["Quantity"].Value.ToString(); //Cells - это ячейки строки
            var price = row.Cells["Price"].Value.ToString(); //Cells - это ячейки строки
            if (!int.TryParse(stockText, out int stock))
            {
                return;
            }
            if (stock <= 0)
            {
                return;
            }
            for (int i = 0; i < BasketGridView.Rows.Count; i++)
            {
                if (BasketGridView.Rows[i].Cells["Namee"].Value == null)
                {
                    continue;
                }
                if (BasketGridView.Rows[i].Cells["Namee"].Value.ToString() == name)
                {
                    string countText = BasketGridView.Rows[i].Cells["Quantityy"].Value.ToString();
                    if (!int.TryParse(countText, out int count))
                    {
                        return;
                    }
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
            var confirm = new ConfirmationForm();
            confirm.ShowDialog();
            if (!confirm.IsConfirmed)
            {
                return;
            }
            using (var db = new DbContext())
            {
                for (int i = 0; i < BasketGridView.Rows.Count; i++)
                {
                    if (BasketGridView.Rows[i].Cells["Namee"].Value == null)
                    {
                        continue;
                    }
                    string name = BasketGridView.Rows[i].Cells["Namee"].Value.ToString();
                    string countText = BasketGridView.Rows[i].Cells["Quantityy"].Value.ToString();
                    if (!int.TryParse(countText, out int count))
                    {
                        continue;
                    }
                    var product = db.products.FirstOrDefault(p => p.name == name);
                    if (product == null)
                    {
                        continue;
                    }
                    if (product.stock < count)
                    {
                        ErrorForDispatchFor error = new ErrorForDispatchFor();
                        error.ShowDialog();
                        return;
                    }
                }
                for (int i = 0; i < BasketGridView.Rows.Count; i++)
                {
                    if (BasketGridView.Rows[i].Cells["Namee"].Value == null)
                    {
                        continue;
                    }
                    var name = BasketGridView.Rows[i].Cells["Namee"].Value.ToString();
                    var countText = BasketGridView.Rows[i].Cells["Quantityy"].Value.ToString();
                    if (!int.TryParse(countText, out int count))
                    {
                        continue;
                    }
                    var product = db.products.FirstOrDefault(p => p.name == name);
                    if (product == null)
                    {
                        continue;
                    }
                    product.stock -= count;
                }
                db.SaveChanges();
            }
            BasketGridView.Rows.Clear();
            LoadProducts();
            var result = new ResultDispatchForm();
            result.ShowDialog();
        }
    }
}
