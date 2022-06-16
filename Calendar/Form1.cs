using System.Globalization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        int month, year;

        public static int static_month, static_year;

        public Form1()
        {
            InitializeComponent();
        }

        
        // Do not delete / Label Vendredi
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDay();
        }

        private void displayDay()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                daycontainer.Controls.Add(ucDays);
            }
        }

        // Do Not Delete / Label Month YEAR
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                daycontainer.Controls.Add(ucDays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                daycontainer.Controls.Add(ucDays);
            }
        }
    }
}