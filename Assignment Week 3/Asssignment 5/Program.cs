using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            string input1 = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            if (number1 % number2 == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (number2 % number1 == 0)
            {
                Console.WriteLine("Number 2 is Multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
            Console.ReadKey();
        }
    }
}
