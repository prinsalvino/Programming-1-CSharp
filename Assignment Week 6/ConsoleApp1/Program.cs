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
            int number = 0;
            bool zero = false;

            while (zero == false)
            {
                Console.Write("Enter Year (0 is stop value) : ");
                number = int.Parse(Console.ReadLine());

                zero = IsLeapYear(number);
            }
            Console.ReadKey();
        }
        static bool IsLeapYear(int year)
        {
            bool zero = false;
            if (year < 0)
            {
                Console.WriteLine("Please enter positive number");
            }
            else if (year == 0)
            {
                Console.WriteLine("Program Stopped");
                zero = true;
            }
            else if ((year % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else if (((year % 4) == 0) && ((year % 100) != 0))
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            return zero;
        }
    }
}
