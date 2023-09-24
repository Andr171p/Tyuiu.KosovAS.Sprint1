using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint1.Task4.V21.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x; double y;


            Console.Title = "Спринт #1 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #1" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Class Math" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine("* Задание #4" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант #21" + String.Concat(Enumerable.Repeat(" ", 61)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет значение по формуле и печатает его на экране                  *");
            Console.WriteLine("* |(1 + x)^2 - y|" + String.Concat(Enumerable.Repeat(" ", 57)) + "*");
            Console.WriteLine("* -------------" + String.Concat(Enumerable.Repeat(" ", 59)) + "*");
            Console.WriteLine("*    (x + y)" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("* Введите число x" + String.Concat(Enumerable.Repeat(" ", 57)) + "*");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* Введите число y" + String.Concat(Enumerable.Repeat(" ", 57)) + "*");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Результат" + String.Concat(Enumerable.Repeat(" ", 65)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));


            Console.WriteLine("* Значение выражения равно:");
            Console.WriteLine($"* |(1 + {x})^2 - {y}|");
            Console.WriteLine($"* --------------     == {ds.Calculate(x, y)}");
            Console.WriteLine($"*  ({x} + {y})");
            
            
            
            Console.ReadKey();

        }
    }
}
