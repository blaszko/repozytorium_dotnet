using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string liczbaPierwsza, liczbaDruga;
        char rodzajDzialania = ' ';

        private void bPodziel_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '/';
            tbWynik.Text = "";

        }

        private void bOdejmij_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '-';
            tbWynik.Text = "";
        }

        private void bPomnoz_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '*';
            tbWynik.Text = "";
        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '+';
            tbWynik.Text = "";
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (rodzajDzialania)
            {
                case ('+'):
                    tbWynik.Text = Convert.ToString((Convert.ToInt32(liczbaPierwsza) + Convert.ToInt32(liczbaDruga)));
                    break;
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            dzialanie(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            dzialanie(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            dzialanie(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            dzialanie(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            dzialanie(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            dzialanie(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            dzialanie(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            dzialanie(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            dzialanie(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            dzialanie(9);
        }

        private void dzialanie(int liczba)
        {
            if (rodzajDzialania == ' ')
            {
                liczbaPierwsza += liczba;
                tbWynik.Text = liczbaPierwsza;
            }
            else
            {
              
                liczbaDruga += liczba;
                tbWynik.Text = liczbaDruga;
            }    
        
        }

        private void bKasuj_Click(object sender, EventArgs e)
        {

        }
    }
}
