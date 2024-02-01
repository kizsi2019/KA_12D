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

namespace karacsonGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Cb_napok.Items.Count < 40)
            {
                Cb_napok.Items.Clear();
                for (int i = 0; i <= 40; i++)
                {
                    Cb_napok.Items.Add(i);
                }
            }
        }

        public static int nap = 0, eladott = 0, kesz = 0, osz = 0;
        private void Btn_hozzad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(Tb_kesz.Text);
            eladott = Convert.ToInt32(Tb_eladott.Text);
            if (kesz < 0 || eladott < 0)
            {
                Lb_hiba.Content = "Negatív számot nem tartalmazhat";
            }
            else if (eladott > kesz + osz)
            {
                Lb_hiba.Content = "Túl sok, az eladott angyalka";
            }
            else
            {
                nap = Convert.ToInt32(Cb_napok.SelectedItem.ToString());
                osz += kesz - eladott;
                Tb_ki.Text = nap + "nap: \t"+ kesz + "\t-" + eladott + "\t-" + "\t-" + "\t" + osz + "\n";
                for (int i = 0; i <= nap; i++)
                {
                    Cb_napok.Items.Remove(i);
                }
                Tb_kesz.Text = "0";
                Tb_eladott.Text = "0";
                Lb_hiba.Content = "";
            }
        }
    }
}
