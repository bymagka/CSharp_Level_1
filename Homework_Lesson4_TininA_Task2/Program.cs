/*
 * 
 * Тинин А
 * Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_Lesson4_TininA_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] NewArray = new int[1];
            Console.WriteLine("Программа считывания массива и подсчета пар начата!");
  
            try
            {
                StreamReader sr = new StreamReader("..\\..\\Array.txt");

                while (!sr.EndOfStream)
                {
                    string Value = sr.ReadLine();
                    if(int.TryParse(Value, out int NewMember))
                    {
                      
                        NewArray[count] = NewMember;
                        count++;
                        Array.Resize(ref NewArray, count + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Не удалось прочитать значение {Value} - не является целым числом");
                    }
                }
                sr.Close();
            } catch (Exception ex)
            {
                Console.WriteLine($"Проблемы с обнаружением файла массива. Проверьте наличие файла Array.txt в каталоге проекта. {ex.Message}");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Массив выведен ниже");

            foreach (int item in NewArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n Количество стоящих подряд пар чисел, в которых только одно из чисел делится на 3 : {StaticClass.CalculateArray(NewArray)}");
            Console.ReadLine();
        }
    }
}
