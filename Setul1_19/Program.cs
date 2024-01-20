using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar pentru a se verifica daca este format doar din 2 cifre ce se pot repeta");
            int n= int.Parse(Console.ReadLine());
            int cifra1 = n % 10;
            int cifra2 = 0;

            while (cifra2 == 0)
            {
                n /= 10;
                if (n % 10 != cifra1)
                    cifra2 = n % 10;
            };
            bool a = true;
            while (n != 0)
            {
                if (n % 10 != cifra2 && n % 10 != cifra1)
                {
                    a = false;
                    break;
                }
                n /= 10;
            }
            if (a == true)
                Console.WriteLine("nr este format din doar 2 cifre");
            else
                Console.WriteLine("nr nu este format doar din 2 cifre");
        }
    }
}
