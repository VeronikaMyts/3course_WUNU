using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PassengerManagementSystem.DataAccess;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.Forms
{
    public partial class PassengerForm : Form
    {
        private readonly PassengersRepository _passengerRepository;
        private List<Passenger> _currentPassengerList = new List<Passenger>();

        public PassengerForm()
        {
            InitializeComponent();
            this.Load += PassengerForm_Load;
            _passengerRepository = new PassengersRepository(/*new DatabaseContext()*/);
        }

        // Завантаження пасажирів при завантаженні форми
        private void PassengerForm_Load(object sender, EventArgs e)
        {
            LoadPassengers();
            dataGridViewPassengers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Завантаження пасажирів у DataGridView
        private void LoadPassengers()
        {
            var passengers = _passengerRepository.GetAllPassengers();
            dataGridViewPassengers.DataSource = passengers;
            dataGridViewPassengers.AutoGenerateColumns = false;
            dataGridViewPassengers.Columns["PassengerID"].Visible = false;
            dataGridViewPassengers.Refresh(); // Перезавантажуємо DataGridView
        }

        // Додавання нового пасажира
        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var passportNumber = txtPassportNumber.Text;
            var email = txtEmail.Text;
            var contactNumber = txtContactNumber.Text;

            // Перевірка на порожні значення
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(passportNumber) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створення нового пасажира
            var passenger = new Passenger
            {
                FirstName = firstName,
                LastName = lastName,
                PassportNumber = passportNumber,
                Email = email,
                ContactNumber = contactNumber
            };

            _passengerRepository.AddPassenger(passenger);
            MessageBox.Show("Пасажир доданий успішно!");
            LoadPassengers(); // Оновлюємо список пасажирів після додавання
        }

        // Видалення пасажира
        private void btnDeletePassenger_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPassengers.CurrentRow?.DataBoundItem is Passenger selectedPassenger)
            {
                _passengerRepository.DeletePassenger(selectedPassenger.PassengerID);
                LoadPassengers();
            }
        }

        // Редагування пасажира
        private void btnEditPassenger_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPassengers.CurrentRow?.DataBoundItem is Passenger selectedPassenger)
            {
                selectedPassenger.FirstName = txtFirstName.Text;
                selectedPassenger.LastName = txtLastName.Text;
                selectedPassenger.PassportNumber = txtPassportNumber.Text;
                selectedPassenger.Email = txtEmail.Text;
                selectedPassenger.ContactNumber = txtContactNumber.Text;

                _passengerRepository.UpdatePassenger(selectedPassenger);
                LoadPassengers();
            }
        }
        
        // Повернення на головну форму
        private void btnBackToMainForm_Click_1(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void PassengerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
        }

        private void PassengerForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
