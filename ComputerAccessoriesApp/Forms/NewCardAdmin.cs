namespace ComputerAccessoriesApp
{
    public partial class CardAdmin : Form
    {
        public CardAdmin()
        {
            InitializeComponent();
        }
        public CardAdmin(string id, string name, string category, string stock, string unit, string price)
        {
            InitializeComponent();
            IDBox.Text = id;
            NameBox.Text = name;
            CategoryBox.Text = category;
            StockBox.Text = stock;
            UnitBox.Text = unit;
            PriceBox.Text = price;
        }
        Point LastPoint;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
