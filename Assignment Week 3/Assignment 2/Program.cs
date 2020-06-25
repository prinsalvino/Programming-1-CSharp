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
            Console.WriteLine("Enter a number from 1 to 4");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            switch (number)
            {
                case 1:
                    Console.WriteLine("Clubs");
                    break;
                case 2:
                    Console.WriteLine("Diamonds");
                    break;
                case 3:
                    Console.WriteLine("Hearts");
                    break;
                case 4:
                    Console.WriteLine("Spades");
                    break;
                default:
                    Console.WriteLine("Incorrect Number!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
