using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tinin A
 * С помощью рефлексии выведите все свойства структуры DateTime
 */
namespace Homework_Lesson8_TininA_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var properties = typeof(DateTime).GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
