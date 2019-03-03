using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            double Value = double.Parse(Console.ReadLine());
            double sum = 0; ;
            double TotalNumbers = 0;

            while (TotalNumbers >= 0 && TotalNumbers <= 9 && Value >= 0 && Value <= 100)
            {
                sum += Value;
                TotalNumbers++;

                Console.WriteLine("enter number");
                Value = double.Parse(Console.ReadLine());
            }
                Console.WriteLine($"The sum = {sum}");

        }


        
    }
}
