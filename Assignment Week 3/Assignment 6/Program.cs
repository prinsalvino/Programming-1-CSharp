using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Score : ");
            string input = Console.ReadLine();

            int score = int.Parse(input);

            if (score >= 90 && score<= 100)
            {
                Console.WriteLine("Grade = A");
                Console.WriteLine("Course Passed");
            }
            else if (score < 90 && score >= 80) 
            {
                Console.WriteLine("Grade = B");
                Console.WriteLine("Course Passed");
            }
            else if (score < 80 && score >= 70)
            {
                Console.WriteLine("Grade = C");
                Console.WriteLine("Course Passed");
            }
            else if (score<70 && score>=60)
            {
                Console.WriteLine("Grade = D");
                Console.WriteLine("Course Not Passed");
            }
            else if (score <60)
            {
                Console.WriteLine("Grade = F");
                Console.WriteLine("Course Not Passed");
            }
            else
            {
                Console.WriteLine("Input Error");
            }

            Console.ReadLine();

        }
    }
}
