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
            Console.Write("Enter a text : ");
            string input1 = Console.ReadLine();
            SearchText(input1, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiCollons);

            Console.WriteLine("Result : {0} full stops, {1} commas, {2} semi collons", nrOfFullStops, nrOfCommas, nrOfSemiCollons);

            Console.ReadKey();
        }
        static void SearchText(string input1, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiCollons)
        {
             nrOfFullStops = 0;
             nrOfCommas = 0;
             nrOfSemiCollons = 0;

            foreach (var symbol in input1)
            {
                if (symbol == '.')
                {
                    nrOfFullStops++;
                }
                else if (symbol == ',')
                {
                    nrOfCommas++;
                }
                else if (symbol == ';')
                {
                    nrOfSemiCollons++;
                }
            }
            
        }
    }
}
