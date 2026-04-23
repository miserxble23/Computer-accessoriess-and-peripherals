using ComputerAccessoriesApp.Forms;
using Supplies;
namespace ComputerAccessoriesApp
{
    public partial class SupplieForm : Form
    {
        private Form parentForm;
        private DateTime date = new DateTime(2000, 01, 01);
        Point LastPoint;
        public SupplieForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadProducts();
            date = this.date.ToUniversalTime();
        }
        private void SupplieForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        public virtual void LoadProducts()
        {
            using (var db = new DbContext())
            {
                var products = db.products.Select(p => new
                {
                    p.name,
                    p.category,
                    p.unit
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
                    p.unit,
                }).ToList();
                SupplieGridView.DataSource = products;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Валидация ввода
            if (string.IsNullOrWhiteSpace(QuantityBox.Text) ||
                string.IsNullOrWhiteSpace(PurchasePriceBox.Text) ||
                string.IsNullOrWhiteSpace(RelevanceBox.Text) ||
                string.IsNullOrWhiteSpace(DateBox.Text))
            {
                new InvalidValueForm().ShowDialog();
                return;
            }

            if (!int.TryParse(QuantityBox.Text, out int quantity) || quantity <= 0 ||
                !DateTime.TryParse(DateBox.Text, out DateTime date) || date > DateTime.Now ||
                !int.TryParse(RelevanceBox.Text, out int validity) || validity <= 0 ||
                !decimal.TryParse(PurchasePriceBox.Text, out decimal purchasePrice) || purchasePrice < 0)
            {
                new InvalidValueForm().ShowDialog();
                return;
            }
            // Получаем выбранный товар из грида
            if (SupplieGridView.CurrentRow?.Index < 0) return;
            var row = SupplieGridView.CurrentRow;
            var productName = row.Cells["ProductNameColumn"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(productName)) return;

            // Проверяем, нет ли уже этого товара в корзине
            foreach (DataGridViewRow basketRow in BasketGridView.Rows)
            {
                if (basketRow.Cells["Namee"].Value?.ToString() == productName)
                {
                    // Увеличиваем количество
                    var currentQty = int.Parse(basketRow.Cells["Quantityy"].Value.ToString());
                    basketRow.Cells["Quantityy"].Value = currentQty + quantity;
                    basketRow.Cells["Pricee"].Value = purchasePrice; // Фиксируем закупочную цену!
                    return;
                }
            }

            // Добавляем новую строку в корзину
            BasketGridView.Rows.Add(productName, quantity, purchasePrice, validity, date);

            // Очищаем поля ввода
            QuantityBox.Clear();
            PurchasePriceBox.Clear();
            RelevanceBox.Clear();
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "CSV files|*.csv|All files|*.*",
                Title = "Выберите файл импорта"
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var lines = File.ReadAllLines(dlg.FileName).Skip(1); // Пропускаем заголовок
                    int imported = 0;

                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length < 4) continue; // Минимум: name, quantity, price, date

                        var productName = parts[0].Trim();
                        if (!int.TryParse(parts[1], out int quantity)) continue;
                        if (!decimal.TryParse(parts[2], out decimal price)) continue;
                        if (!DateTime.TryParse(parts[3], out DateTime supplyDate)) continue;

                        // Ищем товар в БД
                        using (var db = new DbContext())
                        {
                            var product = db.products.FirstOrDefault(p => p.name == productName);
                            if (product == null) continue;

                            // Обновляем остаток и фиксируем закупочную цену
                            product.stock += quantity;
                            product.purchaseprice = price; // ФИКСИРУЕМ цену закупки!
                            product.suppliedate = supplyDate;

                            // Если есть 5-й столбец - это срок годности
                            if (parts.Length > 4 && int.TryParse(parts[4], out int expDate))
                            {
                                product.ValidityMonths = expDate;
                            }

                            db.SaveChanges();
                            imported++;
                        }
                    }

                    MessageBox.Show($"Успешно импортировано {imported} записей", "Импорт",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts(); // Обновляем грид
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка импорта: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (BasketGridView.Rows.Count == 0) return;

            // Подтверждение
            var confirmForm = new ConfirmationForm();
            confirmForm.ShowDialog();
            if (!confirmForm.IsConfirmed) return;

            using (var db = new DbContext()) // Или ваш контекст
            {
                foreach (DataGridViewRow row in BasketGridView.Rows)
                {
                    if (row.Cells["Namee"].Value == null) continue;

                    string prodName = (string)row.Cells["Namee"].Value;
                    int qty = (int)row.Cells["Quantityy"].Value;
                    decimal purchasePrice = (decimal)row.Cells["Pricee"].Value;
                    int validity = (int)row.Cells["Validity"].Value;
                    DateTime suppliedate = (DateTime)row.Cells["SupplieDate"].Value;

                    var product = db.products.FirstOrDefault(p => p.name == prodName);
                    if (product != null)
                    {
                        product.stock += qty;

                        product.purchaseprice = purchasePrice;

                        product.suppliedate = suppliedate.ToUniversalTime();

                        product.ValidityMonths = validity;

                        db.supplies.Add(new Supplie
                        {
                            id = Guid.NewGuid(),
                            product_id = product.id,
                            quantity = qty,
                            purchase_price = purchasePrice, // Исправленное имя!
                            supply_date = DateTime.Now.ToUniversalTime(),
                            relevance_until = validity
                        });
                    }
                }
                db.SaveChanges();
            }
            BasketGridView.Rows.Clear();
            var result = new ResultDispatchForm();
            result.ShowDialog();
            LoadProducts(); // Обновите ваш метод загрузки грида
        }
        private void NewCardButton_Click(object sender, EventArgs e)
        {
            var crPr = new CreateProduct(this);
            crPr.Show();
            this.Hide();
        }
        private void SupplieForm_Activated(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
