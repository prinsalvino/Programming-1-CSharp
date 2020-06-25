using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool zero = false;

            while (zero == false)
            {
                Console.Write("Enter a year: ");
                int year = int.Parse(Console.ReadLine());

                

                if( year < 0)
                {
                    Console.WriteLine("Please enter positive number");
                }
                else if (year == 0)
                {
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

            }
            Console.ReadKey();
        }
    }
}
