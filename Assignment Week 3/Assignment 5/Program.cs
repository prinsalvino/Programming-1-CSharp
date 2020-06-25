using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number :");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number :");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter Third Number");
            string input3 = Console.ReadLine();

            double nmr1 = double.Parse(input1);
            double nmr2 = double.Parse(input2);
            double nmr3 = double.Parse(input3);

            double sum = (nmr1 + nmr2 + nmr3);
            double average = (sum / 3);
            double product = (nmr1 * nmr2 * nmr3);

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0:0.00}", average);
            Console.WriteLine("Product = {0}", product);

            if (nmr1 > nmr2 && nmr1 > nmr3)
            {
                Console.WriteLine("The biggest is {0}", nmr1);
            }
            else if (nmr2 > nmr1 && nmr2 > nmr3)
            {
                Console.WriteLine("The biggest is {0}", nmr2);
            }
            else
            {
                Console.WriteLine("The biggest is {0}", nmr3);
            }

            //below is for the lowest

            if (nmr1 < nmr2 && nmr1 < nmr3)
            {
                Console.WriteLine("The lowest is {0}", nmr1);
            }
            else if (nmr2 < nmr1 && nmr2 < nmr3)
            {
                Console.WriteLine("The lowest is {0}", nmr2);
            }
            else
            {
                Console.WriteLine("The lowest is {0}", nmr3);
            }
            Console.ReadKey();
        }
    }
}
