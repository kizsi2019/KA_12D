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
using System.IO;

namespace NobelGUIWPF
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

        private void btnAdat_Click(object sender, RoutedEventArgs e)
        {
            if (tbÉv.Text != "" && tbNév.Text != "" && tbSzh.Text != "" && tbOrszag.Text != "")
            {
                if (int.Parse(tbÉv.Text) < 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem \r\nmegfelelől!", "Mentés");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{tbÉv.Text}; {tbNév.Text}; {tbSzh.Text}; {tbOrszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    tbÉv.Text = "";
                    tbNév.Text = "";
                    tbSzh.Text = "";
                    tbOrszag.Text = "";
                }
                catch (Exception)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt", "Mentés");
            }
        }
    }
}
