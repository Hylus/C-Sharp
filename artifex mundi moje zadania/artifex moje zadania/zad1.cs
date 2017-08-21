using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace artifex_moje_zadania
{
    class zad1
    {
        public int zad(int[] A)
        {
            if (A.Equals(null))
            {
                return 0;
            }

            if (A.Length < 1 || A.Length > 100000)
            {
                return 0;
            }

            int min = A[0];
            int max = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min) min = A[i];
                if (A[i] > max) max = A[i];
            }
            return max - min;
        }
    }
}
