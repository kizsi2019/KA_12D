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

namespace karacsonyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (napok.Items.Count < 40)
            {
                napok.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    napok.Items.Add(i);
                }
            }
        }
        public static int nap = 0, kesz = 0, eladot = 0, ossz = 0;
        private void btnhozzad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(keszitte.Text);
            eladot = Convert.ToInt32(tbeladot.Text);
            if (kesz < 0 || eladot < 0)
            {
                hiba.Content = "Negatív számot ne adj";
            }
            else if (eladot > kesz + ossz)
            {
                hiba.Content = "Túl sok az eladott angyalka";
            }
            else
            {
                nap = Convert.ToInt32(napok.SelectedItem.ToString());
                ossz += kesz - eladot;
                ki.Text += nap + "nap: \t+" + kesz + "\t-" + eladot + "\t= \t" + ossz;
                for (int i = 0; i <= nap; i++)
                {
                    napok.Items.Remove(i);
                }
                keszitte.Text = "0";
                tbeladot.Text = "0";
                hiba.Content = "";
            }
        }
    }
}
