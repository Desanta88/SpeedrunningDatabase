using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            VGQuery = "SELECT DISTINCT Publisher FROM videogame;";
            com=new MySqlCommand(VGQuery, connection);
            com.ExecuteNonQuery();
            adapt = new MySqlDataAdapter(com);
            data = new DataTable();
            adapt.Fill(data);
            comboBoxVG.DataSource = data;
            connection.Close();
            comboBoxVG.ValueMember = "Publisher";
            comboBoxVG.DisplayMember = "Publisher";
        }

        private void SpeedrunsButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string SRUNQuery = "SELECT * FROM speedrun";
            string VGQuery = "SELECT * FROM videogame";
            connection.Open();

            MySqlCommand com = new MySqlCommand(SRUNQuery, connection);
            MySqlCommand com2 = new MySqlCommand(VGQuery, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            SpeedrunsTable.DataSource = data;
            com=new MySqlCommand(VGQuery, connection);
            adapt=new MySqlDataAdapter(com);
            data = new DataTable();
            adapt.Fill(data);
            SpeedrunCombo.DataSource = data;
            connection.Close();

            SpeedrunCombo.ValueMember = "Id";
            SpeedrunCombo.DisplayMember = "Title";
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            //tutti le speedrun di uno specifico gioco
            string query = $"SELECT speedrun.Id, speedrunner.Username,videogame.Title,speedrun.Date,speedrun.Time,speedrun.LeaderboardNumber,speedrun.Platform FROM (videogame JOIN speedrun ON videogame.Id=speedrun.Videogame) JOIN speedrunner ON speedrun.Speedrunner=speedrunner.Id WHERE videogame.Title='{SpeedrunCombo.Text}' ORDER BY speedrun.LeaderboardNumber ASC;";
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand com = new MySqlCommand(query, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            SpeedrunsTable.DataSource = data;
            connection.Close();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            //riordinare gli speedrunners di uno specifico gioco in ordine di classifica
            string query = $"SELECT speedrun.Id, speedrunner.Username,videogame.Title,speedrun.Date,speedrun.Time,speedrun.LeaderboardNumber,speedrun.Platform FROM (videogame JOIN speedrun ON videogame.Id=speedrun.Videogame) JOIN speedrunner ON speedrun.Speedrunner=speedrunner.Id WHERE videogame.Title='{SpeedrunCombo.Text}';";
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand com = new MySqlCommand(query, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            SpeedrunsTable.DataSource = data;
            connection.Close();

        }

        private void buttonVG_Click(object sender, EventArgs e)
        {
            //tutti i giochi di uno specifico pubblicatore
            string query = $"SELECT * FROM videogame WHERE Publisher='{comboBoxVG.Text}';";
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand com = new MySqlCommand(query, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            VideogamesTable.DataSource = data;
            connection.Close();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            //tutti i giochi pubblicati in uno specifico anno
            string query = $"SELECT * FROM videogame WHERE PublishingYear='{textBoxVG.Text}';";
            string connectionString = "server=localhost;uid=programma;pwd=12345;database=speedrunning";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand com = new MySqlCommand(query, connection);
            com.ExecuteNonQuery();
            MySqlDataAdapter adapt = new MySqlDataAdapter(com);
            DataTable data = new DataTable();
            adapt.Fill(data);
            VideogamesTable.DataSource = data;
            connection.Close();
        }
    }
}
