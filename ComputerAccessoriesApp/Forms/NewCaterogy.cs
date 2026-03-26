using Products;
namespace ComputerAccessoriesApp.Forms
{
    public partial class NewCaterogy : Form
    {
        Point LastPoint;
        private ListCategoryForm parentForm;
        public NewCaterogy(ListCategoryForm form)
        {
            InitializeComponent();
            parentForm = form;
        }
        private void NewCaterogy_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void NewCaterogy_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginBoxReg.Text))
            {
                MessageBox.Show("Введите название");
                return;
            }
            using (var db = new DbContext())
            {
                var exists = db.categories.Any(c => c.name.ToLower() == LoginBoxReg.Text.ToLower());
                if (exists)
                {
                    MessageBox.Show("Такая категория уже существует!");
                    return;
                }
                var category = new Category
                {
                    id = Guid.NewGuid(),
                    name = LoginBoxReg.Text
                };
                db.categories.Add(category);
                db.SaveChanges();
            }
            var result = new ResultDispatchForm();
            result.ShowDialog();
            parentForm.LoadCategories();
            parentForm.Show();
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.ShowDialog();
        }
    }
}
