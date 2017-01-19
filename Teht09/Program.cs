using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku > ");
            string line = Console.ReadLine();
            luku = int.Parse(line);
            switch (luku)
            {
                case 0: Console.WriteLine(luku); break;
                case 1: luku = luku + int.Parse(line); break;
            }
        }
    }
}
