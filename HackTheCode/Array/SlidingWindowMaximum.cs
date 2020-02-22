using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SlidingWindowMaximum
    {
        /// <summary>
        /// O(n*k)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] maxWindow= new int[nums.Length-k-1];
            int indexer = 0;
            int max = 0;
            for (int i = 0; i <= nums.Length-k; i++)
            {
                max=Int32.MinValue;
                for (int j = i; j < i + k; j++)
                    max = Math.Max(max, nums[j]);

                maxWindow[indexer] = max;
                indexer++;
            }

            return maxWindow;
        }


    }
}
