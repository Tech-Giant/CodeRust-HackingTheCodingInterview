using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class FibonaaciNumber
    {
        public void DisplayFibUsingFor()
        {
            int n = 20;
            int t1 = 0;
            int t2 = 1;
            for (int i = 1; i < n; i++)
            {
                Console.Write(t1);
                t2 = t1 + t2;
                t1 = t2;
            }
        }
    }
}
