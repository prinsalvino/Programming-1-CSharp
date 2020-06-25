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
            
            int[] arr = new int[20];
            int numbers = 0;
            int input = 0;

            #region error 
            /*bool zero = false;
           
            for (int i = 0; i < arr.Length; i++)             
            {
                while (!zero)
                {                  
                    Console.Write("Enter a number (0=stop) :");
                    number = int.Parse(Console.ReadLine());


                    if (i < arr.Length)
                    {
                        arr[i] = number;
                    }


                    if (number == 0)
                    {
                        zero = true;
                    }

                }
            }

            Console.Write("Enter Search Value : ");
            string input2 = Console.ReadLine();
            int search = int.Parse(input2);

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (search == arr[i])
                {
                    count++;
                }
                
            }
            Console.Write("Number of occurance of search value {0} : {1}",search, count);
            Console.ReadKey();*/
            #endregion

            do
            {
                Console.Write("Enter a number (0=stop) : ");
                input = int.Parse(Console.ReadLine());

                if (numbers < arr.Length)
                {
                    arr[numbers] = input;
                }
                numbers++;
            } while (input != 0);

            Console.WriteLine();

            Console.Write("Enter search value : ");
            int search = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (search == arr[i])
                {
                    count++;
                }
            }
            Console.WriteLine();

            Console.Write("Number occurances of search value {0} : {1}", search, count);
            Console.ReadKey();
        }
    }
}
