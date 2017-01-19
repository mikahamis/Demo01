using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            Console.WriteLine("Give the first number ");
            string line = Console.ReadLine();
            number1 = int.Parse(line);
            Console.WriteLine("Give the second number ");
            line = Console.ReadLine();
            number2 = int.Parse(line);
            Console.WriteLine("Give the third number ");
            line = Console.ReadLine();
            number3 = int.Parse(line);
            int sum;
            sum = number1 + number2 + number3;
            int avg;
            avg = sum / 3;
            Console.WriteLine("Sum of input numbers: " + sum);
            Console.WriteLine("Average of input numbers: " + avg);
            Console.ReadLine();
        }
        
    }
}
