using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaFinal1
{
    public partial class ManagerStaffDetails : Form
    {
        public ManagerStaffDetails()
        {
            InitializeComponent();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            ManagerHomePage log = new ManagerHomePage();
            this.Hide();
            log.Show();
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            ManagerCalender log = new ManagerCalender();
            this.Hide();
            log.Show();
        }

        private void CashieronDuty_Click(object sender, EventArgs e)
        {
            ManagerCOD log = new ManagerCOD();
            this.Hide();
            log.Show();
        }

        private void FuelPrices_Click(object sender, EventArgs e)
        {
            ManagerFuelPrices log = new ManagerFuelPrices();
            this.Hide();
            log.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManagerStaffDetails log = new ManagerStaffDetails();
            this.Hide();
            log.Show();
        }

        private void EditDuty_Click(object sender, EventArgs e)
        {
            DeleteStaff log = new DeleteStaff();
            log.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ManagerSettings log = new ManagerSettings();
            this.Hide();
            log.Show();
        }

        private void ProfileImage_Click(object sender, EventArgs e)
        {
            ManagerSettings log = new ManagerSettings();
            this.Hide();
            log.Show();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            UserRegistration log = new UserRegistration();
            log.ShowDialog();
        }
    }
}
