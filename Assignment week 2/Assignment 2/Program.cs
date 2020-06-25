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

            Random rnd = new Random();
            int number1 = rnd.Next(1, 10);
            int number2 = rnd.Next(1, 10);
            int number3 = rnd.Next(1, 10);
           
            Console.WriteLine("1st Number = {0}", number1);
            Console.WriteLine("2nd Number = {0}", number2);
            Console.WriteLine("3rd Number = {0}", number3);

           // Console.ReadKey();

            double average = (number1 + number2 + number3) / 3.0;

            Console.Write("The average number is {0}", average);

            Console.ReadKey();



        }
    }
}
