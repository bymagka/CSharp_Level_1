/*
 * Тинин А
 * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson4_TininA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа инициализации массива и подсчета пар начата!");

            Random rnd = new Random();
            int[] MyArray = new int[20];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = rnd.Next(-10_000, 10_000);
            }

            Console.WriteLine("Массив выведен ниже");
           
            foreach(int item in MyArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n Количество стоящих подряд пар чисел, в которых только одно из чисел делится на 3 ");

            int count = 0;
            for (int i = 1; i < MyArray.GetLength(0); i++)
            {
                if ((MyArray[i] % 3 == 0 && MyArray[i - 1] % 3 != 0) || (MyArray[i - 1] % 3 == 0 && MyArray[i] % 3 != 0)) count++;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
