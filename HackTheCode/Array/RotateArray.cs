using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class RotateArray
    {
        private void ReverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }


        public void Rotate(int[] arr, int n)
        {
            int length = arr.Length;

            n = n % length;

            if (n < 0)
            {
                n = n + length;
            }

            ReverseArray(arr, 0, length-1);
            ReverseArray(arr, 0, n-1);
            ReverseArray(arr, n, length - 1);
        }
    }
}
