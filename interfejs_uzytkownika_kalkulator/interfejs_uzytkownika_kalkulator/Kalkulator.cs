using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfejs_uzytkownika_kalkulator
{
    class Kalkulator
    {
        double wynik;
        
        public Kalkulator()
        {
            this.wynik = 0;
        }

        public double Wynik { get { return wynik; } set { wynik = value; } }        

        public static double Dodawanie(String a, String b)
        {
            Double la = double.Parse(a);
            Double lb = double.Parse(b);
            return la + lb;
        }

        public static double Odejmowanie(String a, String b)
        {
            Double la = double.Parse(a);
            Double lb = double.Parse(b);
            return la - lb;
        }

        public static double Mnozenie(String a, String b)
        {
            Double la = double.Parse(a);
            Double lb = double.Parse(b);
            return la * lb;
        }

        public static double Dzielenie(String a, String b)
        {
            Double la = double.Parse(a);
            Double lb = double.Parse(b);
            if (lb == 0) throw new DivideByZeroException();
 
            return la / lb;
        }

        public static double SQRT(double a)
        {
            if (a < 0) throw new ArithmeticException();
            double wynik = Math.Sqrt(a);
            return Math.Sqrt(a);
        }

        public static double OdwrocLiczbe(double a)
        {
            return a = (-a);
        }

        public static double OdwrotnoscLiczby(double a)
        {
            return (1/a);
        }

        

    };
}
