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
            int order = 0;
            int sum = 0;

            bool zero = false;
            while (!zero)
            {
                order++;
                Console.Write("Enter a Number : ");
                int number = int.Parse(Console.ReadLine());

                if ((order % 5) == 0)
                {
                    sum = sum + number;
                }

                zero = (number == 0);

            }
            Console.WriteLine("Sum of 5th, 10th , 15th , . . . number is : {0}", sum);
            Console.ReadKey();
        }
    }
}
