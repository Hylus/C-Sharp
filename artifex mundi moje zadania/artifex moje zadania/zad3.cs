using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artifex_moje_zadania
{
    class zad3
    {
        public int zadanie3(int[] A)
        {
            if (A.Equals(null))
            {
                return 0;
            }

            if (A.Length < 2 || A.Length > 100000)
            {
                return 0;
            }

            int licznik = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        licznik++;
                    }

                    if (licznik > 1000000000)
                    {
                        return 1000000000;
                    }
                }
            }
            return licznik;            
        }
    }
}
