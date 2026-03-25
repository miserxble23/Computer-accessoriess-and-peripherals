namespace ComputerAccessoriesApp.Forms
{
    public partial class ListCategoryForm : Form
    {
        Point LastPoint;
        private CreateProduct parentCreate;
        public ListCategoryForm(CreateProduct createForm)
        {
            InitializeComponent();
            parentCreate = createForm;
        }
        public ListCategoryForm()
        {
            InitializeComponent();
        }
        private void ListCategoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void ListCategoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        public void LoadCategories()
        {
            using (var db = new ProductsDbContext())
            {
                var categories = db.Categories.Select(c => new
                {
                    c.id,
                    c.name
                }).ToList();
                ListCategoryGridView.DataSource = categories;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (parentCreate != null)
            {
                parentCreate.Show();
            }
            this.Close();
        }
        private void ListCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private int selectedCategoryId = -1;
        private void ListCategoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = ListCategoryGridView.Rows[e.RowIndex];
            selectedCategoryId = Convert.ToInt32(row.Cells[0].Value);
            NameBox.Text = row.Cells[1].Value.ToString();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == -1)
            {
                return;
            }
            using (var db = new ProductsDbContext())
            {
                var category = db.Categories.FirstOrDefault(c => c.id == selectedCategoryId);
                if (category == null)
                {
                    return;
                }
                category.name = NameBox.Text;
                db.SaveChanges();
            }
            LoadCategories();
            NameBox.Clear();
            selectedCategoryId = -1;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == -1)
            {
                return;
            }
            using (var db = new ProductsDbContext())
            {
                var category = db.Categories.FirstOrDefault(c => c.id == selectedCategoryId);
                if (category == null)
                {
                    return;
                }
                db.Categories.Remove(category);
                db.SaveChanges();
            }
            LoadCategories();
            NameBox.Clear();
            selectedCategoryId = -1;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectedCategoryId = -1;
            NameBox.Clear();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            string search = FindBox.Text.ToLower();
            using (var db = new ProductsDbContext())
            {
                var categories = db.Categories.Where(c => c.name.ToLower().Contains(search)).Select(c => new
                    {
                        c.id,
                        c.name
                    }).ToList();
                ListCategoryGridView.DataSource = categories;
            }
        }
        private void NewCategoryButton_Click(object sender, EventArgs e)
        {
            NewCaterogy caterogy = new NewCaterogy(this);
            caterogy.Show();
            this.Hide();
        }
    }
}
