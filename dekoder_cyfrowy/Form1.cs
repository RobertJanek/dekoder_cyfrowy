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
            
            //ify docelowo zastąpię switchem
            if (cyfra == '5')
                ktory_pikczer.Image = Properties.Resources._5;
            if (cyfra == '7')
                ktory_pikczer.Image = Properties.Resources._7;

            ktory_pikczer.Refresh();
            ktory_pikczer.Visible = true;
            }
        private void button0_Click(object sender, EventArgs e)
        {

           //rzutowanie liczby do stringa (tablicy charów);
            string numer = Convert.ToString(numericUpDown1.Value);
            label1.Text = numer;

            dekoduj(pictureBox2,'5');   //wywołanie funkcji i przekazanie jej nazwy PictureBoxa oraz cyferki jaką trzeba wyświetlić
            dekoduj(pictureBox3, '7');
            //dekoduj(pictureBox1, numer[0]);
            
            //tego switcha przenieść do funkcji dekoduj()
            switch (numer[0])
            {
                case '1':
                    pictureBox1.Image = Properties.Resources._1;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

                case '2':
                    pictureBox1.Image = Properties.Resources._2;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

                case '3':
                    pictureBox1.Image = Properties.Resources._3;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

            };
            
        }
    }
}
