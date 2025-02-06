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

            StringClass myString = new StringClass(Input);

            Console.WriteLine("Введений рядок: " + myString.GetValue());

            Console.WriteLine("Довжина рядка: " + myString.GetLength());

            Console.WriteLine("Обернений рядок: " + myString.ReverseString());
        }
    }
}



