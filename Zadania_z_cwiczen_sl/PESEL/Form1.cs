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

        public void sprawdzLiczbeKontrolna(string pesel)
        {
            string informacja;
            char[] cyfry = pesel.ToCharArray();
            int cyfra1, cyfra2, cyfra3, cyfra4, cyfra5, cyfra6, cyfra7, cyfra8, cyfra9, cyfra10, cyfra11;

            cyfra1 = (int)Char.GetNumericValue(cyfry[0]);
            cyfra2 = (int)Char.GetNumericValue(cyfry[1]);
            cyfra3 = (int)Char.GetNumericValue(cyfry[2]);
            cyfra4 = (int)Char.GetNumericValue(cyfry[3]);
            cyfra5 = (int)Char.GetNumericValue(cyfry[4]);
            cyfra6 = (int)Char.GetNumericValue(cyfry[5]);
            cyfra7 = (int)Char.GetNumericValue(cyfry[6]);
            cyfra8 = (int)Char.GetNumericValue(cyfry[7]);
            cyfra9 = (int)Char.GetNumericValue(cyfry[8]);
            cyfra10 = (int)Char.GetNumericValue(cyfry[9]);
            cyfra11 = (int)Char.GetNumericValue(cyfry[10]);

            tbSprawdzPesel.Text = Convert.ToString(cyfra);
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
                bWyczyscFormularz.PerformClick();
            }
        }
    }
}
