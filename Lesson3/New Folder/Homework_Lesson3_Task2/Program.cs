/*
 * Тинин А
 * 
 * а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета суммы нечетных положительных чисел. Начинайте вводить числа! Ввод 0 - закончить");
            int sum = 0;

            do
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Вы ввели число в неправильном формате. Должно быть целое число!");
                    continue;
                }
                else
                {
                    if (number == 0) break;
                    if (number > 0 && number % 2 != 0) sum += number;
                }
            } while (true);

            Console.WriteLine($"Программа расчета закончена! Сумма нечетных положительных чисел равна {sum}");
            Console.ReadLine();

        }
    }
}
