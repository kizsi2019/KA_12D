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

namespace CLUD
{
    public partial class Form1 : Form
    {
        string server = "localHost";
        string uid = "root";
        string password = "";
        string database = "CLUD_muveletek";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CreateTbl_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string CreateTable = "create table test_table(id int, name varchar(50), fname varchar(50))";
            MySqlCommand cmd = new MySqlCommand(CreateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string InsertTable = "INSERT INTO test_table(id, name, fname) values (" + tb_1.Text + ", '" + tb_2.Text + "', '" + tb_3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(InsertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string SQL = "select * from test_table";
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
            string UpdateTable = "update test_table set name='Tamás' where fname='Nagy'";
            MySqlCommand cmd = new MySqlCommand(UpdateTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }

        private void btn_DeleteRecord_Click(object sender, EventArgs e)
        {
            string constring = "server=" + server + "; uid=" + uid + ";pass=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string DeleteTable = "Delete from test_table where id = 3";
            MySqlCommand cmd = new MySqlCommand(DeleteTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
    }
}
