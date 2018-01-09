using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESEL
{

    public partial class Form1 : Form
    {
        string pesel = "abcdef";

        string plec;
        string poprawnyPesel;
        string dataUrodzenia;
        public Form1()
        {
            InitializeComponent();
        }

        private void bWyczyscFormularz_Click(object sender, EventArgs e)
        {
            tbDataUrodzenia.Text = "";
            tbPesel.Text = "";
            tbPlec.Text = "";
            tbSprawdzPesel.Text = "";
        }

        private void bSprawdzPesel_Click(object sender, EventArgs e)
        {
            int dlugoscPesel;
            bool czyNumer;


            pesel = tbPesel.Text;

            dlugoscPesel = pesel.Count();

            if ((dlugoscPesel != 11) || pesel.Contains("+") || pesel.Contains("-"))
            {
                bWyczyscFormularz.PerformClick();
            }

            czyNumer = Regex.IsMatch(pesel, @"^\d+$");
            if (!czyNumer)
            {
                bWyczyscFormularz.PerformClick();
            }

            int liczbaPlec;
            liczbaPlec = int.Parse(pesel.Substring(6, 3));

            if (liczbaPlec % 2 == 0)
                tbPlec.Text = "Kobieta";
            else
                tbPlec.Text = "Mężczyzna";

        }
    }
}
