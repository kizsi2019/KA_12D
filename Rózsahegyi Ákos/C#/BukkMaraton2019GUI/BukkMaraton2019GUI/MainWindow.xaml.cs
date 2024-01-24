using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BukkMaraton2019GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSzamol_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)CbTav.SelectedItem;
            int tavKm = (int)CbTav.SelectedIndex;
            string[] m = TbIdo.Text.Split(':');
            int ora = int.Parse(m[0]);
            int perc = int.Parse(m[1]);
            int masodperc = int.Parse(m[2]);
            TimeSpan ido = new TimeSpan(ora, perc, masodperc);
            TbAtlagSebessegKmh.Text = $"{tavKm / ido.TotalHours:f2}";
            TbAtlagSebessegMs.Text = $"{1000 * tavKm / ido.TotalHours:f2}";
        }
    }
}
