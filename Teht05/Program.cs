using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekuntti;
            int minuutti;
            int tunti;
            int luku;
            Console.WriteLine("Anna sekunnit");
            string line = Console.ReadLine();
            luku = int.Parse(line);
            tunti = luku / 3600;
            minuutti = luku / 60 -tunti*60;
            sekuntti = luku % 60;
            
            
            
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunti + " tuntia " + minuutti + " minuuttia " + sekuntti + " sekuntia ");

        }
    }
}
