using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint1.Task3.V2.Lib;

namespace Tyuiu.KosovAS.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double priceNote; int amountNote; double pricePencil; int amountPencil;

            Console.Title = "Спринт #1 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #1" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Операторы составного присваивания" + String.Concat(Enumerable.Repeat(" ", 33)) + "*");
            Console.WriteLine("* Задание #3" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант #2" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет общую стоимость покупки и печататет её на экране              *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите цену тетради (рубли):");
            priceNote = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количевство тетрадей:");
            amountNote = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите цену карандаша (рубли):");
            pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количевство карандашей:");
            amountPencil = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("Результат" + String.Concat(Enumerable.Repeat(" ", 65)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Общая стоимость покупки состовляет {ds.PurchaseAmount(priceNote, amountNote, pricePencil, amountPencil)} рублей");
            
            Console.ReadKey();
        }
    }
}
