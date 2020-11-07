/*
 * Тинин А
 * 
 * *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
**в) Обработать возможные исключительные ситуации при работе с файлами.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDimensionalArrayLib;

namespace Homework_Lesson4_TininA_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа формирования массива чисел, считывания, и записи информации в файл");
            Console.WriteLine("Введите имя файла, где расположен массив. Первые две строчки отвечают за размерность массива, последующие - перечень элементов через пробел");
            string filenameInput = Console.ReadLine();

            Console.WriteLine("Введите имя файла, куда будут распечатаны данные по массивам.");
            string filenameOutput = Console.ReadLine();

            Console.WriteLine("Введите длину первого измерения массива для расчета суммы:");
            int FirstRankLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго измерения массива для расчета суммы:");
            int SecondRankLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите границу первого измерения массива для расчета суммы:");
            int firstRankBorder = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите границу второго измерения массива для расчета суммы:");
            int secondRankBorder = int.Parse(Console.ReadLine());

            Console.WriteLine("Данные по массиву случайных чисел и по данным из файла будут выведены в файл. При возникновении ошибки она будет выведена");
            try
            {
                //Обработать возможные исключительные ситуации при работе с файлами.
                TwoDimensionalArray RandomArray = new TwoDimensionalArray(FirstRankLength, SecondRankLength);
                RandomArray.PrintToFile(filenameOutput,firstRankBorder,secondRankBorder);
                Console.WriteLine("Массив случайных чисел выведен!");


                TwoDimensionalArray FileArray = new TwoDimensionalArray(filenameInput);
                FileArray.PrintToFile(filenameOutput, firstRankBorder, secondRankBorder);
                Console.WriteLine("Массив из файла выведен!");
            }
            catch (Exception ex)
            {
                //**в) Обработать возможные исключительные ситуации при работе с файлами.
                Console.WriteLine($"Ошибка! {ex.Message}");
            }
            Console.WriteLine("Работа завершена");
            Console.ReadLine();
        }
    }
}
