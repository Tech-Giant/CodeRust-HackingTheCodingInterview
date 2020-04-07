using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Abc +001239-./_@";
            Console.WriteLine(s1);
            string replacedValue = Regex.Replace(s1, "[^a-zA-Z-_0-9.+-]", "");
            Console.WriteLine(replacedValue);
            Console.ReadKey();

            


            MaximumCutsInROD maxCutsINROD = new MaximumCutsInROD();
            int ddd = maxCutsINROD.MaxCutsSolution(5, 1, 2, 3);

            Console.WriteLine(ddd);

            Console.ReadKey();

            SumOfDigits sod= new SumOfDigits();
            sod.Sum();

            PrintOneToN p = new PrintOneToN();
            p.CallPrintN();
            Console.ReadKey();
        }
    }
}
