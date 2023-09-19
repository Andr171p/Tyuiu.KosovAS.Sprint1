using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint1.Task0.V3.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #1" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Базовые навыки работы в C#" + String.Concat(Enumerable.Repeat(" ", 40)) + "*");
            Console.WriteLine("* Задание #0" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант #3" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая вычисляет выражение (6 / 2 * 3) / 9          *");
            Console.WriteLine("* и печатает результат на экране." + String.Concat(Enumerable.Repeat(" ", 41)) + "*");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* (6 / 2 * 3) / 9" + String.Concat(Enumerable.Repeat(" ", 57)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* РЕЗУЛЬТАТ" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
