using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0;

            Console.WriteLine("Enter data");

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Console.ReadLine());

            d = Convert.ToInt32(Console.ReadLine());

            int x = a - b;

            int y = c - d;

            int z = x + y;

            Console.WriteLine("Result = {0}", y);





            Console.ReadKey();
        }
    }
}
