using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se verifica daca n se divide cu k");
            Console.WriteLine("Introduceti  o valoare pentru n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru k");
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("n se divide cu k");
            else
                Console.WriteLine("n nu se divide cu k");
        }
    }
}
