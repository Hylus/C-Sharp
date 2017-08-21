using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artifex_moje_zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;


            int[] tab = {-1,3,-4,5,1-6,2,1};
           // solution1 sol = new solution1();
            //sol.rozwiazanie(tab);

            zad1 z1 = new zad1();
            z1.zad(tab);

            //////////////////////
            zad2 z2 = new zad2();
           // int[] tab2 = { 1, 1, 3, 3, 1, 2 };
            int[] tab2 = { 10,5,5,1,7,8,8,7,9,7 };
            x = z2.zadanie2(tab2);


            /////
            int[] tab3 = { 3, 5, 6, 3, 3, 5 };
            zad3 z3 = new zad3();
            x = z3.zadanie3(tab3);

            int[] tab333={1,1,1};
            x = z3.zadanie3(tab333);

            int zzzzzzzz = 5;

            /////////////////////////

        }
    }
}
