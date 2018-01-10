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
        string pesel;

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

        public bool sprawdzDlugosc(string pesel)
        {
            int dlugosc;
            dlugosc = pesel.Count();
            if ((dlugosc == 11) && !(pesel.Contains("+")) && !(pesel.Contains("-")))
            {
                return true;
            }
            else
                return false;
        }

        public bool sprawdzCzyLiczba(string pesel)
        {
            bool czyNumer;

            czyNumer = Regex.IsMatch(pesel, @"^\d+$");
            if (czyNumer)
            {
                return true;
            }
            else
                return false;
        }

        public bool sprawdzLiczbeKontrolna(string pesel)
        {
            char[] cyfry = pesel.ToCharArray();
            int cyfraKontrolna;
            int[] intAry = new int[11];
            for (int i = 0; i < pesel.Length; i++)
            {
                intAry[i] = (int)Char.GetNumericValue(pesel[i]);
            }
            cyfraKontrolna = (10 - ((intAry[0] * 1 + intAry[1] * 3 + intAry[2] * 7 + intAry[3] * 9 + intAry[4] * 1 + intAry[5] * 3 + intAry[6] * 7 + intAry[7] * 9 + intAry[8] * 1 + intAry[9] * 3) % 10)) % 10;

            if (cyfraKontrolna == intAry[10])
            {
                tbSprawdzPesel.Text = "Pesel prawidlowy";
                return true;
            }
            else
            {
                tbSprawdzPesel.Text = "Pesel nieprawidlowy";
                return false;
            }
        }

        public void wpiszDateUrodzenia(string pesel)
        {
            string dzien, miesiac, rok, data, zmienna;

            dzien = pesel.Substring(4, 2);
            miesiac = pesel.Substring(2, 2);
            rok = pesel.Substring(0, 2);
            zmienna = pesel.Substring(2, 1);
            switch (zmienna)
            {
                case "8":
                    zmienna = "18";
                    break;
                case "2":
                    zmienna = "20";
                    break;
                case "4":
                    zmienna = "21";
                    break;
                case "6":
                    zmienna = "22";
                    break;
                default:
                    zmienna = "19";
                    break;
            }
            data = dzien + "/" + miesiac + "/" + zmienna + rok;

            tbDataUrodzenia.Text = data;
        }
        
        private void bSprawdzPesel_Click(object sender, EventArgs e)
        {
            pesel = tbPesel.Text;

            if ((sprawdzCzyLiczba(pesel) && (sprawdzDlugosc(pesel))))
            {
                int liczbaPlec;
                liczbaPlec = int.Parse(pesel.Substring(6, 3));

                if (liczbaPlec % 2 == 0)
                    tbPlec.Text = "Kobieta";
                else
                    tbPlec.Text = "Mężczyzna";
                wpiszDateUrodzenia(pesel);
                sprawdzLiczbeKontrolna(pesel);
            }
            else
            {
                tbSprawdzPesel.Text = "Pesel nieprawidlowy";
            }
        }
    }
}
