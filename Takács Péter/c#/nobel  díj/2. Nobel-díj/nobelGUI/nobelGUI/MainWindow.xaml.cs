using System;
using System.Collections.Generic;
using System.IO;
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

namespace nobelGUI
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
        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            if(tbÉv.Text != "" && tbNév.Text != "" && tbSzH.Text != "" && tbOrszág.Text != "")
            {
                if (int.Parse(tbÉv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem\r\tmegfelelő! ", "Mentés");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év; Név;SzületésHalálozás;Országkód");
                    ki.Add($"{tbSzH.Text};{tbNév.Text};{tbÉv.Text};{tbOrszág.Text}");
                    File.WriteAllLines("uj-dijazott.txt", ki);
                    tbÉv.Text = "";
                    tbNév.Text = "";
                    tbSzH.Text = "";
                    tbOrszág.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba az állomány írásánál! ");
                }
            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt", "Mentés");
            }
        }
    }
}
