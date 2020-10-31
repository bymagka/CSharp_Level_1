using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. TininA
namespace Homework_Lesson2_Task3_TininA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начнем программу подсчета суммы нечетных чисел! Начните ввод чисел, ввод 0 это остановка ввода");
            int sum = 0;
            int Number = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number == 0) break;
                if (Number > 0 && Number % 2 != 0) sum += Number;
            }
            Console.WriteLine($"Сумма всех нечётных положительных чисел равна {sum}");
            Console.ReadLine();
        }
    }
}
