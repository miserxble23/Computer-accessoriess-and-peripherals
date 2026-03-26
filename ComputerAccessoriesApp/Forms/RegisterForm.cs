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
            var fullname = LoginBoxReg.Text;
            var password = PasswordBoxReg.Text;
            var code = CodeBoxReg.Text;
            var isAdmin = false;
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
            var role = isAdmin ? "admin" : "storekeeper";
            var hashedPassword = PasswordHelper.HashPassword(password);
            using (var db = new DbContext())
            {
                var userExists = db.users.Any(u => u.username == fullname);
                if (userExists)
                {
                    MessageBox.Show("Пользователь уже существует!");
                    return;
                }
                User newUser = new User
                {
                    username = fullname,
                    password = hashedPassword,
                    code = code,
                    role = role
                };
                db.users.Add(newUser);
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
