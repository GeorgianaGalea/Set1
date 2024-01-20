using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("se aleg 2 valori pentru variabilele a si b ce vor fi inversate.");
            Console.WriteLine("alegeti valoarea pentru a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("alegeti valoarea pentru b");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Dupa inversare a = {a} si b = {b}");
            Console.ReadLine();
        }
    }
}
