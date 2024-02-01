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
            if (cbNapok.Items.Count < 40)
            {
                cbNapok.Items.Clear();
                for (int i = 1; i<= 40; i++)
                {
                    cbNapok.Items.Add(i);
                }
            }
        }

        public static int nap = 0, kesz = 0, eladott = 0, osszes = 0;

        private void btnHozzaad_Click_1(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(tbElkeszitett.Text);
            eladott = Convert.ToInt32(tbEladott.Text);
            if (kesz < 0 || eladott < 0)
            {
                lblHiba.Content = "Negativ számot nem adhat meg";
            }
            else if (eladott > kesz + osszes)
            {
                lblHiba.Content = "Túl sok az eladott angyalka";
            }
            else
            {
                nap = Convert.ToInt32(cbNapok.SelectedItem.ToString());
                osszes += kesz - eladott;
                tbLista.Text += nap + ".nap: \t+" + kesz + "\t-" + eladott + "\t= \t" + osszes + "\n";
                for (int i = 0; i <= nap; i++)
                {
                    cbNapok.Items.Remove(i);
                }
                tbElkeszitett.Text = "0";
                tbEladott.Text  = "0";
                lblHiba.Content = "";
            }
        }
    }
}
