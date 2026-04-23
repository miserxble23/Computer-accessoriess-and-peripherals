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
        //db.products.FirstOrDefault(s => s.id == p.product_id).name
        private void LoadProducts()
        {
            using (var db = new DbContext())
            {
                var reports = db.shipments.Select(p => new
                {
                    p.shipment_date,
                    p.customer,
                    p.product_id,
                    p.quantity,
                    p.saleprice,
                    p.purchaseprice,
                    p.impactsum
                }).ToList();
                ReportsGridView.DataSource = reports;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            parentForm.Show();
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
        /*
        private void ProductsGridViewStorekep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = ReportsGridView.Rows[e.RowIndex]; //[e.RowIndex] — берём строку по которой кликнули
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
        */
        private void FilterButton_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);
            string customer = FilterBox.Text;
            using (var db = new DbContext())
            {
                var reports = db.shipments.Where(s => s.shipment_date >= start && s.shipment_date <= end && s.customer.ToLower().Contains(customer.ToLower())).Select(s => new
                    {
                        Date = s.shipment_date.ToString("dd.MM.yyyy"),
                        Customer = s.customer,
                        ProductName = db.products.FirstOrDefault(p => p.id == s.product_id).name,
                        Qty = s.quantity,
                        // Цена продажи (из отгрузки)
                        SalePrice = s.saleprice, // Исправленное имя!
                                                  // Цена закупки (берем из товара на момент отгрузки или текущую)
                        BuyPrice = db.products.FirstOrDefault(p => p.id == s.product_id).purchaseprice,

                        // Расчеты
                        Sum = s.saleprice,
                        // Прибыль = (Продажа - Закупка) * Кол-во
                        Profit = (s.saleprice - db.products.FirstOrDefault(p => p.id == s.product_id).purchaseprice) * s.quantity
                    })
                    .ToList();
                ReportsGridView.DataSource = reports;
                var totalProfit = reports.Sum(x => x.Profit);
                TotalBox.Text = $"Итого:{totalProfit:F2}руб.";
            }
        }
    }
}
