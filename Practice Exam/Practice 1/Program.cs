using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter a word : ");
            string original = Console.ReadLine();
            string reverse = "";

            for (int i = 0; i < original.Length; i++)
            {
                char words = original[i];
                reverse = words + reverse;
              
            }
            if (original == reverse)
            {
                Console.WriteLine("Word is palidrome");
            }
            else
            {
                Console.WriteLine("Word is not a palidrome");

            }
            Console.ReadKey();
        }
    }
}
