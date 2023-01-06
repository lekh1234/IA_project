using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaFinal1
{
    public partial class ManagerCalender : Form
    {
        int month, year;

        public ManagerCalender()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            ManagerCalender log = new ManagerCalender();
            this.Hide();
            log.Show();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            ManagerHomePage log = new ManagerHomePage();
            this.Hide();
            log.Show();
        }

        private void CalenderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagerCalender_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            datelb.Text = monthname + " " + year;

            //to get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //to get count of days of month
            int days = DateTime.DaysInMonth(year, month);

            //convert startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for(int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 uc = new UserControl1();
                daycontainer.Controls.Add(uc);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        

        private void CashieronDuty_Click(object sender, EventArgs e)
        {
            ManagerCOD log = new ManagerCOD();
            this.Hide();
            log.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            //clearing controller
            daycontainer.Controls.Clear();

            //decrement month to go to previous month
            month--;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            datelb.Text = monthname + " " + year;

            DateTime now = DateTime.Now;

            //to get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //to get count of days of month
            int days = DateTime.DaysInMonth(year, month);

            //convert startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 uc = new UserControl1();
                daycontainer.Controls.Add(uc);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void ScheduleEvent_Click(object sender, EventArgs e)
        {
            EventsForm log = new EventsForm();
            log.ShowDialog();
        }

        private void FuelPrices_Click(object sender, EventArgs e)
        {
            ManagerFuelPrices log = new ManagerFuelPrices();
            this.Hide();
            log.Show();
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

        private void Next_Click(object sender, EventArgs e)
        {
            //clearing controller
            daycontainer.Controls.Clear();
           
            if(month!=12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }

            //increment month to go to next month
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            datelb.Text = monthname + " " + year;

            DateTime now = DateTime.Now;

            //to get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //to get count of days of month
            int days = DateTime.DaysInMonth(year, month);

            //convert startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 uc = new UserControl1();
                daycontainer.Controls.Add(uc);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
