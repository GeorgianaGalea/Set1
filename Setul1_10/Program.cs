using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numarul n pentru a se verifica daca este prim");
            int n = int.Parse(Console.ReadLine());

            if(n < 2)
                 Console.WriteLine("n nu este prim");

            int nr = 0;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {   
                if (n % i == 0)
                    nr++;
                if (nr != 0)
                    break;
            }
            if (nr == 0)
                Console.WriteLine("n este prim");
            else
                Console.WriteLine("n nu este prim");

        }
    }
}
