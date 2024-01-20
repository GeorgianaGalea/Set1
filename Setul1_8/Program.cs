using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se inverseaza numerele a si b");
            Console.WriteLine("Alegeti valoarea pentru a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti valoarea pentru b");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Dupa inversare a = {a} si b = {b}");
            
        }
    }
}
