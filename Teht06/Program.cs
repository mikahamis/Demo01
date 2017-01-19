using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus;
            double hinta;
            double matka;
            double kustannus;
            double bensatotal;
            Console.WriteLine("Anna matka > ");
            string line = Console.ReadLine();
            matka = double.Parse(line);
            hinta = 1.595;
            kulutus = 7.02 / 100;
            bensatotal = matka * kulutus;
            kustannus = bensatotal * hinta;
            Console.WriteLine("Bensaa kuluu " + String.Format("{0:.##}", bensatotal) + " litraa, " + "kustannus " + String.Format("{0:.##}", kustannus ) + " euroa.");
            
        }
    }
}
