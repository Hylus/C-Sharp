using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artifex_moje_zadania
{
    class zad2
    {
        public int zadanie2(int[] A)
        {
            if (A.Equals(null))
            {
                return -1;
            }

            if (A.Length < 1 || A.Length > 100000)
            {
                return -1;
            } 

            List<int>Lista = new List<int>(A);
            bool powtorz = false;
            bool usun = false;

            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = 1; j < Lista.Count; j++)
                {
                    if (Lista[i] == Lista[j])
                    {
                        Lista.RemoveAt(j);
                        usun = true;
                        powtorz = true;
                        if (Lista.Count != j) j--;
                    }
                    else if (usun == false)
                    {
                        powtorz = false;
                    }
                }

                if (powtorz == false)
                {
                    return Lista[i];
                }
                if (usun == true)
                {
                    Lista.RemoveAt(i);
                    usun = false;
                    i--;
                    powtorz = false;
                }
            }

            return -1;
        }
    }
}
