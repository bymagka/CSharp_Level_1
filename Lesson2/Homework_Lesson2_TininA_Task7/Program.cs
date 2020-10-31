/*TininA
 * 
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson2_TininA_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а и число b");
            Console.Write("Число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Число b: ");
            int b = int.Parse(Console.ReadLine());
            PrintNumber(a + 1, b);

            Console.WriteLine($"Сумма чисел от а до b равно {SumOfNumbers(a + 1, b, 0)}");
            Console.ReadLine();


        }

        public static void PrintNumber (int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(a);
                PrintNumber(a + 1, b);
            }
            
        }

        public static int SumOfNumbers(int a, int b,int sum)
        {
            if (a < b)
            {
                sum += a;
                return SumOfNumbers(a + 1, b, sum);
            }
            return sum;
        }
    }
}
