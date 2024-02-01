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

namespace KarácsonyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if(cbNapok.Items.Count < 40)
            {
                cbNapok.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    cbNapok.Items.Add(i);
                }
            }
        }

        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;

        private void btnHozzaad_Click_1(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(tbElkesz.Text);
            eladott = Convert.ToInt32(tbElad.Text);
            if (kesz < 0 || eladott < 0)
            {
                lblHiba.Content = "Tourettes vagyok! ";
            }
            else if (eladott > kesz + ossz)
            {
                lblHiba.Content = "Túl sok eladott angyalka van! ";
            }
            else
            {
                nap  = Convert.ToInt32(cbNapok.SelectedItem.ToString());
                ossz += kesz - eladott;
                tbKi.Text += nap + ".nap: \t+" + kesz + " \t-" + eladott + " \t= \t" + ossz + "\n";
                for (int i = 0; i <= nap; i++)
                {
                    cbNapok.Items.Remove(i);
                }
                tbElkesz.Text = "0";
                tbElad.Text = "0";
                lblHiba.Content = "";
            }
        }
    }
}
