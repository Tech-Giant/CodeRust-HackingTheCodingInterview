using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        //Find min index and then swap the values
        private void Sort(int[] arr)
        {
            int minIndexer = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //Find the Min Index
                minIndexer = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndexer])
                    {
                        minIndexer = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndexer];
                arr[minIndexer] = temp;
            }
        }
        
    }
}
