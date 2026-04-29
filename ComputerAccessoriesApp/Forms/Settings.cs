namespace ComputerAccessoriesApp
{
    public partial class Settings : Form
    {
        Form parentForm;
        Point LastPoint;

        public Settings(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            CurrencyBox.Items.Add("RUB");
            CurrencyBox.Items.Add("USD");
            CurrencyBox.SelectedIndex = 0;
        }
        private async Task<decimal> GetUsdRate()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");
            var data = System.Text.Json.JsonDocument.Parse(json);
            decimal rate = data.RootElement
                .GetProperty("Valute")
                .GetProperty("USD")
                .GetProperty("Value")
                .GetDecimal();
            return rate;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string currency = CurrencyBox.SelectedItem.ToString();
            decimal rate = 1;
            if (currency == "USD")
            {
                rate = await GetUsdRate();
            }
            using (var db = new DbContext())
            {
                var setting = db.currencysettings.FirstOrDefault();

                if (setting == null)
                {
                    db.currencysettings.Add(new CurrencySettings.CurrencySetting
                    {
                        id = Guid.NewGuid(),
                        currency_code = currency,
                        exchange_rate = rate,
                        updated = DateTime.UtcNow
                    });
                }
                else
                {
                    setting.currency_code = currency;
                    setting.exchange_rate = rate;
                    setting.updated = DateTime.UtcNow;
                }
                db.SaveChanges();
            }

            MessageBox.Show("Сохранено! Валюта: " + currency + ", Курс: " + rate);
            this.Close();
            parentForm.Show();
        }
        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}