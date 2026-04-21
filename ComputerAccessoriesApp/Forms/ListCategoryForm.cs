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
            using (var db = new DbContext())
            {
                var categories = db.categories.Select(c => new
                {
                    c.name
                }).ToList();
                ListCategoryGridView.DataSource = categories;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (parentCreate != null)
            {
                parentCreate.LoadElementsToCategoryBox();
                parentCreate.Show();
            }
            this.Close();
        }
        private void ListCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private Guid selectedCategoryId = Guid.Empty;
        private void ListCategoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = ListCategoryGridView.Rows[e.RowIndex];
            NameBox.Text = row.Cells[0].Value.ToString();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == Guid.Empty)
            {
                return;
            }
            using (var db = new DbContext())
            {
                var category = db.categories.FirstOrDefault(c => c.id == selectedCategoryId);
                if (category == null)
                {
                    return;
                }
                category.name = NameBox.Text;
                db.SaveChanges();
            }
            LoadCategories();
            NameBox.Clear();
            selectedCategoryId = Guid.Empty;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == Guid.Empty)
            {
                return;
            }
            using (var db = new DbContext())
            {
                var category = db.categories.FirstOrDefault(c => c.id == selectedCategoryId);
                if (category == null)
                {
                    return;
                }
                var isUsed = db.products.Any(p => p.category == category.name);
                if (isUsed)
                {
                    MessageBox.Show("Нельзя удалить категорию — она используется в товарах!");
                    return;
                }
                db.categories.Remove(category);
                db.SaveChanges();
            }
            LoadCategories();
            NameBox.Clear();
            selectedCategoryId = Guid.Empty;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectedCategoryId = Guid.Empty;
            NameBox.Clear();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            var search = FindBox.Text.ToLower();
            using (var db = new DbContext())
            {
                var categories = db.categories.Where(c => c.name.ToLower().Contains(search)).Select(c => new
                    {
                        c.id,
                        c.name
                    }).ToList();
                ListCategoryGridView.DataSource = categories;
            }
        }
        private void NewCategoryButton_Click(object sender, EventArgs e)
        {
            var caterogy = new NewCaterogy(this);
            caterogy.Show();
            this.Hide();
        }
    }
}
