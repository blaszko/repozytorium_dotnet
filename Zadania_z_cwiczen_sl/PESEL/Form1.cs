﻿using System;
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

        public bool sprawdzPoprawnoscNumeruPesel(string pesel)
        {
            bool dlugosc = sprawdzDlugosc(pesel);
            bool dopuszczalneZnaki = sprawdzCzyLiczba(pesel);
            bool liczbaKontrolna = sprawdzLiczbeKontrolna(pesel);

            if (dlugosc && dopuszczalneZnaki && liczbaKontrolna)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string wpiszDateUrodzenia(string pesel)
        {
            string dzien, miesiac, rok, data, zmienna;

            if (sprawdzPoprawnoscNumeruPesel(pesel))
            {
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

                return data;
            }
            else
            {
                return "Pesel nieprawidlowy";
            }

            //tbDataUrodzenia.Text = data;
        }

        public string wpiszPlec(string pesel)
        {
            string plec;
            int liczbaPlec;

            if (sprawdzPoprawnoscNumeruPesel(pesel))
            {
                liczbaPlec = int.Parse(pesel.Substring(6, 3));

                if (liczbaPlec % 2 == 0)
                    plec = "Kobieta";
                else
                    plec = "Mężczyzna";

                return plec;
            }
            else
            {
                return "Pesel nieprawidlowy";
            }
        }
        public string wpiszCzyPoprawnyPesel(string pesel)
        {
            string komunikat;

            if (sprawdzPoprawnoscNumeruPesel(pesel))
            {
                komunikat = "Pesel prawidlowy";
                return komunikat;
            }
            else
            {
                komunikat = "Pesel nieprawidlowy";
                return komunikat;
            }
        }

        private void bSprawdzPesel_Click(object sender, EventArgs e)
        {
            pesel = tbPesel.Text;

            tbPlec.Text = wpiszPlec(pesel);
            tbDataUrodzenia.Text = wpiszDateUrodzenia(pesel);//
            tbSprawdzPesel.Text = wpiszCzyPoprawnyPesel(pesel);
        }
    }
}

