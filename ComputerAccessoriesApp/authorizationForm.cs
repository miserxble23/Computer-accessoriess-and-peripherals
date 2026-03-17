using Npgsql;

namespace ComputerAccessoriesApp
{
    public partial class AuthorizationForm : Form
    {
        private string sqlConn = "Server=localhost;Port=1234;Username=postgres;Password=230907;Database=users_db";
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
            string username = LoginBoxAutho.Text;
            string password = PasswordBoxAutho.Text;
            var conn = new NpgsqlConnection(sqlConn);

            conn.Open();
            string query = "SELECT role FROM users WHERE username = @username AND password = @password";
            var cmd = new NpgsqlCommand(query, conn); //NpgsqlCommand- получить одно значение

            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            var role = cmd.ExecuteScalar(); //ExecuteSlacar-это метод который выполняет sql запрос и возвращает только одно значение
            if (role == null)
            {
                var errorForm = new ErrorForm();
                errorForm.ShowDialog();
                return;
            }
            this.Hide();
            if (role.ToString() == "admin")
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
}
