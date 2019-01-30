using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam.Quiz_From_Udemy
{
    class ArrarCodingQuiz
    {
        //ArrayCodingQuiz();
        
        public void AdditionIntegers()
        {

            //int[] ValidIntegers = new int[11];
            int[] ValidIntegers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] AccountOfValidInt = new int[11];


            int Total = 0;
            bool ValidInput = true;
            bool ConvertDone = false;

            int ConvertedInput = 0;


            while (ValidInput)
            {
                Console.WriteLine("Input the integer value between 0 and 10 (input -1 to exit):");
                string StringInput = Console.ReadLine();

                // try to convert input value to int
                ConvertDone = int.TryParse(StringInput, out ConvertedInput);

                if (!ConvertDone)
                {
                    Console.WriteLine("Input value isn't integer!");
                }
                else
                {
                    if ((ConvertedInput >= 0) && (ConvertedInput <= 10))
                    {
                        AccountOfValidInt[ConvertedInput] += 1;
                        Total += ConvertedInput;
                    }
                    else if (ConvertedInput == -1)
                    {
                        ValidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Input value isn't in range [0, 10] !");
                    }
                }

            }

            Console.WriteLine("All valid input integers are accounted!");
            Console.WriteLine("Total is {0}.", Total);
            
            foreach (int item in AccountOfValidInt)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
                
            }
            

        }
    }
}
