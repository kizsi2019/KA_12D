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
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.AccessControl;

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

        private void BntMentes_Click(object sender, RoutedEventArgs e)
        {
            if (TbEv.Text != "" && TbNev.Text != "" && TbSzulEsHal.Text != "" && TbOrszag.Text != "")
            {
                if (int.Parse(TbEv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba, az evszam nem jo!", "Mentes");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;Országkód");
                    ki.Add($"{TbEv.Text},{TbNev},{TbSzulEsHal},{TbOrszag}");
                    File.WriteAllLines("uj_dijazott.txt", ki);
                    TbEv.Text = "";
                    TbNev.Text= "";
                    TbSzulEsHal.Text = "";
                    TbOrszag.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba az allomany irasanal");
                }
            }
            else
            {
                MessageBox.Show("Toltse ki ezt a mezot");
            }
        }
    }
}
