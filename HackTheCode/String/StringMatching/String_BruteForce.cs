using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.StringMatching
{
    public class String_BruteForce
    {
        public bool Matcher(string t, int n, string p, int m)
        {
            bool matched = false;

            for (int indexer = 0; indexer < n - m; indexer++)
            {
                int j = 0;

                while (j < m && p[j] == t[indexer + j])
                {
                    j = j + 1;
                }

                if (j == m)
                {
                    matched = true;
                    break;
                }

            }

            return matched;

        }
    }
}
