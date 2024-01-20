using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti valoarea pt numarul n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Alegeti pozitia cifrei ce va fi extrasa");
            int k = int.Parse(Console.ReadLine());
            int a = (int)(n / Math.Pow(10, (k - 1)) % 10);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
