using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Weight (kg) : ");
            string input1 = Console.ReadLine();
            Console.Write("Enter length (cm) : ");
            string input2 = Console.ReadLine();
            Console.Write("Enter gender (male/female) : ");
            string input3 = Console.ReadLine();

            double weight = double.Parse(input1);
            double length = double.Parse(input2);

            double square = (length / 100) * (length / 100);
            double bmi = weight / square;
            double h1male = 20 * square;
            double h2male = square * 25;
            double h1female = 19 * square;
            double h2female = 24 * square;


            switch (input3)
            {
                case "male":
                    Console.WriteLine("bmi-value = {0:0.0}", bmi);
                    Console.WriteLine("Normal bmi-values(min . . max):   20. . 25");
                    Console.WriteLine("Healthy Weight Range:  {0:0.0} . . {1:0.0}",h1male ,h2male);
                    break;

                case "female":
                    Console.WriteLine("bmi-value = {0:0.0}", bmi);
                    Console.WriteLine("Normal bmi-values(min . . max):   19. . 24");
                    Console.WriteLine("Healthy Weight Range:  {0:0.0} . . {1:0.0}", h1female, h2female);
                    break;

            }
            Console.ReadKey();
        }
    }
}
