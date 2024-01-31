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

namespace OrvosiNobeldíjakGUI
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
            if (tbEv.Text != "" && tbNev.Text != "" && tbSzh.Text !="" && tbOrszag.Text != "") 
            {
                if (int.Parse(tbEv.Text) <= 1989) 
                {
                    MessageBox.Show("Hiba! Az évszám nem \r\nmegfelelő", "Mentés");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add ("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{tbEv.Text};{tbNev.Text};{tbSzh.Text};{tbOrszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    tbEv.Text = "";
                    tbNev.Text = "";
                    tbSzh.Text = "";
                    tbOrszag.Text = ""; 
                }
                catch (Exception)
                {
                     MessageBox.Show("Hiba az állomány írásánál");
                }
            }
            else 
            {
                MessageBox.Show("Töltsön ki minden mezőt", "Mentés");
            }
        }
    }
}
