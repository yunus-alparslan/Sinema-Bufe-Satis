using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class Form1 : Form
    {
        int mısır, su, çay, bilet, hesapla, hesapla2, hesapla3, hesapla4, geneltoplam;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            

            mısır = 4;
            su = 1;
            çay = 2;
            bilet = 8;

            hesapla = Convert.ToInt16(textBox1.Text);
            hesapla2 = Convert.ToInt16(textBox2.Text);
            hesapla3 = Convert.ToInt16(textBox3.Text);
            hesapla4 = Convert.ToInt16(textBox4.Text);

            geneltoplam = mısır * hesapla + su * hesapla2 + çay * hesapla3 + hesapla4 * bilet;

            if (geneltoplam == 0)
            {
                MessageBox.Show("Error");
            }

            label12.Text = geneltoplam.ToString();


           

         


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
         

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
