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
            int previous = 1;
            int before = 1;
            Console.Write("{0}, {1}, ", previous, before);
            for (int i = 1; i <= 18; i++)
            {
                int sum = (previous + before);
                Console.Write("{0}, ", sum);

                previous = before;
                before = sum;
                
            }
            Console.ReadKey();
        }
    }
}
