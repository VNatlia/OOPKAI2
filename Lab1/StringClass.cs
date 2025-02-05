
using System;

namespace StringApp
{
    public class StringClass
    {
        private string value; // Значення рядка

        // Конструктор
        public StringClass(string val)
        {
            value = val;
        }

        // Метод для отримання довжини рядка
        public int GetLength()
        {
            return value.Length;
        }

        // Метод для обернення рядка
        public string ReverseString()
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Метод для отримання рядка
        public string GetValue()
        {
            return value;
        }
    }
}
