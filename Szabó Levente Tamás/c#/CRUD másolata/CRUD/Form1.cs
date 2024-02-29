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

namespace CRUD
{
    public partial class Form1 : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "frankónevek";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e) //read
        {
            string coString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(coString);
            con.Open();
            string sql = "select * from bebas";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e) //create
        {
            string coString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(coString);
            con.Open();
            string createTable = "create table bebas(id int, name varchar(50), fname varchar(50)) ";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
        private void button2_Click(object sender, EventArgs e) //insert
        {
            string coString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(coString);
            con.Open();
            string insertTable = "insert into bebas(id, name, fname) values (" + tb1.Text + ", '" + tb2.Text + "', '" + tb3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_update_Click(object sender, EventArgs e) //update
        {
            string coString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(coString);
            con.Open();
            string updateTable = "Update bebas set name='Gura' where fname='hmm'";
            MySqlCommand cmd = new MySqlCommand(updateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string coString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(coString);
            con.Open();
            string deleteTable = "Delete from bebas where id='1'";
            MySqlCommand cmd = new MySqlCommand(deleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}