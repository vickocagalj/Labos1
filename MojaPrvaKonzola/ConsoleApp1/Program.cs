using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MojaPrvaKonzola
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi djeljivi s 3:");
            for (int i = 1; i < 100; ++i)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("GOTOVO! Pritisni bilo koju tipku.");
            Console.ReadKey();
        }
    }
}
