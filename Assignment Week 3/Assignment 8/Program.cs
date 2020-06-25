using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours : ");
            string input1 = Console.ReadLine();
            Console.Write("Enter number of years : ");
            string input2 = Console.ReadLine();
            Console.Write("Enter number of failures : ");
            string input3 = Console.ReadLine();

            int workinghours = int.Parse(input1);
            int years = int.Parse(input2);
            int failures = int.Parse(input3);

            if (workinghours > 10000 || years >= 7 || failures > 25)
            {
                Console.WriteLine("Machine needs to be replaced");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced");
            }
            Console.ReadKey();
        }
    }
}
