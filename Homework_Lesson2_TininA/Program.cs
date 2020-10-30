using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Написать метод, возвращающий минимальное из трёх чисел.
namespace Homework_Lesson2_TininA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            Console.Write("Первое число: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Второе число: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Третье число: ");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());

            double max = FirstNumber;

            if (SecondNumber > max) max = SecondNumber;
            if (ThirdNumber > max) max = ThirdNumber;

            Console.WriteLine($"Максимальное число: {max}");
            Console.ReadLine();
        }
    }
}
