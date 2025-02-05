using StringApp;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace srting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            string userInput = Console.ReadLine();

            // Створення об'єкта класу
            StringClass myString = new StringClass (userInput);

            // Виведення початкового рядка
            Console.WriteLine("Рядок: " + myString.GetValue());

            // Виведення довжини рядка
            Console.WriteLine("Довжина рядка: " + myString.GetLength());

            // Виведення оберненого рядка
            Console.WriteLine("Обернений рядок: " + myString.ReverseString());
        }
    }
}

