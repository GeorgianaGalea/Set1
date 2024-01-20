using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere pentru a fi sortate crescator");
            int nr1 = int.Parse(Console.ReadLine());
            int nr2 = int.Parse(Console.ReadLine());
            int nr3 = int.Parse(Console.ReadLine());

            if (nr1 <= nr2 && nr1 <= nr3)
            {
                Console.Write($"{nr1}, ");
                if (nr2 <= nr3)
                    Console.Write($"{nr2},  {nr3}");
                else Console.Write($"{nr3},  {nr2}");
            }
            else
            {
                if (nr2 <= nr1 && nr2 <= nr3)
                {
                    Console.Write($"{nr2}, ");
                    if (nr1 <= nr3)
                        Console.Write(($"{nr1},  {nr3}"));
                    else Console.Write(($"{nr3},  {nr1}"));
                }
                else
                {

                    if (nr3 <= nr1 && nr3 <= nr2)
                    {
                        Console.Write($"{nr3}, ");
                        if (nr1 <= nr2)
                            Console.Write(($"{nr1},  {nr2}"));
                        else Console.Write(($"{nr2},  {nr1}"));
                    }
                }
            }
            
        }
    }
}
