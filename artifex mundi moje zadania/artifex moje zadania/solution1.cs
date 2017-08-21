using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artifex_moje_zadania
{
    class solution1
    {
        public int rozwiazanie(int[] A)
        {
            if (A.Equals(null))
            {
                return -1;
            }

            if (A.Length < 1 || A.Length > 100000)
            {
                return -1;
            }

            int suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                suma += A[i];
            }

            int roz = 0;
            for (int j = 0; j < A.Length; j++)
            {                                
                roz += j - 1 < 0 ? 0 : A[j - 1];
                suma -= A[j];
                if (roz == suma)
                {
                    return j;
                }
            }
            return -1;
        }
    }
}


