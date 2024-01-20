using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar pentru a se verifica daca este palindrom");
           int numar = int.Parse(Console.ReadLine());
           int n = numar;
           int inv = 0;
            while(n != 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            if (numar == inv)
                Console.WriteLine($"Numarul {numar} este palindrom");
            else
                Console.WriteLine($"Numarul {numar} nu este palindrom");
            
        }
    }
}