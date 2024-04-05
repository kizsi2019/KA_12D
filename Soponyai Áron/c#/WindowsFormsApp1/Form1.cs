using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 14;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("A kvíznek vége van" + Environment.NewLine +
                                "Ennyi kérdést sikerült helyesen megválaszolj: " + score + Environment.NewLine +
                                "Eredményed:  " + percentage + " %" + Environment.NewLine +
                                "Kattints az 'ok' gombra hogy újrakezd!"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {



            switch (qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "?";

                    button1.Text = ".";
                    button2.Text = "";
                    button4.Text = "A konstruktor, az konstruktor.";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "A System.Console.WriteLine() utasításban miket választunk el a \"dot notation\"-nel?";

                    button1.Text = "System namespace, Console class, WriteLine class";
                    button2.Text = "System namespace, Console class, WriteLine() method";
                    button3.Text = "System namespace, Console class, WriteLine method";
                    button4.Text = "System class, Console innerclass, WriteLine() method";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Melyik konstansok deklarációja helyes a C#-ban? (az Item egy osztály, melynek létezik paraméter nélküli konstruktora)";

                    button1.Text = "private static const int NUMBER_OF_ROWS = 10;\r\n";
                    button2.Text = "private const static int NUMBER_OF_ROWS = 10;";
                    button3.Text = "private const Item SPECIAL_ITEM = new Item();";
                    button4.Text = "private static readonly Item SPECIAL_ITEM = new Item();";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Az Objektum Orientált Programozásban mit takar az override(ing)?";

                    button1.Text = "Egy osztályhierarchiában értelmezett fogalom, mely elsősorban azonos nevű, de különböző aláírású metódusokra értelmezett.";
                    button2.Text = "Egy osztályhierarchiában értelmezett fogalom, mely elsősorban azonos aláírású metódusokra értelmezett.";
                    button3.Text = "Egy osztályban értelmezett fogalom, mely elsősorban azonos aláírású metódusokra értelmezett.";
                    button4.Text = "Egy osztályban értelmezett fogalom, mely elsősorban azonos nevű, de különböző aláírású metódusokra értelmezett.";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mi az az OOP alapelve és miért fontos?";

                    button1.Text = "Az OOP alapelve az, hogy az adatok és a hozzájuk kapcsolódó műveletek egy logikai egységbe, az osztályba vannak csoportosítva, ami lehetővé teszi az adatok elrejtését és az adatokon végzett műveletek összetartozásának fenntartását.";
                    button2.Text = "OOP alapelve: Az OOP alapelve az, hogy minél több adatot tároljunk egy osztályban.";
                    button3.Text = "Az OOP nem fontos, a procedurális programozás sokkal hatékonyabb.";
                    button4.Text = "Az OOP alapelve az, hogy egyetlen hatalmas osztályba tegyük az összes funkciót és adatot.";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Milyen szerepe van az öröklődésnek az OOP-ben?";

                    button1.Text = "Az öröklődés nem létezik az OOP-ben, csak az interfészek használata.";
                    button2.Text = "   Az öröklődés csak arra szolgál, hogy bonyolultabbá tegyük az osztályokat.";
                    button3.Text = "Az öröklődés lehetővé teszi egy osztály (a leszármazott osztály) számára, hogy örökölje egy másik osztály (a szülőosztály) tulajdonságait és viselkedését.";
                    button4.Text = " Az öröklődésnek nincs szerepe az OOP-ben, mivel minden osztály különállóan működik.";

                    correctAnswer = 3;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Mi a különbség az absztrakt osztály és az interfész között?";

                    button1.Text = "Az absztrakt osztály tartalmazhat implementált metódusokat is, míg az interfész csak metódusokat határoz meg, de nem ad meg rájuk implementációt.  ";
                    button2.Text = "   Nincs különbség, mindkettő ugyanazt a célt szolgálja. ";
                    button3.Text = "Az absztrakt osztály csak a gyermekosztályok számára elérhető, az interfész pedig minden osztály számára.";
                    button4.Text = "  Az absztrakt osztály csak adatokat tárol, az interfész pedig csak metódusokat. ";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Hogyan készíthetünk új példányt egy osztályból az OOP-ben?";

                    button1.Text = " A new_instance() függvényt kell használni az új példány létrehozásához.";
                    button2.Text = "Új példányt csak a statikus metódusok segítségével lehet létrehozni.";
                    button3.Text = "Az osztály nevét kell használni egy konstruktorhívás során.";
                    button4.Text = "Az OOP-ben nem lehet új példányt készíteni az osztályból.";

                    correctAnswer = 3;

                    break;

                case 9:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "";

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;

                case 10:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "";

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 4;

                    break;

                case 11:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "?";

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 3;

                    break;

                case 12:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "";

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 2;

                    break;

                case 13:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "";

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 4;

                    break;

                case 14:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "";

                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;

            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
