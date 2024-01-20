using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu o valoare pentru numarul n");
            int n =int.Parse(Console.ReadLine());
            for (int i = 0; i < n / 2; i++)
                if(n % i == 0)
                    Console.WriteLine(i);
        }
    }
}
