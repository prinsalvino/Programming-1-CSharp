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
            Console.Write("Enter Price :");

            string input = Console.ReadLine();
            Console.WriteLine("The Price is {0}",input);

            int price = int.Parse(input);

            int vat = price * 21 / 100;

            Console.WriteLine("The VAT is {0}", vat);

            int total = vat + price;

            // ...
            Console.Write("The total is {0}", total);
            

            Console.ReadKey();
        }
    }
}
