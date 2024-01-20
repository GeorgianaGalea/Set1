using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti un an pentru a verifica daca este bisect");
            int n = int.Parse(Console.ReadLine());
            if ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
                Console.WriteLine($" Anul {n} este an bisect");
            else
                Console.WriteLine($" Anul {n} nu este an bisect");
        }
    }
}
