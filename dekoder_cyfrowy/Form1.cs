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
        Int16 pierwszy = 0;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources._0;
        }

        private void button0_Click(object sender, EventArgs e)
        {

           //rzutowanie liczby do stringa (tablicy charów);
            string numer = Convert.ToString(numericUpDown1.Value);
            label1.Text = numer;
           
            //rzutowanie 
            String pierwszyStr = pierwszy.ToString();
            
            switch (numer)
            {
                case "1":
                    pictureBox1.Image = Properties.Resources._1;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

                case "2":
                    pictureBox1.Image = Properties.Resources._2;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

                case "3":
                    pictureBox1.Image = Properties.Resources._3;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

            };
            
        }
    }
}
