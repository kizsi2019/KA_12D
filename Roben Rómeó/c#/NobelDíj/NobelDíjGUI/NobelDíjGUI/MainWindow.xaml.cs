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

namespace NobelDíjGUI
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
            if (tbev.Text != "" & tbnev.Text != "" &&  tbszh.Text != "" && tborszag.Text != "")
            {
                if (int.Parse(tbev.Text) <=1989)
                {
                    MessageBox.Show("hiba!4!4!!!!4!! az évszám nem \r\n megfelelő", "Mentés");
                }
                try
                {
                    List<string> ki = new List<string>();
                    ki.Add("Év;Név;SzületésHalálozás;OrszágKód");
                    ki.Add($"{tbev.Text};{tbnev.Text};{tborszag.Text};{tbszh.Text}");
                    File.WriteAllLines("ujdikazott.txt", ki);
                    tbev.Text = "";
                    tbnev.Text = "";
                    tborszag.Text = "";
                    tbszh.Text = "";

                }
                catch(Exception)
                {
                    MessageBox.Show("hiba az állopmány Írásánál");
                }
                


            }
        }
    }
}
