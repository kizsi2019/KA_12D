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
        string userID = "root";
        string password = "";
        string database = "CRUD_muveletek";

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
            string insertTable = "INSERT INTO test_table(id, name, fname) values (" + tb1.Text + ", '"+ tb2.Text + "', '" + tb3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(insertTable, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
        }
    }
}
