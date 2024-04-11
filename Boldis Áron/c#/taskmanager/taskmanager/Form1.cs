using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskmanager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (taskNameTxtBox.Text != "" && descTxtBox.Text != "" && statusList.Text != "")
            {
                Newtask task = new Newtask { Name = taskNameTxtBox.Text, Description = descTxtBox.Text, Status = statusList.Text };
                tasksGrid.Rows.Add(task.Name, task.Description, task.Status);
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tasksGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = tasksGrid.SelectedRows[0].Index;
                if (tasksGrid.Rows[selectedIndex].Cells["taskName"].Value != null)
                {
                    taskNameTxtBox.Text = tasksGrid.Rows[selectedIndex].Cells["taskName"].Value.ToString();
                    descTxtBox.Text = tasksGrid.Rows[selectedIndex].Cells["description"].Value.ToString();
                    statusList.Text = tasksGrid.Rows[selectedIndex].Cells["status"].Value.ToString();
                }
            }
            
            
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = tasksGrid.SelectedRows[0].Index;
            tasksGrid.Rows[selectedIndex].Cells["taskName"].Value = taskNameTxtBox.Text;
            tasksGrid.Rows[selectedIndex].Cells["description"].Value = descTxtBox.Text;
            tasksGrid.Rows[selectedIndex].Cells["status"].Value = statusList.Text;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tasksGrid.SelectedRows.Count > 0)
            { 
                int selectedIndex = tasksGrid.SelectedRows[0].Index;
                tasksGrid.Rows.RemoveAt(selectedIndex);
            }
            
        }
    }

    public class Newtask
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
