﻿using System;
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
    public partial class ManagerFuelPrices : Form
    {
        public ManagerFuelPrices()
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

        private void FuelPrices_Click(object sender, EventArgs e)
        {
            ManagerFuelPrices log = new ManagerFuelPrices();
            this.Hide();
            log.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffDetails_Click(object sender, EventArgs e)
        {
            ManagerStaffDetails log = new ManagerStaffDetails();
            this.Hide();
            log.Show();
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

        private void ManagerFuelPrices_Load(object sender, EventArgs e)
        {

        }
    }
}
