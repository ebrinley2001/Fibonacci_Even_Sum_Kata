using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FiboEven
{
    public static class FibonacciFunc
    {
        public static int Fibo_Func(int num)
        {
            int sum = 0;
            List<int> seq = new List<int>
            {1,1};

            for (int x = 0; seq[seq.Count - 1] < num; x++)
            {
                seq.Add(seq[x] + seq[x + 1]);
            }

            seq.RemoveAt(seq.Count - 1);

            foreach (int fibNum in seq)
            {
                if (fibNum % 2 == 0)
                {
                    sum += fibNum;
                }
            }

            return sum;
        }
    }
}
