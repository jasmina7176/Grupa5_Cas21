using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            bool? isItTrue = true;

            if (isItTrue != null)
            {
                if (isItTrue == true)
                {
                    Console.WriteLine("Value is TRUE.");
                }
                else 
                {
                    Console.WriteLine("Value is FALSE.");
                }
            }
            else
            {
                Console.WriteLine("Value is not chosen.");
            }
            Console.ReadKey();
        }
    }
}
