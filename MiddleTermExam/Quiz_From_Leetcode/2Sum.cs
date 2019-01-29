using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam
{
    class _2Sum
    {
        public int[] ReturnArray = new int[2];
        public int[] nums = new int[6];
        public int target;
        
        public int[] TwoSum()
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        ReturnArray[0] = i;
                        ReturnArray[1] = j;
                    }
                }
            }
            return ReturnArray;
        }
        
    }
}
