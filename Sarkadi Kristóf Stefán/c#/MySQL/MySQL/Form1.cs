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
    }
}
