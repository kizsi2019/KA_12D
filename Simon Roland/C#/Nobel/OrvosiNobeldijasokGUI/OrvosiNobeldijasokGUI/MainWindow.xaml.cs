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

namespace OrvosiNobeldijasokGUI
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if(tbev.Text != "" && tbnev.Text != "" && tborszag.Text != "" && tbszh.Text != "")
            {
                if (int.Parse(tbev.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az éveszám nem megfelelő!", "Mentés");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{tbev.Text}; {tbnev.Text};{tbszh.Text};{tborszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    tbev.Text = "";
                    tbnev.Text = "";
                    tborszag.Text = "";
                    tbszh.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba aza állomány írásánál!", "Mentés");
                }

            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "Mentés");
            }
        }
    }
}
