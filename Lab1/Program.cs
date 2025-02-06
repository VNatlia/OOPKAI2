using StringApp;
using System;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            string Input = Console.ReadLine();

            // Створення об'єкта класу
            StringClass myString = new StringClass (Input);

            // Виведення початкового рядка
            Console.WriteLine("Введений рядок: " + myString.GetValue());

            // Виведення довжини рядка
            Console.WriteLine("Довжина рядка: " + myString.GetLength());

            // Виведення оберненого рядка
            Console.WriteLine("Обернений рядок: " + myString.ReverseString());
        }
    }
}

