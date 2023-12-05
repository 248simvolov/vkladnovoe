using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            sdfsdf:
            Console.WriteLine("Введите сумму вклада");
            double symm = double.Parse(Console.ReadLine());
            if (symm < 100)
                symm *=1.05;
            if (100 <= symm && symm < 200)
                symm *= 1.07;
            if (symm >= 200)
                symm *= 1.1;
            Console.WriteLine($"Сумма вклада: {symm}");
            goto sdfsdf;
        }
    }
}
