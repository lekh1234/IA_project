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
    public partial class CashierCalendar : Form
    {
        int month, year;
        public CashierCalendar()
        {
            InitializeComponent();
        }

        private void ScheduleEvent_Click(object sender, EventArgs e)
        {
            EventsForm log = new EventsForm();
            log.ShowDialog();
        }

        private void CashierCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
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

        private void Next_Click(object sender, EventArgs e)
        {
            //clearing controller
            daycontainer.Controls.Clear();

            if (month != 12)
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

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Shift_Click(object sender, EventArgs e)
        {
            CashierShift log = new CashierShift();
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
