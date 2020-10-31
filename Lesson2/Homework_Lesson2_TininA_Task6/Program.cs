/*
 * TininA
 * *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson2_TininA_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запускаем расчет \"правильных\" чисел в диапазоне от 1 до 1 000 000! Это займет какое то время");

            DateTime StartDate = DateTime.Now;
       
            int count = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (i % SumOfDigits(i) == 0) count++;
            }
            Console.WriteLine($"Количество \"правильных\" чисел равно {count}");
            Console.WriteLine($"Выполнение расчета заняло {(DateTime.Now - StartDate).TotalSeconds} секунд");
            Console.ReadLine();
        }

    
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }
    }

}
