using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[20];
            int nrofwords = 0;

            Console.WriteLine("Enter a word : ");
            string input = "";

            do
            {
                input = Console.ReadLine();
                Console.WriteLine("Enter a word : ");
                arr[nrofwords] = input;
                nrofwords++;

            } while (input.Length > 0);
         
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (nrofwords % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;   
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;    
                }
                Console.ResetColor();
                Console.WriteLine("{0}", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
