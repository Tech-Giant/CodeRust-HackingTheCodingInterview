using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SmallestCommonNumber
    {
        public int LeastCommonNumber(int[][] arr)
        {
            int commonNumber = 0;

           

            return commonNumber;
        }

        public int LeastCommonNumber(int[] arr1, int[] arr2, int[] arr3)
        {
            int commonNumber = 0;
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
                {
                    commonNumber = arr1[i];
                    break;
                }

                if (arr1[i] <= arr2[j] && arr1[i] <= arr3[k])
                {
                    i++;
                }

                else if (arr2[j] <= arr1[i] && arr2[j] <= arr3[k])
                {
                    j++;
                }

                else if(arr3[k] <= arr1[i] && arr3[k] <= arr2[j])
                {
                    k++;
                }
            }


            return commonNumber;


        }
    }
}
