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

namespace SpeedrunningDatabase
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string SRQuery = "SELECT * FROM speedrunner";
            string VGQuery = "SELECT * FROM videogame";
            string SRUNQuery = "SELECT * FROM speedrun";
            connection.Open();

            MySqlCommand com =new MySqlCommand(SRQuery,connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            SpeedrunnersTable.DataSource = data;

            com = new MySqlCommand(VGQuery);
            com.ExecuteNonQuery();
            adapt = new MySqlDataAdapter(com);
            data = new DataTable();
            adapt.Fill(data);
            VideogamesTable.DataSource = data;

            com = new MySqlCommand(SRUNQuery);
            com.ExecuteNonQuery();
            adapt = new MySqlDataAdapter(com);
            data = new DataTable();
            adapt.Fill(data);
            SpeedrunsTable.DataSource = data;
            connection.Close();*/

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SpeedrunnersButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string SRQuery = "SELECT * FROM speedrunner";
            connection.Open();

            MySqlCommand com = new MySqlCommand(SRQuery, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            SpeedrunnersTable.DataSource = data;
            connection.Close();
        }

        private void VideogamesButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string VGQuery = "SELECT * FROM videogame";
            connection.Open();

            MySqlCommand com = new MySqlCommand(VGQuery, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            VideogamesTable.DataSource = data;
            connection.Close();
        }

        private void SpeedrunsButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string SRUNQuery = "SELECT * FROM speedrun";
            connection.Open();

            MySqlCommand com = new MySqlCommand(SRUNQuery, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            SpeedrunsTable.DataSource = data;
            connection.Close();
        }
    }
}
