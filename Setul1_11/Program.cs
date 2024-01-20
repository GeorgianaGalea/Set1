using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("se afiseaza cifrele numarului n in ordine inversa");
            while(n != 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
        }
    }
}
