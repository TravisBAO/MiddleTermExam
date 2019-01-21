using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam
{
    class ReverseInt
    {
        public int Reverse(int x)
        {
            int ret = 0;

            while (x != 0)
            {
                int nextDigit = x % 10;
                x = x / 10;

                // c# way to check for int overflow
                try
                {
                    ret = checked((ret * 10) + nextDigit);
                }
                catch (System.OverflowException)
                {
                    // overflow
                    return 0;
                }
            }

            return ret;
        }
    }
}
