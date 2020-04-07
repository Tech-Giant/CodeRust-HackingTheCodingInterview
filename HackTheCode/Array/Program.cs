using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maxArr = new int[] {7, 6, 4, 3, 1};

            MaxSellProfit maxProfit = new MaxSellProfit();
            maxProfit.MaxProfit_OneTransaction(maxArr);

            int[] arr4 = new int[] { 0, 1, 0, 3, 12 };
            MoveZerosToLeft moveZeros =new MoveZerosToLeft();
            moveZeros.move_zeros_to_left_in_array(new int[]{ 0, 1, 0, 3, 12 });
            foreach (var i in arr4)
            {
                Console.WriteLine(i.ToString() + ", ");
            }
            int[] arr = new int[]{1,2,3,4,5,6,7};
            ReverseArray rArray = new ReverseArray();
            rArray.Reverse(arr, 0, 6);

            foreach (var i in arr)
            {
                Console.WriteLine(i.ToString() + ", " );
            }

            SmallestCommonNumber smallestCommonNumber = new SmallestCommonNumber();
            int[] arr1 = new int[] { 6,7,10,25,30,63,64};
            int[] arr2 = new int[] { 1,4,5,6,7,8,50 };
            int[] arr3 = new int[] { 1,6,10,14 };
            int number = smallestCommonNumber.LeastCommonNumber(arr1, arr2, arr3);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
