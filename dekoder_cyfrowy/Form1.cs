using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

            numMiesiac.Value = Convert.ToDecimal(DateTime.Now.Month.ToString());
            //string rr = Convert.ToDecimal(DateTime.Now.Year.ToString());
            string rr = DateTime.Now.Year.ToString();
            string roczek = rr[2]+"" + rr[3]+"";
            //MessageBox.Show(roczek);
            numRok.Value = Convert.ToDecimal(roczek);
            //numRok.Value = int_rr;
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
            numer = numer + "000000";        //za krótki string wysypywał prog.
           
            if (numer.Length < 16)
            { MessageBox.Show("zbyt krótki numer pocisku, \n uzupełniam zerami", "komunikat"); }

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
            lbl_dlugi.Text = "602 11" + miesiac[0] + " " + Convert.ToString(miesiac[1]) + Convert.ToString(rok[1]) + "9" + " " + "02" + Convert.ToString(numer[0]) + " " +
                Convert.ToString(numer[1])+ Convert.ToString(numer[2])+ Convert.ToString(numer[3]) + " " +
                Convert.ToString(numer[4]) + Convert.ToString(numer[5]) + Convert.ToString(numer[6]) + " " +
                Convert.ToString(numer[7]) + Convert.ToString(numer[8]) + Convert.ToString(numer[9]);

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
         //MessageBox.Show( rok[1]+"", "rok");
         //MessageBox.Show(miesiac[1] + "", "miesiąc");

            label16.Text = "0" + ""; label17.Text = "2" + ""; label18.Text = Convert.ToString(numer[0]);
            label19.Text = "028" + " - 02(zawsze) + " + Convert.ToString(numer[0]) + " początek typu pocisku";

            dekoduj(pictureBox4K_01, '0');              //zawsze
            dekoduj(pictureBox4K_02, '2');              //zawsze
            dekoduj(pictureBox4K_03, numer[0]);         //początek numeru [znak1]

            label24.Text = Convert.ToString(numer[1]); label25.Text = Convert.ToString(numer[2]); label26.Text = Convert.ToString(numer[3]);
            label27.Text = Convert.ToString(numer[1]) + Convert.ToString(numer[2]) + Convert.ToString(numer[3]) + " - typ pocisku[8511 lub 8514]";

            dekoduj(pictureBox1, numer[1]);
            dekoduj(pictureBox2, numer[2]);   //wywołanie funkcji i przekazanie jej nazwy PictureBoxa oraz cyferki jaką trzeba wyświetlić
            dekoduj(pictureBox3, numer[3]);

            label30.Text = Convert.ToString(numer[4]); label31.Text = Convert.ToString(numer[5]); label32.Text = Convert.ToString(numer[6]);
            label11.Text = Convert.ToString(numer[4]) + Convert.ToString(numer[5]) + Convert.ToString(numer[6]) + " - numer pocisku";

            dekoduj(pictureBox4, numer[4]);
            dekoduj(pictureBox5, numer[5]);
            dekoduj(pictureBox6, numer[6]);

            label33.Text = Convert.ToString(numer[7]); label34.Text = Convert.ToString(numer[8]); label35.Text = Convert.ToString(numer[9]);
            label36.Text = Convert.ToString(numer[7]) + Convert.ToString(numer[8]) + Convert.ToString(numer[9]) + " - numer pocisku";

            dekoduj(pictureBox7, numer[7]);
            dekoduj(pictureBox8, numer[8]); 
            dekoduj(pictureBox9, numer[9]);

        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
           //
        }


    }
}
