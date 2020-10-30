using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson2_TininA_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число, чье количество цифр необходимо посчитать");
            int Number = int.Parse(Console.ReadLine());
            int count = 0;
            while(Number != 0)
            {
                count++;
                Number = Number / 10;
            }

            Console.WriteLine($"Количество цифр введённого числа: {count}");
            Console.ReadLine();
        }
    }
}
