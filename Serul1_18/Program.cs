using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serul1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu un numar pentru a fi descompus in factori primi: ");
            int n = int.Parse(Console.ReadLine());
            int nr = n;
            Console.Write($"{n} = ");
            for (int i = 2; i<=nr/2; i++)
            {
                int putere = 0;
                while(nr % i == 0)
                {
                    putere++;
                    nr /= i;
                }
                if(putere > 0)
                {
                    Console.Write($"{i}*{putere}");
                    if(nr > 1)
                        Console.Write(" x ");
                }
            }
        }
    }
}
