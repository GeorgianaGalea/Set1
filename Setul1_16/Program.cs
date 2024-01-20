using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu primul număr: ");
            int nr1 = int.Parse(Console.ReadLine());

            Console.Write("Introdu al doilea număr: ");
            int nr2 = int.Parse(Console.ReadLine());

            Console.Write("Introdu al treilea număr: ");
            int nr3 = int.Parse(Console.ReadLine());

            Console.Write("Introdu al patrulea număr: ");
            int nr4 = int.Parse(Console.ReadLine());

            Console.Write("Introdu al cincilea număr: ");
            int nr5 = int.Parse(Console.ReadLine());

            if (nr1 > nr2)
            {
                int temp = nr1;
                nr1 = nr2;
                nr2 = temp;
            }

            if (nr2 > nr3)
            {
                int temp = nr2;
                nr2 = nr3;
                nr3 = temp;
            }

            if (nr3 > nr4)
            {
                int temp = nr3;
                nr3 = nr4;
                nr4 = temp;
            }

            if (nr4 > nr5)
            {
                int temp = nr4;
                nr4 = nr5;
                nr5 = temp;
            }

            if (nr1 > nr2)
            {
                int temp = nr1;
                nr1 = nr2;
                nr2 = temp;
            }

            if (nr2 > nr3)
            {
                int temp = nr2;
                nr2 = nr3;
                nr3 = temp;
            }

            if (nr1 > nr2)
            {
                int temp = nr1;
                nr1 = nr2;
                nr2 = temp;
            }

            Console.WriteLine($"Numerele in ordine crescatoare sunt: {nr1}, {nr2}, {nr3}, {nr4}, {nr5}");
        }
    }
}
