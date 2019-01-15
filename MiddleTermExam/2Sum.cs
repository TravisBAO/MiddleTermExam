using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam
{
    class _2Sum
    {
        static int[] TwoSum(int[] nums, int target)
        {
            public int[] ReturnArray = new int[2];
            for (int i = 0; i<nums.length; i++)
            {
                for (int j = i + 1; j<nums.length; j++)
                {
                    if target == num[i] + num[j]
                        {
                            ReturnArray[0] = i;
                            ReturnArray[1] = j;
                            break;
                        }
                }
                break;
            }
            return ReturnArray;
        }
        
    }
}
