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
            double sum = 0;
            double average = 0;
           
            int[] arr = new int[20];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int rand = r.Next(0, 200);
                arr[i] = rand;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0} is {1}", i,arr[i]);
                sum = sum + arr[i];
                
            }
            average = sum / arr.Length;

            Console.WriteLine();

            Console.WriteLine("Average {0}", average);

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
               double difference =  arr[i] - average;
                if (difference <0)
                {
                    difference = difference * -1;
                }
                // Math.abs(arr[i] - average)
                Console.WriteLine("Difference Between Average and Element is {0}", difference);
            } 
            Console.ReadKey();
        }
    }  
}
