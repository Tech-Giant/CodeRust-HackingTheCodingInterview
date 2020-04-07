using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String.StringMatching;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "GEEKS FOR GEEKS";
            string pat = "GEEK";
            int q = 101; // A prime number  
            string_robinkarp rkarp = new string_robinkarp();
            rkarp.search(pat, txt, q);
        }
    }
}
