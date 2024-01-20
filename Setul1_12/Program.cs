using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da intervalul inchis [a, b]");
            Console.WriteLine("Alegeti valoare pentru a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti valoare pentru b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for(int i = a; i <= b; i++)
            {
                if (n % i == 0)
                    nr++;
            }
            Console.WriteLine($"In intervalul inchis [{a},{b}] se afla {nr} numere divizibile cu {n}");
        }
    }
}
