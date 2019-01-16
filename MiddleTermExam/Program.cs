using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam
{
    class Program
    {
        static void Main(string[] args)
        {

            SplitString sss = new SplitString();

            sss.SplitBehavior("abc def");

            int[] myIntArray = new int[6] { 1, 2, 3, 4, 5, 6 };

            foreach (var item in myIntArray)
            {
                Console.WriteLine(item);
            }
            _2Sum Test2Sum = new _2Sum();

            Test2Sum.nums = myIntArray;
            Test2Sum.target = 3;
            
            //public 

            Console.WriteLine("Print the return array!!!");
            for (int i = 0; i < Test2Sum.TwoSum().Length; i++)
            {
                Console.WriteLine(Test2Sum.ReturnArray[i]);
            }
            //Console.WriteLine("The return array is {0}:", );

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //Receipt OneReceipt = new Receipt(1,1,1,1.0M,1);

            //decimal total = 0;
            //total = OneReceipt.Calculation();
            //Console.WriteLine("Total Purchases is {0}!", total);
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
