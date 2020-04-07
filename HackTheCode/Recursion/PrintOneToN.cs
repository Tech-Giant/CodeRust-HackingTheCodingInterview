using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class PrintOneToN
    {
        public void CallPrintN()
        {
            Print1ToN(10);
            Console.WriteLine();
            PrintNto1(10);
        }

        void PrintNto1(int n)
        {
            if (n > 0)
            {
                Console.Write(n);
                PrintNto1(n - 1);
            }
        }

        void Print1ToN(int n)
        {
            if (n > 0)
            {
                Print1ToN(n - 1);
                Console.Write(n);
            }
                
        }
    }

    
}
