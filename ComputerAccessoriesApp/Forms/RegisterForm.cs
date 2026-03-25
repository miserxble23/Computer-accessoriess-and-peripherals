using Users;
namespace ComputerAccessoriesApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        Point LastPoint;
        private void registerForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void registerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void AuthorizationButtonReg_Click(object sender, EventArgs e)
        {
            var form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }
        private void RegisterButtonReg_Click(object sender, EventArgs e)
        {
            const int MinPasswordLength = 6;
            const string adminCode = "admin123";
            string fullname = LoginBoxReg.Text;
            string password = PasswordBoxReg.Text;
            string code = CodeBoxReg.Text;
            bool isAdmin = false;
            if (password.Length < MinPasswordLength)
            {
                MessageBox.Show($"Пароль должен быть не менее {MinPasswordLength} символов");
                return;
            }
            if (string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }
            if (!string.IsNullOrEmpty(code))
            {
                if (code == adminCode)
                {
                    isAdmin = true;
                }
                else
                {
                    MessageBox.Show("Неверный код администратора");
                    return;
                }
            }
            string role = isAdmin ? "admin" : "storekeeper";
            using (var db = new AppDbContext())
            {
                bool userExists = db.Users.Any(u => u.username == fullname);

                if (userExists)
                {
                    MessageBox.Show("Пользователь уже существует!");
                    return;
                }
                User newUser = new User
                {
                    username = fullname,
                    password = password,
                    code = code,
                    role = role
                };
                db.Users.Add(newUser);
                db.SaveChanges();
            }
            MessageBox.Show("Регистрация успешна!");
            this.Hide();
            if (role == "admin")
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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
