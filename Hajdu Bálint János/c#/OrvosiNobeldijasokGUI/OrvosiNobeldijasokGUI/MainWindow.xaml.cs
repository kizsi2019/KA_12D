using System;
using System.IO;
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

        private void BtnMentes_Click(object sender, RoutedEventArgs e)
        {
            if (TbEv.Text != "" && TbNev.Text != "" && TbSzulEsHal.Text != "" && TbOrszag.Text != "")
            {
                if (int.Parse(TbEv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{TbEv.Text},{TbNev.Text},{TbSzulEsHal.Text},{TbOrszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    TbEv.Text = "";
                    TbNev.Text = "";
                    TbSzulEsHal.Text = "";
                    TbOrszag.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba az állomány írásánál!");
                }
            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
            }
        }
    }
}
