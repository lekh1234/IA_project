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
    public partial class CashierShift : Form
    {
        public CashierShift()
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
            CashierHomePage log = new CashierHomePage();
            this.Hide();
            log.Show();
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            CashierCalendar log = new CashierCalendar();
            this.Hide();
            log.Show();
        }

        private void Shift_Click(object sender, EventArgs e)
        {
            CashierShift log = new CashierShift();
            this.Hide();
            log.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void CashierShift_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReoprttoDuty_Click(object sender, EventArgs e)
        {
            ReportDuty log = new ReportDuty();
            log.ShowDialog();
        }

        private void ShiftHistory_Click(object sender, EventArgs e)
        {
            CashierShiftHistory log = new CashierShiftHistory();
            this.Hide();
            log.Show();
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            CashierSalary log = new CashierSalary();
            this.Hide();
            log.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            CashierSettings log = new CashierSettings();
            this.Hide();
            log.Show();
        }

        private void ProfileImage_Click(object sender, EventArgs e)
        {
            CashierSettings log = new CashierSettings();
            this.Hide();
            log.Show();
        }
    }
}
