using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target number : ");
            string input1 = Console.ReadLine();
            int targetnumber = int.Parse(input1);

            Console.Write("Enter Number : ");
            string input2 = Console.ReadLine();
            int number = int.Parse(input2);

            int target = 0;
            while (number != 0)
            {

                if (targetnumber == number)
                {
                    target++;
                }
                Console.Write("Enter Number = ");
                number = int.Parse(Console.ReadLine());
               
            }
            Console.Write("Count of numbers equal to target = {0}", target);
            Console.ReadKey();
        }
    }
}
