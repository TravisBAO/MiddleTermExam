using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiddleTermExam
{
    class SplitString
    {
        string stringUnderSplit;
        string[] SplitedInfo = new string[10];


        //Behavior
        public void SplitBehavior(string stringUnderSplit)
        {
            
            int Len = stringUnderSplit.Length;
            string[] strArray = stringUnderSplit.Split(',');
            string[] strArrayWorld;

            Console.WriteLine(Len);
            Console.WriteLine(strArray);

            for (int i = 0; i < Len; i++)
            {
                //if (strArray[i] == ' ')
                //{

                //}
            }

                
        }
    }
}
