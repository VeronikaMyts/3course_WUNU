using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using PassengerManagementSystem.DataAccess;
using PassengerManagementSystem.Models;
using System.Security.Cryptography;
using System.Text;

namespace PassengerManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository(new DatabaseContext());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsernameLogin.Text;
            var password = txtPasswordLogin.Text;

            // Перевірка на порожні значення
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Будь ласка, введіть ім'я користувача.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Будь ласка, введіть пароль.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на мінімальну кількість символів для логіну та паролю
            if (username.Length < 3 || username.Length > 20)
            {
                MessageBox.Show("Ім'я користувача повинно бути від 3 до 20 символів.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль повинен містити хоча б 6 символів.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка користувача в базі даних
            if (_userRepository.AuthenticateUser(username, password))
            {
                MessageBox.Show("Вхід успішний!");
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Недійсне ім'я користувача або пароль.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsernameRegister.Text;
            var password = txtPasswordRegister.Text;
            var email = txtEmailRegister.Text;
            var phoneNumber = txtPhoneNumberRegister.Text;

            // Перевірка на порожні значення
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Будь ласка, введіть ім'я користувача.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Будь ласка, введіть пароль.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Будь ласка, введіть електронну пошту.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на мінімальну та максимальну кількість символів для логіну та паролю
            if (username.Length < 3 || username.Length > 20)
            {
                MessageBox.Show("Ім'я користувача повинно бути від 3 до 20 символів.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль повинен містити хоча б 6 символів.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на коректність електронної пошти
            if (!email.Contains("@") || email.Length < 5)
            {
                MessageBox.Show("Невірна електронна пошта.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка, чи не зайнятий логін або email
            if (_userRepository.IsUsernameTaken(username))
            {
                MessageBox.Show("Ім'я користувача вже зайнято.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_userRepository.IsEmailTaken(email))
            {
                MessageBox.Show("Електронна пошта вже зайнята.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Хешуємо пароль перед збереженням
            string passwordHash = _userRepository.HashPassword(password);

            // Створення нового користувача
            var user = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                Email = email,
                PhoneNumber = phoneNumber,
                DateCreated = DateTime.Now
            };

            _userRepository.AddUser(user);
            MessageBox.Show("Реєстрація успішна!");
            tabControl1.SelectedTab = tabControl1.TabPages["Login"];
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

