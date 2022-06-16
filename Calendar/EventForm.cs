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
    public partial class EventForm : Form
    {
        String connString = "server=localhost;user id=root;password=root;database=calendarcsharp;sslmode=none";
        
        public EventForm()
        {
            InitializeComponent();
        }

        // Do not delete / Label Event
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            textDate.Text = Form1.static_year + "/" + Form1.static_month + "/" + UserControlDays.static_day;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            String query = "INSERT INTO Event(date, libelle) values (?,?)";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("date", textDate.Text);
            cmd.Parameters.AddWithValue("libelle", textEvent.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Event has been saved");

            cmd.Dispose();

            conn.Close();
        }
    }
}
