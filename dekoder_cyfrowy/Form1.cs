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
            if (radioButton1.Checked == true) pierwszy = 1;
            if (radioButton2.Checked == true) pierwszy = 2;
            if (radioButton3.Checked == true) pierwszy = 3;

            //rzutowanie 
            String pierwszyStr = pierwszy.ToString();

            switch (pierwszy)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    pictureBox1.Refresh();
                    pictureBox1.Visible = true;
                    break;

            };
            
        }
    }
}
