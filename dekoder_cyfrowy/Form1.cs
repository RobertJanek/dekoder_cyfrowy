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

            };
        }
        private void button0_Click(object sender, EventArgs e)
        {
            string numer = Convert.ToString(numericUpDown1.Value);      //rzutowanie liczby do stringa (tablicy charów);
            numer = numer + "000000000";        //za krótki string wysypywał prog.

            string miesiac=Convert.ToString(numMiesiac.Value);
            if (numMiesiac.Value < 10)
                miesiac = "0" + miesiac;
            MessageBox.Show(miesiac, "miesiąc sprawdzenia");

            label14.Text = "11"+miesiac[0]+" - sprawdzenie: [dd, m]";

            string rok = Convert.ToString(numRok.Value);
            if (numRok.Value < 10)
                rok = "0" + rok;
            MessageBox.Show(rok , "miesiąc sprawdzenia");

            //pierwsza kolumna
            dekoduj(pictureBox1K_01, '6');      //typ ASK, stałe
            dekoduj(pictureBox1K_02, '0');
            dekoduj(pictureBox1K_03, '2');      //strefa, stałe

            label1.Text = "6"; label2.Text = "0"; label3.Text = "2";

            dekoduj(pictureBox2K_01, '1');          //dzień sprawdzenia, nie drukowany
            dekoduj(pictureBox2K_02, '1');          //dzień sprawdzenia, nie drukowany
            dekoduj(pictureBox2K_03, miesiac[0]);   //miesiąc sprawdzenia, dziesiątki [0,1]

            label4.Text = "1"; label5.Text = "1"; label6.Text = miesiac[0]+"";

            dekoduj(pictureBox1, numer[0]);
            dekoduj(pictureBox2, numer[1]);   //wywołanie funkcji i przekazanie jej nazwy PictureBoxa oraz cyferki jaką trzeba wyświetlić
            dekoduj(pictureBox3, numer[2]);

            dekoduj(pictureBox4, numer[3]);
            dekoduj(pictureBox5, numer[4]);
            dekoduj(pictureBox6, numer[5]);

            dekoduj(pictureBox7, numer[6]);
            dekoduj(pictureBox8, numer[7]);
            dekoduj(pictureBox9, numer[8]);

            //label1.Text = numer[0]+"";

        }

      
    }
}
