using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar");
            int nr2 = int.Parse(Console.ReadLine());

            int cmmd = cmmdc(nr1, nr2);
            int cmmc = cmmmc(nr1, nr2, cmmd);
            Console.WriteLine($"cel mai mic divizor comun al numerelor {nr1} , {nr2} este {cmmd}");
            Console.WriteLine($"cel mai mare multiplu comun al numerelor {nr1} , {nr2} este {cmmc}");
        }

        static int cmmdc(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int cmmmc(int a, int b, int cmmd)
        {
            return a * b / cmmd;
        }
    }
        
}
