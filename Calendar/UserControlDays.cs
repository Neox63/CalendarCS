using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        String connString = "server=localhost;user id=root;password=root;database=calendarcsharp;sslmode=none";

        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days (int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            String query = "SELECT * FROM Event where date = ?";
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("date", Form1.static_year + "-" + Form1.static_month + "-" + lbdays.Text);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lbevent.Text = reader["libelle"].ToString();
            }

            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
