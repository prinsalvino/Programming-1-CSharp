using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[20];
            
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int rnd = r.Next(0, 150);
                arr[i] = rnd;

            }

            int smallest = arr[0];
            int numbercount = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    numbercount = 1;
                }
                else if (arr[i] == smallest)
                {
                    numbercount++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0} = {1}", i, arr[i]);
            }
           /*
            // ..
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == smallest)
                {
                    numbercount++;
                }
            }*/
            Console.WriteLine();
            Console.WriteLine("Smallest Number = {0}", smallest);
            Console.WriteLine("Number appears : {0}", numbercount);
            Console.ReadKey();
        }
    }
}
