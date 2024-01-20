using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da ecuatia ax^2 + bx + c = 0");
            Console.WriteLine("Alegeti valoarea pentru a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti valoarea pentru b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti valoarea pentru c");
            int c = int.Parse(Console.ReadLine());
            int delta = (int)Math.Pow(b, 2) - (4 * a * c);

            if (delta == 0)
            {
                int x = -b / 2 * a;
                Console.WriteLine($"Rezultatul ecuatiei {a}x^2 + {b}x + {c} = 0 este x1 = x2 = {x}");
            }
            if (delta > 0)
            {
                int x1 = (int)((-b + Math.Sqrt(delta)) / (2 * a));
                int x2 = (int)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine($"Rezultatul ecuatiei {a}x^2 + {b}x + {c} = 0 este x1 = {x1} , x2= {x2}");
            }
            if (delta < 0)
            {
                var ComplexNr = new Complex(0, 1);


                Complex x01 = (-b + Complex.Sqrt(ComplexNr)) / (2 * a);
                Complex x02 = (-b - Complex.Sqrt(ComplexNr)) / (2 * a);
                Console.WriteLine($"Rezultatul ecuatiei {a}x^2 + {b}x + {c} = 0 este x1 = {x01} , x2= {x02}");

            }
        }
    }
}
