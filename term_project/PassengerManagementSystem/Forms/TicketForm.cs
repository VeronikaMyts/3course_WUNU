using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassengerManagementSystem.DataAccess;
using PassengerManagementSystem.Models;

namespace PassengerManagementSystem.Forms
{
    public partial class TicketForm : Form
    {
        private readonly TicketsRepository _ticketRepository;
        private readonly PassengersRepository _passengerRepository;  // Репозиторій для пасажирів
        private readonly ToursRepository _tourRepository;            // Репозиторій для рейсів
        private List<Ticket> _currentTicketList = new List<Ticket>();

        public TicketForm()
        {
            InitializeComponent();
            this.Load += TicketForm_Load;
            _ticketRepository = new TicketsRepository();
            _passengerRepository = new PassengersRepository(); // Ініціалізація репозиторію пасажирів
            _tourRepository = new ToursRepository();           // Ініціалізація репозиторію рейсів
        }

        // Завантаження квитків, пасажирів і рейсів при завантаженні форми
        private void TicketForm_Load(object sender, EventArgs e)
        {
            LoadTickets();
            LoadPassengers();  // Завантаження пасажирів в комбобокс
            LoadTours();       // Завантаження рейсів в комбобокс
            dataGridViewTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Завантаження квитків у DataGridView
        private void LoadTickets()
        {
            var tickets = _ticketRepository.GetAllTickets();
            dataGridViewTickets.DataSource = tickets;
            dataGridViewTickets.AutoGenerateColumns = false;

            // Приховуємо ID
            dataGridViewTickets.Columns["TicketID"].Visible = false;

            // Перезавантажуємо DataGridView
            dataGridViewTickets.Refresh();
        }

        // Завантаження пасажирів в комбобокс
        private void LoadPassengers()
        {
            var passengers = _passengerRepository.GetAllPassengers();
            if (passengers.Any())
            {
                cmbPassenger.DataSource = passengers;
                cmbPassenger.DisplayMember = "FullName"; // Показуємо повне ім'я пасажира
                cmbPassenger.ValueMember = "PassengerID"; // Значення для збереження в базі даних
            }
            else
            {
                MessageBox.Show("Немає доступних пасажирів. Спочатку додайте пасажирів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завантаження рейсів в комбобокс
        private void LoadTours()
        {
            var tours = _tourRepository.GetAllTours();
            if (tours.Any())
            {
                cmbTour.DataSource = tours;
                cmbTour.DisplayMember = "Route.StartCity"; // Показуємо стартове місто маршруту
                cmbTour.ValueMember = "TourID"; // Значення для збереження в базі даних
            }
            else
            {
                MessageBox.Show("Немає доступних рейсів. Спочатку додайте рейси.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Додавання нового квитка
        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            var passengerId = (int)cmbPassenger.SelectedValue;
            var tourId = (int)cmbTour.SelectedValue;
            var price = numericPrice.Value;
            var isBooked = chkIsBooked.Checked;

            // Перевірка на правильність введених значень
            if (passengerId <= 0 || tourId <= 0 || price <= 0)
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створення нового квитка
            var ticket = new Ticket
            {
                PassengerID = passengerId,
                TourID = tourId,
                Price = price,
                IsBooked = isBooked
            };

            _ticketRepository.AddTicket(ticket);
            MessageBox.Show("Квиток додано успішно!");
            LoadTickets(); // Оновлення списку квитків
        }

        // Редагування квитка
        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.CurrentRow?.DataBoundItem is Ticket selectedTicket)
            {
                selectedTicket.PassengerID = (int)cmbPassenger.SelectedValue;
                selectedTicket.TourID = (int)cmbTour.SelectedValue;
                selectedTicket.Price = numericPrice.Value;
                selectedTicket.IsBooked = chkIsBooked.Checked;

                _ticketRepository.UpdateTicket(selectedTicket);
                MessageBox.Show("Квиток оновлено успішно!");
                LoadTickets(); // Оновлення списку квитків
            }
        }

        // Видалення квитка
        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.CurrentRow?.DataBoundItem is Ticket selectedTicket)
            {
                _ticketRepository.DeleteTicket(selectedTicket.TicketID);
                MessageBox.Show("Квиток видалено успішно!");
                LoadTickets(); // Оновлення списку квитків
            }
        }

        // Повернення на головну форму
        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        // Закриття форми
        private void TicketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
