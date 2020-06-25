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
            float numberinput = 0;
            float total = 0f;

            bool zero = false;
            while (zero == false)
            {
                Console.Write("Enter a Number : ");
                float number = float.Parse(Console.ReadLine());

                if (number > 0)
                {
                    total = total + number;
                    numberinput++;
                }
                else if (number == 0)
                {
                    zero = true;
                }

            }

            double average = 0;
            if (numberinput > 0)
            {
                average = total / numberinput;
            }
            Console.WriteLine("Average of all positivie numbers {0}", average.ToString("0.00"));


            Console.ReadKey();
        }
    }
}
