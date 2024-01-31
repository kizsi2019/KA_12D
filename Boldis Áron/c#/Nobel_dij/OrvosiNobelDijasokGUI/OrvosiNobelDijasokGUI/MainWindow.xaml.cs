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

namespace OrvosiNobelDijasokGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbEv.Text != "" && tbNev.Text != "" && tbSzH.Text !="" && tbOrszag.Text != "")
            {
                if (int.Parse(tbEv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem \r\nmegfelelő!", "Mentés");
                }

                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{tbEv.Text};{tbNev.Text};{tbSzH.Text};{tbOrszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    tbEv.Text = "";
                    tbNev.Text = "";
                    tbSzH.Text = "";
                    tbOrszag.Text = "";

                    /*Random random = new Random();
                    int meret = random.Next(1, 30 + 1);
                    MessageBox.Show($"{tbNev.Text} faszmérete {meret}cm", "Nem semmi!");*/

                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba az állomány irásánál!");
                }

            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt", "Mentés");
            }
        }   
    }
}
