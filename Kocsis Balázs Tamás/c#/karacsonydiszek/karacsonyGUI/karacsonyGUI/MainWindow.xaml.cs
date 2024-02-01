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
            if (cbNap.Items.Count < 40)
            {
                cbNap.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    cbNap.Items.Add(i);
                }
            }
        }

        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;
        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(tbElk.Text);
            eladott = Convert.ToInt32(tbEla.Text);
            if (kesz < 0 || eladott < 0)
            {
                
            }

        }
    }
}
