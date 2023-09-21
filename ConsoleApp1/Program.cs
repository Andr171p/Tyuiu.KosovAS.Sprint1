using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = a - 3;
            int c = a + 1;
            a = b + a - c;
            c = c - (b + a);
            b = b + a - 1;
            int x = a + b + c;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
