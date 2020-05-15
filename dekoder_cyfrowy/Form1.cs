using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dekoder_cyfrowy
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._0;
        }
public void dekoduj(PictureBox ktory_pikczer, char cyfra)
        {   //przekazano do tej procedury nazwę Pictureboxa który właśnie ustawiamy (jeden na raz)
            //dodatkowo przekazuję sobie znak (cyferkę) i switchem ustawię właściwy obrazek
            
            switch (cyfra)
            {
                case '1':
                    ktory_pikczer.Image = Properties.Resources._1;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '2':
                    ktory_pikczer.Image = Properties.Resources._2;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '3':
                    ktory_pikczer.Image = Properties.Resources._3;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '4':
                    ktory_pikczer.Image = Properties.Resources._4;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '5':
                    ktory_pikczer.Image = Properties.Resources._5;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '6':
                    ktory_pikczer.Image = Properties.Resources._6;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '7':
                    ktory_pikczer.Image = Properties.Resources._7;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '8':
                    ktory_pikczer.Image = Properties.Resources._8;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '9':
                    ktory_pikczer.Image = Properties.Resources._9;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

                case '0':
                    ktory_pikczer.Image = Properties.Resources._0;
                    ktory_pikczer.Refresh();
                    ktory_pikczer.Visible = true;
                    break;

            };
        }
        private void button0_Click(object sender, EventArgs e)
        {
            string numer = Convert.ToString(numericUpDown1.Value);      //rzutowanie liczby do stringa (tablicy charów);
            numer = numer + "000000000";        //za krótki string wysypywał prog.

            string miesiac=Convert.ToString(numMiesiac.Value);
            if (numMiesiac.Value < 10)
                miesiac = "0" + miesiac;

            string rok = Convert.ToString(numRok.Value);
            if (numRok.Value < 10)
                rok = "0" + rok;

            //pierwsza kolumna
            dekoduj(pictureBox1K_01, '6');      //typ ASK, stałe
            dekoduj(pictureBox1K_02, '0');
            dekoduj(pictureBox1K_03, '2');      //strefa, stałe

            label1.Text = "6"; label2.Text = "0"; label3.Text = "2";
            label11.Text = "602 11" + miesiac[0] + " " + miesiac[1] + rok[1] + "9";

            dekoduj(pictureBox2K_01, '1');          //dzień sprawdzenia, nie drukowany
            dekoduj(pictureBox2K_02, '1');          //dzień sprawdzenia, nie drukowany
            dekoduj(pictureBox2K_03, miesiac[0]);   //miesiąc sprawdzenia, dziesiątki [0..1]

            label4.Text = "1"; label5.Text = "1"; label6.Text = miesiac[0]+"";
            label14.Text = "11" + miesiac[0] + " - sprawdzenie: [dd, m] (dzień: przykładowo)";

            dekoduj(pictureBox3K_01, miesiac[1]);   //miesiąc sprawdzenia, jedności [0..9]
            dekoduj(pictureBox3K_02, rok[1]);       //rok sprawdzenia, jedności [0..9]
            dekoduj(pictureBox3K_03, '9');          //liczba kart [0..9]

            label7.Text = miesiac[1] + ""; label8.Text = rok[1] + ""; label9.Text = "9";
            label15.Text = Convert.ToString(miesiac[1]) + Convert.ToString(rok[1]) + "9"+" - sprawdzenie: [m, r, l.kart]";
         MessageBox.Show( rok[1]+"", "rok");
         MessageBox.Show(miesiac[1] + "", "miesiąc");

            label16.Text = "0" + ""; label17.Text = "2" + ""; label18.Text = "8";
            label19.Text = "028" + " - 02(zawsze) + 8(numer pocisku)";

            dekoduj(pictureBox4K_01, '0');          //zawsze
            dekoduj(pictureBox4K_02, '2');          //zawsze
            dekoduj(pictureBox4K_03, '8');          //początek numeru [znak1]


            dekoduj(pictureBox1, numer[0]);
            dekoduj(pictureBox2, numer[1]);   //wywołanie funkcji i przekazanie jej nazwy PictureBoxa oraz cyferki jaką trzeba wyświetlić
            dekoduj(pictureBox3, numer[2]);

            dekoduj(pictureBox4, numer[3]);
            dekoduj(pictureBox5, numer[4]);
            dekoduj(pictureBox6, numer[5]);

            dekoduj(pictureBox7, numer[6]);
            dekoduj(pictureBox8, numer[7]); 
            dekoduj(pictureBox9, numer[8]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
