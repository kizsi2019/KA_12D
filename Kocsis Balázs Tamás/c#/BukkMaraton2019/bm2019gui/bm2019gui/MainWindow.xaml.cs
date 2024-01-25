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

namespace bm2019gui
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

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbTav.SelectedItem;
            int tavKm = (int)cbTav.SelectedIndex;
            string[] m = tbIdo.Text.Split(':');
            int ora = int.Parse(m[0]);
            int perc = int.Parse(m[1]);
            int masodperc = int.Parse(m[2]);
            TimeSpan ido = new TimeSpan(ora, perc, masodperc);
            tbAtlagkmph.Text = $"{tavKm / ido.TotalHours:F2}";
            tbAtlagmps.Text = $"{1000 * tavKm / ido.TotalHours:F2}";
        }
    }
}
