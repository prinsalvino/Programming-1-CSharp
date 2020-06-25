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
            double sum = 0;
            double average = 0;


            Console.Write("Enter Course Name :");
            string input1 = Console.ReadLine();

            Console.Write("Enter Number of Students :");
            string input2 = Console.ReadLine();
            int students = int.Parse(input2);

            Console.WriteLine();

            double[] grades = new double[students];
            string[] arrname = new string [students];
            double highest = grades[students - 1];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter Name of Students :");
                arrname[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter Grade of {0} :", arrname[i]);
                grades[i] = double.Parse(Console.ReadLine());
                // ...
            }

            for (int i = 0; i < grades.Length; i++)
            {
                sum = sum + grades[i];
            }

            
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]>highest)
                {
                    highest = grades[i];
                }
            }

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > highest)
                {
                    highest = grades[i];
                }
            }
            Console.WriteLine();

            for (int i = 0; i < grades.Length; i++)
            {
                if (highest == grades[i])
                {
                    Console.WriteLine("Student {0} have the highest number : {1}", arrname[i], highest);
                }
            }
            average = sum / grades.Length;
            Console.WriteLine("Average Grade : {0:0.00}", average);


            Console.WriteLine();

            for (int i = 0; i < arrname.Length; i++)
            {
                Console.WriteLine("Grade for student {0}(Course {1}) is : {2}", arrname[i], input1, grades[i]);
            }
            Console.ReadKey();
        }
    }
}
