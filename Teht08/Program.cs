using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            int luku3;
            Console.Write("Anna ensimmäinen luku > ");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);

            Console.Write("Anna toinen luku > ");
            line = Console.ReadLine();
            luku2 = int.Parse(line);

            Console.Write("Anna kolmas luku > ");
            line = Console.ReadLine();
            luku3 = int.Parse(line);

            if (luku1 > luku2 && luku1 > luku3) Console.WriteLine("\nSuurin luku: " + luku1);
            else if (luku2 > luku1 && luku2 > luku3) Console.WriteLine("\nSuurin luku: " + luku2);
            else if (luku3 > luku1 && luku3 > luku2) Console.WriteLine("\nSuurin luku: " + luku3);
        }
    }
}
