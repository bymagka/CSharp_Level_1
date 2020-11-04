/*
 * 
 * Тинин А
 * 
 * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson3_TininA_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Программа расчета дробей! Введите данные по дробям");

            InputData(out Fractions Fraction1,out Fractions Fraction2);

            Console.ReadLine();

        }

        public static void InputData(out Fractions Fraction1,out Fractions Fraction2)
        {
            Fraction1 = Fractions.InputFraction(1);
            Fraction2 = Fractions.InputFraction(2);

            Console.WriteLine($"Дробь номер 1: {Fraction1}");
            Console.WriteLine($"Дробь номер 2: {Fraction2}");
            Console.WriteLine($"\nПроизведение двух дробей:\n {Fraction1 * Fraction2}");
            Console.WriteLine($"\nЧастное двух дробей:\n {Fraction1 / Fraction2}");
            Console.WriteLine($"\nСумма двух дробей:\n {Fraction1 + Fraction2}");
            Console.WriteLine($"\nРазность двух дробей:\n {Fraction1 - Fraction2}");
        }

        
    }
}
