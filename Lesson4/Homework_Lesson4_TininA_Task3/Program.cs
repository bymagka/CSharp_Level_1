/*
 * Тинин А.
 * 
 * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
    б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArray;

namespace Homework_Lesson4_TininA_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecialArray NewArray = InputData();
            PrintData(NewArray);
            Console.ReadLine();

        }

        private static void PrintData(SpecialArray newArray)
        {
            Console.WriteLine("Созданный массив:");
            newArray.Print();

            //Создать свойство Sum, которое возвращает сумму элементов массива
            Console.WriteLine($"\nСумма элементов массива: {newArray.Sum}");

            // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
            Console.WriteLine("\nМассив, созданный в результате метода Inverse:");
            int[] InversedArray = newArray.Inverse();
            foreach(int item in InversedArray)
            {
                Console.Write($"{item} ");
            }

            //метод Multi, умножающий каждый элемент массива на определённое число
            Console.Write("\n\nВведите число, на которое надо умножить массив:");
            if (!int.TryParse(Console.ReadLine(), out int Multiplier))
            {
                Console.WriteLine("\nВы ввели не целое число, массив не будет изменен");
            }
            else
            {
                newArray.Multi(Multiplier);
                Console.WriteLine("\nИзмененный массив:");
                newArray.Print();
            }

            //свойство MaxCount, возвращающее количество максимальных элементов.
            Console.WriteLine($"\nКоличество максимальных элементов: {newArray.MaxCount}");

            //Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
            Dictionary<int, int> OccurencesDict = new Dictionary<int, int>();

            for(int i = 0; i < newArray.Length; i++)
            {
                if (OccurencesDict.ContainsKey(newArray[i]))
                {
                    OccurencesDict[newArray[i]]++;
                }
                else
                {
                    OccurencesDict.Add(newArray[i], 1);
                }
            }

            Console.WriteLine("\nЧастота вхождений каждого элемента массива представлена ниже:");
            foreach(int key in OccurencesDict.Keys)
            {
                Console.WriteLine($"Значение массива: {key}. Количество вхождений: {OccurencesDict[key]}");
            }
        }

        private static SpecialArray InputData()
        {
            
            Console.WriteLine("Запущена программа работы с массивом");

            Console.Write("Введите длину массива: ");
            if (!int.TryParse(Console.ReadLine(), out int Length))
            {
                Console.WriteLine("\nВы неправильно ввели число! Начните ввод данных заново");
                return InputData();
            }

            Console.Write("Введите начальное значение элемента массива: ");
            if (!int.TryParse(Console.ReadLine(),out int StartValue))
            {
                Console.WriteLine("\nВы неправильно ввели число! Начните ввод данных заново");
                return InputData();
            }

            Console.Write("Введите шаг заполнения массива: ");
            if (!int.TryParse(Console.ReadLine(), out int Step))
            {
                Console.WriteLine("\nВы неправильно ввели число! Начните ввод данных заново");
                return InputData();
            }

            return new SpecialArray(Length, StartValue, Step);
        }
    }
}
