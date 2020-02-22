using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class BinarySearch
    {
        public int IterativeSearch(int[] array, int key)
        {
            int searchedIndex = -1;
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int medium = (low + high) / 2;

                if (array[medium] > key)
                {
                    high = medium - 1;
                }
                else if(array[medium] < key)
                {
                    low = medium + 1;
                }
                else
                {
                    searchedIndex = medium;
                    break;
                }
            }

            return searchedIndex;
        }

        public int RecursiveBinarySearch(int[] array, int key)
        {
            return RecursiveSearch(array, 0, array.Length-1,key);
        }

        public int RecursiveSearch(int[] array, int low, int high, int key)
        {
            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            if (key == array[mid])
                return mid;
            else if (key > array[mid])
                return RecursiveSearch(array, mid + 1, high, key);
            else
            {
                return RecursiveSearch(array, low, mid - 1, key);
            }
        }
    }
}
