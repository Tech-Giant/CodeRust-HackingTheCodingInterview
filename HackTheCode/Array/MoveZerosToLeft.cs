using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MoveZerosToLeft
    {
        public void move_zeros_to_left_in_array(int[] A)
        {
            int j, i;
            int zeroCounter = 0;
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    zeroCounter++;
                }
            }

            j = A.Length - 1;
            for (i = A.Length - 1; i >= 0; i--)
            {
                while (j > 0 && A[j] == 0)
                {
                    j--;
                }

                if(j < i)
                    A[i] = A[j];
                else
                {
                    j--;
                }

            }

            for (i = 0; i < zeroCounter; i++)
            {
                A[i] = 0;
            }
        }

        public void move_zeros_to_right_in_array(int[] A)
        {
            int j, i;
            int zeroCounter = 0;
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    zeroCounter++;
                }
            }

            j = A.Length - 1;
            for (i = A.Length - 1; i >= 0; i--)
            {

                while (A[j] == 0)
                {
                    j--;
                }

                A[i] = A[j];

            }

            for (i = 0; i < zeroCounter; i++)
            {
                A[i] = 0;
            }
        }
    }
}
