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

namespace MySQL2
{
    public partial class Form1 : Form
    {
        string server = "localhost";
        string userID = "root";
        string password = "";
        string database = "oscar";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string createTable = "CREATE table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string insertTable = "INSERT INTO keszito(id, nev, producer) values (" + tb1.Text + ", '" + tb2.Text + "', '" + tb3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT * FROM film";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string updateTable = "UPDATE keszito set nev='Lil Kispocs' WHERE id='1'";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string deleteTable = "DELETE FROM keszito WHERE id='563'";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btnFeladat2_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.ev, film.cim " +
                "FROM film " +
                "WHERE nyert " +
                "ORDER BY ev;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnFeladat3_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.ev " +
                "FROM film " +
                "GROUP BY ev HAVING Count(id)>=10;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnFeladat4_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim FROM film " +
                "WHERE ev BETWEEN 1939 And 1945 AND bemutato BETWEEN '1939-1-1' AND '1945-12-31';";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnFeladat5_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT film.cim FROM film " +
                "WHERE Year(bemutato)-ev>=10 " +
                "AND nyert;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnFeladat6_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev, COUNT(film.id) AS db, MAX(film.ev)-MIN(film.ev) AS eltelt FROM film, kapcsolat, keszito WHERE film.id=kapcsolat.filmid AND kapcsolat.keszitoid=keszito.id AND keszito.producer GROUP BY keszito.nev HAVING COUNT(film.id)>1;;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnFeladat7_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN (SELECT kapcsolat.filmid FROM kapcsolat, keszito WHERE keszito.id=kapcsolat.keszitoid AND nev='Clint Eastwood') AND nev<>'Clint Eastwood';";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btnFeladat8_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + userID + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "SELECT keszito.nev FROM keszito WHERE keszito.id NOT IN (SELECT kapcsolat.keszitoid FROM kapcsolat, film WHERE kapcsolat.filmid=film.id AND film.bemutato IS NOT NULL) AND keszito.producer;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
