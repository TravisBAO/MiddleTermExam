using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam
{
    class Verify_aNb
    {
        public int a;
        public int b;

        //1st way: use if to verify if it is true.
        public void Using_If_One_AdjustTrue()
        {
            if (a == 1)
            {
                Console.WriteLine("a pass!");
                if (b == 1)
                {
                    Console.WriteLine("b pass!");
                    Console.WriteLine("Test PASS");
                }
                else
                {
                    Console.WriteLine("b failed");
                    Console.WriteLine("All test failed");
                }
            }
            else
            {
                Console.WriteLine("a failed");
                Console.WriteLine("All test failed");
            }
        }
        //2nd way: use while to verify if it is false.
        public void Using_While()
        {
            while(!(a == 1))
            {
                Console.WriteLine("a failed!");
                Console.WriteLine("All test failed");
            }
            Console.WriteLine("a pass!");

            while (!(b == 1))
            {
                Console.WriteLine("b failed");
                Console.WriteLine("All test failed");
            }
            Console.WriteLine("b pass!");
            Console.WriteLine("Test PASS");
        }

        //3rd way: use switch case

        public void Using_Switch()
        {
            switch(a)
            {
                case 1:
                    Console.WriteLine("a pass!");
                    switch(b)
                    {
                        case 1:
                            Console.WriteLine("b pass!");
                            Console.WriteLine("Test PASS");
                            break;
                        default:
                            Console.WriteLine("b failed");
                            Console.WriteLine("All test failed");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("a failed!");
                    Console.WriteLine("All test failed");
                    break;
            }
        }
    }
}
