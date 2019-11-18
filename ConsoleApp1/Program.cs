using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            Cas_Deo1();
            Console.ReadKey();
        }

        /*
         * Prvi deo casa,nullables,i null colescing operator
         * Ternary operator
         * 
         */

        static void Cas_Deo1();
        {

        }

            double? num1 = 1;
            double? num2 = 3.14159;
            double? numR;

            //Pregledniji i sazetiji nacin
            numR = num1 ?? num2;

            //"Razvuceni" nacin
            if(num1 == null)
            {
                numR = num2;
            }
            else
            {
                numR = num1;
            }

            //Ternarni operator
            numR = (num1 == null) ? num1 : num2;

            Console.WriteLine("Value of numR is {0}", numR);
            Console.ReadKey();
        }
    }
}
