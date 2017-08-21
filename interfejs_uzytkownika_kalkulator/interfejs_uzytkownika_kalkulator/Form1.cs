using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace interfejs_uzytkownika_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// ////////////////////
        /// 
        bool podwojnyznak = false;
        bool kropka2 = false;
        bool nowe = false;
        bool nowe_po_wyniku = false;
        String znak = "";
        String p = "", d = "";
        int indeksznaku;
        double wynik;
        Kalkulator calc = new Kalkulator();        

        private void button_Click(object sender, EventArgs e)
        {
            if (nowe.Equals(true))
            {
                textBox1.Text = "";
                nowe = false;
            }
            int liczba = 0;
            String a = (sender as Button).Text;
            if (Int32.TryParse(a, out liczba))
            {
                if (nowe_po_wyniku == true) textBox1.Clear();

                if (a.Equals("00"))
                {
                    String l = textBox1.Text;

                    if (kropka2 == true)
                    {
                        string czlon2 = l.Substring(l.IndexOf(znak) + 1);
                        if (czlon2 == "")
                        {
                            textBox1.Text += "0";
                        }
                        else
                        {
                            int indeks = czlon2.IndexOf("0");
                            int indeks2 = czlon2.IndexOf(",");
                            if (indeks == 0 && indeks2 != 1)
                            { }
                            else
                            {
                                textBox1.Text += a;
                            }
                        }
                    }

                    else if (l.Length > 0 && kropka2 == false)
                    {
                        ///
                        int indeks = l.IndexOf("0");
                        int indeks2 = l.IndexOf(",");
                        if (indeks == 0 && indeks2 != 1)
                        { }
                        else
                        {
                            textBox1.Text += a;
                        }
                        ////
                        //  textBox1.Text += "00";
                    }
                    int test = l.IndexOf(",");
                    if (test == -1) { }
                    else if (test == -1 && kropka2 == false)
                    {
                        textBox1.Text += 0;
                    }

                }
                else
                {
                    if (a == "0")
                    {
                        string l = (textBox1.Text);
                        if (kropka2 == true)
                        {
                            string czlon2 = l.Substring(l.IndexOf(znak) + 1);
                            if (czlon2 == "")
                            {
                                textBox1.Text += "0";
                            }
                            else
                            {
                                int indeks = czlon2.IndexOf("0");
                                int indeks2 = czlon2.IndexOf(",");
                                if (indeks == 0 && indeks2 != 1)
                                { }
                                else
                                {
                                    textBox1.Text += a;
                                }
                            }
                        }
                        else if (l.Length > 0 && kropka2 == false)
                        {
                            int indeks = l.IndexOf("0");
                            int indeks2 = l.IndexOf(",");
                            if (indeks == 0 && indeks2 != 1)
                            { }
                            else
                            {
                                textBox1.Text += a;
                            }
                            //string sprawdz = l.Substring(0, indeks);
                        }
                        else
                        {
                            textBox1.Text += a;
                        }
                    }
                    else
                    {
                        if (textBox1.Text == "0")
                        {
                            textBox1.Text = a;
                        }
                        else
                        {
                            textBox1.Text += a;
                        }
                        nowe_po_wyniku = false;
                    }
                }
            }
            else if (a.Equals("DEL"))
            {
                textBox1.Clear();
                nowe_po_wyniku = false;
                nowe = false;
            }
            else if (a.Equals(","))
            {
                int xxx = 0;
                foreach (char x in (textBox1.Text))
                {
                    if (x == ',') xxx++;
                }
                if (kropka2 == false && xxx == 1)
                {
                }

                else if (kropka2 == true && xxx == 2)
                {
                }
                else
                {
                    if (nowe_po_wyniku == true)
                    {
                        textBox1.Text = "0,";
                        nowe_po_wyniku = false;
                        //xxx += 1;
                    }
                    else if (textBox1.TextLength == 0)
                    {
                        textBox1.Text = "0,";
                        // xxx += 1;
                    }
                    else
                    {
                        if (kropka2 == true)
                        {
                            String l = (textBox1.Text).Substring((textBox1.Text).IndexOf(znak) + 1);
                            if (l.Length == 0)
                            {
                                textBox1.Text += "0,";
                            }
                            else
                            {
                                textBox1.Text += ",";
                            }
                            kropka2 = false;
                        }
                        else
                        {
                            String sprawdz = textBox1.Text;
                            int ss = sprawdz.IndexOf(",");
                            if (ss == -1)
                            {
                                textBox1.Text += ",";
                            }
                        }
                    }
                }
            }
            else if (a == "+" || a == "-" || a == "/" || a == "*")
            {
                if (kropka2 == true)
                {
                    a = "=";
                    podwojnyznak = true;
                }
                else
                {
                    if (textBox1.TextLength == 0)
                    {
                        textBox1.Text = "0" + a;
                    }
                    else
                    {
                        textBox1.Text += a;
                    }
                    if (znak == "") znak = a;
                    indeksznaku = (textBox1.Text).LastIndexOf(znak);
                    p = (textBox1.Text).Substring(0, indeksznaku);
                    d = (textBox1.Text).Substring(indeksznaku + 1);
                    nowe_po_wyniku = false;
                    kropka2 = true;
                }
            }

           // else if (a == "=")
            if (a == "=" && (textBox1.Text).Length>0)
            {
                p = (textBox1.Text).Substring(0, indeksznaku);
               // if (indeksznaku == 1) { }
                //else
                d = (textBox1.Text).Substring(indeksznaku + 1);
                if (podwojnyznak == true) d = p;
                if (p.Length > 0 && d.Length > 0)
                {
                    if (znak == "+")
                    {
                        wynik = Kalkulator.Dodawanie(p, d);
                        textBox1.Text = wynik.ToString();
                    }

                    if (znak == "-")
                    {
                        wynik = Kalkulator.Odejmowanie(p, d);
                        textBox1.Text = wynik.ToString();
                    }

                    if (znak == "*")
                    {
                        wynik = Kalkulator.Mnozenie(p, d);
                        textBox1.Text = wynik.ToString();
                    }

                    if (znak == "/")
                    {
                        try
                        {
                            wynik = Kalkulator.Dzielenie(p, d);
                            textBox1.Text = wynik.ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            textBox1.Text = "SYNTAX_ERROR";
                        }
                    }
                }
                //    textBox1.Text = wynik.ToString();
                nowe_po_wyniku = true;
                kropka2 = false;
                znak = "";
                podwojnyznak = false;
                indeksznaku = 0;
                int xxdd = (textBox1.Text).LastIndexOf("+");
                if (textBox1.Text.Length == (textBox1.Text).LastIndexOf("+") || textBox1.Text.Length == (textBox1.Text).LastIndexOf("-") || textBox1.Text.Length == (textBox1.Text).LastIndexOf("/") || textBox1.Text.Length == (textBox1.Text).LastIndexOf("*"))
                {
                    textBox1.Text = textBox1.Text.Substring(0, (textBox1.Text).LastIndexOf("+"));
                }
            }

            else if (a.Equals("sqrt"))
            {
                double lic;
                if ((double.TryParse(textBox1.Text, out lic)))
                {
                    try
                    {
                        wynik = Kalkulator.SQRT(lic);
                        textBox1.Text = wynik.ToString();
                    }
                    catch (ArithmeticException)
                    {
                        textBox1.Text = "niepoprawne dane";
                    }
                }
            }
            else if (a.Equals("+/-"))
            {
                double lic;
                if ((double.TryParse(textBox1.Text, out lic)))
                {

                    wynik = Kalkulator.OdwrocLiczbe(lic);
                    textBox1.Text = wynik.ToString();
                }
            }
            else if (a.Equals("1/x"))
            {
                double lic;
                if ((double.TryParse(textBox1.Text, out lic)))
                {

                    wynik = Kalkulator.OdwrotnoscLiczby(lic);
                    textBox1.Text = wynik.ToString();
                }
            }


            else if (a.Equals("M+"))
            {
                double lic;
                if ((double.TryParse(textBox1.Text, out lic)))
                {
                    calc.Wynik += lic;
                    textBox1.Text = wynik.ToString();
                }
            }


            else if (a.Equals("M-"))
            {
                double lic;
                if ((double.TryParse(textBox1.Text, out lic)))
                {
                    calc.Wynik -= lic;
                    textBox1.Text = wynik.ToString();
                }
            }

            else if (a.Equals("MR"))
            {
                if (kropka2 == true) textBox1.Text += (calc.Wynik).ToString();
                else textBox1.Text = (calc.Wynik).ToString();
            }

            else if (a.Equals("MC"))
            {
                calc.Wynik = 0;
            }            
        }
    };
}
