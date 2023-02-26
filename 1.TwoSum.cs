using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
   public class _1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indexes= new int[2];

            for(int i=0;i<nums.Length;i++)
            {
                int firstValue = nums[i];
                for (int x = i+1; x < nums.Length; x++)
                {
                    int secondValue = nums[x ];
                    int result = firstValue + secondValue;
                    if (result == target)
                    {
                        indexes[0] = i;
                        indexes[1] = x;
                        break;
                    }
                }
               
             
               

            }
           return indexes;
        }
    }
}
