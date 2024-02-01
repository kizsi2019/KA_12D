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
            if (CbNapok.Items.Count < 40)
            {
                CbNapok.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    CbNapok.Items.Add(i);
                }
            }
        }

        public static int nap = 0, kesz = 0, eladott = 0, osszes = 0;
        private void BtnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(TbElkeszitett.Text);
            eladott = Convert.ToInt32(TbEladott.Text);
            if (kesz < 0 || eladott < 0)
            {
                LblHiba.Content = "Negatív számot nem adhat meg!";
            }
            else if (eladott > kesz + osszes)
            {
                LblHiba.Content = "Túl sok az eladott angyalka!";
            }
        }
    }
}
