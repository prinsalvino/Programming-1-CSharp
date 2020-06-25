using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1
{
    class Program
    {
        const float VAT = 0.21f;
        static void Main(string[] args)
        {
            Console.Write("Enter a price : ");
            float input = float.Parse(Console.ReadLine());
            float tax = input * VAT;

            float total = CalcFloat(input,tax);

            Console.Write("Price : {0}, ", input);
            Console.Write("Vat : {0:0.00}, ",tax);
            Console.Write("Total : {0:0.00}", total);

            Console.ReadKey();
        }

        static float CalcFloat(float price,float tax)
        {
            
            float total1 = price + tax;
            return total1;
        }
    }
}
