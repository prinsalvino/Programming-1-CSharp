using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool zero = false;
            while(zero == false)
            {
                Console.Write("Enter a number : ");
                int input1 = int.Parse(Console.ReadLine());
                if (input1 > 0)
                {
                    for (int i = 0; i < input1 / 2; i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 0; i < input1/2; i++)
                    {
                        Console.Write("!");
                    }
                    if (input1%2 != 0)
                    {
                        Console.Write("!");
                    }
                    
                }
                else if (input1 < 0)
                {
                    Console.WriteLine("Enter positive number");
                }
                else if(input1 == 0)
                {
                    zero = true;
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
