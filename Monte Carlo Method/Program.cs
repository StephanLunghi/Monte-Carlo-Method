using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            Random random = new Random();

            coordinates[] coordinates = new coordinates[number];

            int counter = 0;

            for (int i = 0; i < number; i++)
            {
                coordinates[i] = new coordinates(random);

                if (coordinates[i].Hypot() <= 1)
                {
                    ++counter;
                }
            }

            double count = Convert.ToDouble(counter);
            double iterations = Convert.ToDouble(number);

            double estimation = (count / iterations) * 4;

            Console.WriteLine($"amount of overlaps {count}");
            Console.WriteLine($" PI amount {Math.PI}");
            Console.WriteLine($" Estimation {estimation}");
            Console.WriteLine($" Margin of error {Math.PI - estimation}");

            
        }
    }
}
