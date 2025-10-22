using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassengerManagementSystem.Forms
{
    public partial class MainForm : Form
    {
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManagePassengers_Click(object sender, EventArgs e)
        {

            var passengerForm = new PassengerForm();
            passengerForm.Show(); ;
            this.Hide();


        }
        private void btnManageTours_Click(object sender, EventArgs e)
        {
            var tourForm = new TourForm();
            tourForm.Show();
            this.Hide();
        }

        private void btnManageRoutes_Click(object sender, EventArgs e)
        {
            var routeForm = new RouteForm();
            routeForm.Show();
            this.Hide();
        }

        private void btnManageTickets_Click(object sender, EventArgs e)
        {
            var ticketForm = new TicketForm();
            ticketForm.Show();
            this.Hide();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
