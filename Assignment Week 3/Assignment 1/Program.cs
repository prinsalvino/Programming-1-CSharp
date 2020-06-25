using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            String input1 = Console.ReadLine();


            Console.WriteLine("Enter Second Number:");
            String input2 = Console.ReadLine();

            int first = int.Parse(input1);
            int second = int.Parse(input2);
            
            if (first > second)
            {
                Console.WriteLine("highest value is: {0}", first);
                Console.WriteLine("lowest value is: {0}", second);
            }
            else
            {
                Console.WriteLine("highest value is: {0}", second);
                Console.WriteLine("lowest value is: {0}", first);
            }
            Console.ReadKey();
        }    
    }
}
