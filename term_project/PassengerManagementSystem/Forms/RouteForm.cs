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
    public partial class RouteForm : Form
    {
        private readonly RouterRepository _routeRepository;
        private List<Route> _currentRouteList = new List<Route>();

        public RouteForm()
        {
            InitializeComponent();
            this.Load += RouteForm_Load;
            _routeRepository = new RouterRepository();
        }
        // Завантаження маршрутів при завантаженні форми
        private void RouteForm_Load(object sender, EventArgs e)
        {
            LoadRoutes();
            dataGridViewRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Завантаження маршрутів у DataGridView
        private void LoadRoutes()
        {
            var routes = _routeRepository.GetAllRoutes();
            dataGridViewRoutes.DataSource = routes;
            dataGridViewRoutes.AutoGenerateColumns = false;

            // Приховуємо ID
            dataGridViewRoutes.Columns["RouteID"].Visible = false;

            // Перезавантажуємо DataGridView
            dataGridViewRoutes.Refresh();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            var startCity = txtStartCity.Text;
            var endCity = txtEndCity.Text;

            // Перевірка на порожні значення
            if (string.IsNullOrWhiteSpace(startCity) || string.IsNullOrWhiteSpace(endCity))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створення нового маршруту
            var route = new Route
            {
                StartCity = startCity,
                EndCity = endCity
            };

            _routeRepository.AddRoute(route);
            MessageBox.Show("Маршрут додано успішно!");
            LoadRoutes(); // Оновлення списку маршрутів
        }
        // Видалення маршруту
        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.CurrentRow?.DataBoundItem is Route selectedRoute)
            {
                _routeRepository.DeleteRoute(selectedRoute.RouteID);
                MessageBox.Show("Маршрут видалено успішно!");
                LoadRoutes(); // Оновлення списку маршрутів
            }
        }

        // Редагування маршруту
        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.CurrentRow?.DataBoundItem is Route selectedRoute)
            {
                selectedRoute.StartCity = txtStartCity.Text;
                selectedRoute.EndCity = txtEndCity.Text;

                _routeRepository.UpdateRoute(selectedRoute);
                MessageBox.Show("Маршрут оновлено успішно!");
                LoadRoutes(); // Оновлення списку маршрутів
            }
        }

        // Повернення на головну форму
        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void RouteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
        }

        private void RouteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Додатковий функціонал закриття форми, якщо потрібно
        }
    }
}
