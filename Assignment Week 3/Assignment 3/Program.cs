using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter Third Number");
            string input3 = Console.ReadLine();

            int nmr1 = int.Parse(input1);
            int nmr2 = int.Parse(input2);
            int nmr3 = int.Parse(input3);

            if (nmr1 > nmr3 && nmr2 > nmr3)
            {
                Console.WriteLine("The third number is the smallest of the tree");
            }
            else // if (nmr1 < nmr3)
            {
                Console.WriteLine("The third number is not the smallest of the tree");
            }

            Console.ReadKey();
        }
    }
}