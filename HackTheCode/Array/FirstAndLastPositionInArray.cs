using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FirstAndLastPositionInArray
    {
        //Example 1:

        //Input: nums = [5,7,7,8,8,10], target = 8
        //Output: [3,4]
        //Example 2:

        //Input: nums = [5,7,7,8,8,10], target = 6
        //Output: [-1,-1]
        //This is order n solutions
        public int[] SearchRange(int[] nums, int target)
        {
            int[] outputArray = new[] {-1, -1};
            int leftTarget = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    outputArray[0] = i;
                    leftTarget = i;
                    break;
                }
            }

            if (leftTarget == -1)
            {
                return outputArray;
            }

            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] == target)
                {
                    outputArray[1] = j;
                    break;
                }
            }

            return outputArray;
        }

        
    }
}
