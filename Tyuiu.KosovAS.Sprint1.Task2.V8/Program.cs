using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x; int y;

            Console.Title = "Спринт #1 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #1" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Базовые навыки работы в C#" + String.Concat(Enumerable.Repeat(" ", 40)) + "*");
            Console.WriteLine("* Задание #2" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант #8" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет периметр прямоугольного треугольника и печатает его на экране*");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));


            Console.WriteLine("Введите длину катета a");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину катета b");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Результат" + String.Concat(Enumerable.Repeat(" ", 65)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));



            Console.WriteLine($"Периметр прямоугольного треугольника равен {ds.CalculatePerimetr(x, y)}");
            Console.ReadKey();
        }
    }
}
