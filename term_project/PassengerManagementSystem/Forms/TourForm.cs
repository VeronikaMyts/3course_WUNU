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
    public partial class TourForm : Form
    {
        private readonly ToursRepository _tourRepository;
        private readonly RouterRepository _routerRepository; // Додано репозиторій для маршрутів
        private List<Tour> _currentTourList = new List<Tour>();

        public TourForm()
        {
            InitializeComponent();
            this.Load += TourForm_Load;
            _tourRepository = new ToursRepository();
            _routerRepository = new RouterRepository(); // Ініціалізація репозиторію для маршрутів
        }

        // Завантаження рейсів та маршрутів при завантаженні форми
        private void TourForm_Load(object sender, EventArgs e)
        {
            LoadTours();
            LoadRoutes(); // Завантаження маршрутів в комбобокс

            dataGridViewTours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Завантаження рейсів у DataGridView
        private void LoadTours()
        {
            var tours = _tourRepository.GetAllTours();
            dataGridViewTours.DataSource = tours;
            dataGridViewTours.AutoGenerateColumns = false;

            // Приховуємо ID
            dataGridViewTours.Columns["TourID"].Visible = false;

            // Перезавантажуємо DataGridView
            dataGridViewTours.Refresh();
        }

        // Завантаження маршрутів в комбобокс
        private void LoadRoutes()
        {
            var routes = _routerRepository.GetAllRoutes(); // Отримуємо всі маршрути
            if (routes.Any())
            {
                cmbRoute.DataSource = routes;
                cmbRoute.DisplayMember = "RouteID"; // Показуємо назву маршруту
                cmbRoute.ValueMember = "RouteID"; // Значення для збереження в базі даних
            }
            else
            {
                MessageBox.Show("Немає доступних маршрутів. Спочатку додайте маршрути.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Додавання нового рейсу
        private void btnAddTour_Click(object sender, EventArgs e)
        {
            var departureDate = dtpDepartureDate.Value;
            var arrivalDate = dtpArrivalDate.Value;
            var routeId = (int)cmbRoute.SelectedValue;

            // Перевірка на правильність введених значень
            if (routeId <= 0 || departureDate == null || arrivalDate == null)
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створення нового рейсу
            var tour = new Tour
            {
                DepartureDate = departureDate,
                ArrivalDate = arrivalDate,
                RouteID = routeId
            };

            _tourRepository.AddTour(tour);
            MessageBox.Show("Рейс додано успішно!");
            LoadTours(); // Оновлення списку рейсів
        }

        // Видалення рейсу
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.CurrentRow?.DataBoundItem is Tour selectedTour)
            {
                _tourRepository.DeleteTour(selectedTour.TourID);
                MessageBox.Show("Рейс видалено успішно!");
                LoadTours(); // Оновлення списку рейсів
            }
        }

        // Редагування рейсу
        private void btnEditTour_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.CurrentRow?.DataBoundItem is Tour selectedTour)
            {
                selectedTour.DepartureDate = dtpDepartureDate.Value;
                selectedTour.ArrivalDate = dtpArrivalDate.Value;
                selectedTour.RouteID = (int)cmbRoute.SelectedValue;

                _tourRepository.UpdateTour(selectedTour);
                MessageBox.Show("Рейс оновлено успішно!");
                LoadTours(); // Оновлення списку рейсів
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
        private void TourForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
        }

        private void TourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Додатковий функціонал закриття форми, якщо потрібно
        }
    }
}
