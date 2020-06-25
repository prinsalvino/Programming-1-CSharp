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
            bool zero = false;
            while (zero == false)
            {
                Console.Write("Enter a number (0 is stop value) :");
                string input = Console.ReadLine();
                int input1 = int.Parse(input);
                zero = IsPrimeNumber(input1);               
            }
            Console.ReadKey();
        }

        static bool IsPrimeNumber(int number)
        {
            bool zero = false;
            if (number == 0)
            {
                Console.WriteLine("Program Stopped");
                zero = true;
            }
            else if (number < 0)
            {
                Console.WriteLine("Please enter positive number");
            }
            else if (number > 0)
            {
                int check = 0;

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        check++;
                    }
                }
                if (check == 1)
                {
                    Console.WriteLine("{0} is a prime number", number);

                }
                else
                {
                    Console.WriteLine("{0} is not a prime number", number);

                }
            }
            return zero;
        }
    }
}
