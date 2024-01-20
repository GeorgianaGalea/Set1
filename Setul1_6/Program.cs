using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aetul1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se verifica daca 3 numere a, b si c pot fi laturile unui triunghi. Alegeti valorile pt cele 3 variabile");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a + b < c) && (a + c < b) && (b + c < a))
                Console.WriteLine("Cele 3 numere pot fi laturile unui triunghi");
            else
                Console.WriteLine("Cele 3 numere nu pot fi laturile unui triunghi");
        }
    }
}
