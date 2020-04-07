using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class SumOfDigits
    {
        public void Sum()
        {
            int n = SUM(154);
            Console.WriteLine(n);
        }


        private int SUM(int n)
        {
            if (n == 0 || n < 0) return n;
            int val = n % 10;
            return val + SUM(n / 10);
        }
    }
}
