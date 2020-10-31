
/* тинин А
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson2_TininA_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для расчета индекса массы необходимо ввести рост и вес!");
            Console.Write("Ваш вес в килограммах: ");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваш рост в метрах: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            double minGoodWeight = 19 * Math.Pow(Height, 2);
            double maxGoodWeight = 25 * Math.Pow(Height, 2);

            Console.Write($"Ваш индекс массы тела равен {Weight / Math.Pow(Height, 2)}");

            if (minGoodWeight > Weight)
            {
                Console.WriteLine($"\nВы очень худы! Для нормы следует набрать {minGoodWeight - Weight} кг");
            }
            else if (maxGoodWeight < Weight)
            {
                Console.WriteLine($"\nВы очень толсты! Для нормы следует сбросить {Weight - maxGoodWeight} кг");
            }
            else Console.WriteLine("\nВаш индекс массы тела в норме!");
            Console.ReadLine();



        }
    }
}
