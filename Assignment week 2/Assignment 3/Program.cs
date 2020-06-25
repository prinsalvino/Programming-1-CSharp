using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter seconds :");
            
            string input = Console.ReadLine();
            Console.WriteLine("Your Seconds = {0}", input);

            Console.ReadKey();


            int seconds = int.Parse(input);

            int hours = seconds / 3600;
            seconds = seconds - hours * 3600;

            int minutes = seconds /60;
            seconds = seconds - minutes * 60;
            
          

            Console.WriteLine("{0}:{1}:{2}", hours, minutes,seconds);


            Console.ReadKey();
                
            

        }
    }
}
