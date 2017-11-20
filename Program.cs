using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] str = new string[5][]; //example of a jagged array
            str[0] = new string[2];

            str[1] = new string[10];

            str[2] = new string[20];

            str[3] = new string[50];

            str[4] = new string[10];

            str[0][0] = "Pune";

            str[0][1] = "kochin";
            Console.WriteLine(str[0][1]);

          //  str[0][2] = "alabama";
          //  Console.WriteLine(str[0][2]); //throws an exception.. comment it when u wanna use

            str[1][0] = "Kolkata";

            str[2][0] = "Bangalore";

            str[3][0] = "The pink city named Jaipur";

            str[4][0] = "Hyderabad";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(str[i][0]);
                
            }

            foreach (var x in str)
            {
                Console.WriteLine("{0}", x);   
            }



         string [,] str1 = new string[3,4] { { "one", "two","d", "wfg"}, { "three", "four","sd","df" },
                { "five", "six","ss","sd" } };
            try
            {
                foreach (var arr in str1) //use foreach for mulitdimentsonal array
                {
                    Console.WriteLine("{0}" ,arr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }



           

        }
    }
}
