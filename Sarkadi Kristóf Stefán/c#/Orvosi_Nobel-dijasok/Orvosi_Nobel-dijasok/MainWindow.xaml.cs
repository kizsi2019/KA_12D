using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Orvosi_Nobel_dijasok
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

        private void Btn_adment_Click(object sender, RoutedEventArgs e)
        {
            if (Tb_ev.Text != "" && Tb_nev.Text != "" && Tb_Szh.Text != "" && Tb_orszag.Text != "")
            {
                if (int.Parse(Tb_ev.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem \r\nmegfelelő!", "Mentés");
                }

            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "Mentés");
            }
            try
            {
                List<string> ki = new List<string>();
                ki.Add("Év, Név, SzületésHalálozás, Országkód");
                ki.Add($"{Tb_ev.Text}, {Tb_nev.Text}, {Tb_Szh.Text}, {Tb_orszag.Text}");
                File.WriteAllLines("uj_dijazott.txt", ki);
                Tb_ev.Text = "";
                Tb_nev.Text = "";
                Tb_Szh.Text = "";
                Tb_orszag.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
