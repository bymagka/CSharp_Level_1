using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * TininA
 * 
 * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 * 
 * а) с использованием методов C#;
 * б) *разработав собственный алгоритм.
    Например:
    badc являются перестановкой abcd.
 * 
 */

namespace Homework_Lesson4_TininA_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите две строки!");
            Console.Write("Первая строка: ");
            string FirstString = Console.ReadLine();

            Console.Write("Вторая строка: ");
            string SecondString = Console.ReadLine();

            //метод, определяющий, является ли одна строка перестановкой другой. (Собственный алгоритм)
            Console.Write($"\nСтроки являются анаграмами (свой алгоритм): {IsAnagram(FirstString, SecondString)}");

            //метод, определяющий, является ли одна строка перестановкой другой. (методы шарпа)
            Console.Write($"\nСтроки являются анаграмами (методы шарпа): {IsAnagramCSharpMethods(FirstString, SecondString)}");
           

            Console.ReadLine();

        }

        //метод, определяющий, является ли одна строка перестановкой другой. (методы шарпа)
        private static bool IsAnagramCSharpMethods(string firstString, string secondString)
        {
          
            return secondString.CompareTo(new string(firstString.ToCharArray().Reverse().ToArray())) == 0;
        }

        //метод, определяющий, является ли одна строка перестановкой другой. (Собственный алгоритм)
        static bool IsAnagram(string FirstString, string SecondString)
        {
            if (FirstString.Length != SecondString.Length) return false;

            int StringLength = FirstString.Length;

            for (int i = 0; i < StringLength; i++)
            {
                if (FirstString[i] != SecondString[StringLength - i - 1]) return false;
            }

            return true;
        }
    }
}
