namespace ComputerAccessoriesApp
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        Point LastPoint;
        private void authorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void authorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            form.Show();
            this.Hide();
        }
        private void EnterButtonAutho_Click(object sender, EventArgs e)
        {
            var username = LoginBoxAutho.Text;
            var password = PasswordBoxAutho.Text;
            var hashedPassword = PasswordHelper.HashPassword(password);
            using (var db = new DbContext())
            {
                var user = db.users.FirstOrDefault(u => u.username == username && u.password == hashedPassword);
                if (user == null)
                {
                    var errorForm = new ErrorForm();
                    errorForm.ShowDialog();
                    return;
                }
                this.Hide();
                if (user.role == "admin")
                {
                    var form = new CatalogForAdmin();
                    form.Show();
                } 
                else
                {
                    var form = new CatalogForStorekeepers();
                    form.Show();
                }
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
