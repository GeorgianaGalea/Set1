using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema 1 setul 1
            Console.WriteLine( "Se da ecuatia: ax + b " );
            Console.WriteLine( "Alegeti o valoare pentru a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti o valoare pentru b");
            int b = int.Parse(Console.ReadLine());
            int x = 0;
            Console.WriteLine($"Se da ecuatia de gradul 1: {a}x + {b} = 0. Sa se calculeze x");
            x = -b / a;
            Console.WriteLine($"x = {x}");
        }
    }
}
