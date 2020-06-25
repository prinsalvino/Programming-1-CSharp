using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double number1 = rnd.Next(1, 10);
            double number2 = rnd.Next(1, 10);
            double number3 = rnd.Next(1, 10);

            Console.WriteLine("1st Number = {0}", number1);
            Console.WriteLine("2nd Number = {0}", number2);
            Console.WriteLine("3rd Number = {0}", number3);

            Console.ReadKey();

            double average = (number1 + number2 + number3) / 3;

            Console.Write("The average number is {0}", average);

            Console.ReadKey();


        }
    }
}
