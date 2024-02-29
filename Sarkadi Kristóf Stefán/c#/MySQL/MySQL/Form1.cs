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

namespace MySQL
{
    public partial class Form1 : Form
    {
        string server = "localHost";
        string uid = "root";
        string password = "";
        string database = "oscar";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string CreateTable = "create table test_table(id int, nev varchar(50), producer int)";
            MySqlCommand cmd = new MySqlCommand(CreateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string CreateTable = "INSERT INTO keszito(id, name, fname) values (" + tb_1.Text + ", '" + tb_2.Text + "', '" + tb_3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(CreateTable, con);
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "select * from keszito";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string UpdateTable = "update keszito set nev='Blade Wolf' where nev='Marc Platt'";
            MySqlCommand cmd = new MySqlCommand(UpdateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string DeleteTable = "Delete from keszito where id = 3";
            MySqlCommand cmd = new MySqlCommand(DeleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_Feladat2_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT film.nyert, film.ev, film.cim FROM film";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel2 = new DataTable();
            Fel2.Load(reader);
            dataGridView1.DataSource = Fel2;
        }

        private void btn_Feladat3_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT film.ev FROM film GROUP BY ev Having Count(id)>=10";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel3 = new DataTable();
            Fel3.Load(reader);
            dataGridView1.DataSource = Fel3;
        }

        private void Feladat4_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT film.cim FROM film WHERE ev BETWEEN 1939 And 1945";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel4 = new DataTable();
            Fel4.Load(reader);
            dataGridView1.DataSource = Fel4;
        }

        private void btn_Feladat5_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT film.cim FROM film WHERE YEAR(bemutato)-ev>=10 AND nyert";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel5 = new DataTable();
            Fel5.Load(reader);
            dataGridView1.DataSource = Fel5;
        }

        private void btn_Feladat6_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT keszito.nev, MAX(film.ev)-MIN(film.ev) AS eltelt, " +
                "COUNT(film.id) AS db FROM film, kapcsolat, keszito " +
                "WHERE film.id=kapcsolat.filmid AND kapcsolat.keszitoid=keszito.id " +
                "And keszito.producer GROUP BY keszito.nev HAVING COUNT(film.id)>1";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel6 = new DataTable();
            Fel6.Load(reader);
            dataGridView1.DataSource = Fel6;
        }

        private void btn_Feladat7_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT DISTINCT keszito.nev FROM keszito, kapcsolat " +
                "WHERE keszito.id=kapcsolat.keszitoid AND kapcsolat.filmid IN " +
                "( SELECT kapcsolat.filmid FROM kapcsolat, keszito " +
                "WHERE keszito.id=kapcsolat.keszitoid AND nev='Clint Eastwood') " +
                "AND nev<>'Clint Eastwood'";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel7 = new DataTable();
            Fel7.Load(reader);
            dataGridView1.DataSource = Fel7;
        }

        private void btn_Feladat8_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "SELECT keszito.nev FROM keszito " +
                "WHERE keszito.id NOT IN " +
                "(SELECT kapcsolat.keszitoid " +
                "FROM kapcsolat, film WHERE kapcsolat.filmid=film.id " +
                "AND film.bemutato IS NOT NULL) AND keszito.producer";
            MySqlCommand cmd = new MySqlCommand(SQL, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Fel8 = new DataTable();
            Fel8.Load(reader);
            dataGridView1.DataSource = Fel8;
        }
    }
}
