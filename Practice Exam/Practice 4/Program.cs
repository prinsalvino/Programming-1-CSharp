using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            int count = 0;
            int total = 1;
            bool zero = false;

            while (zero == false)
            {
                int number = r.Next(0, 10);

                if (number == 0)
                {
                    zero = true;
                }

                for (int i = 0; i < number; i++)
                {
                    count++;
                     total = total * count;
                }
               
                Console.WriteLine("Factorial of {0} number is {1}", number, total);
            }
           
            Console.ReadKey();
        }
    }
}
