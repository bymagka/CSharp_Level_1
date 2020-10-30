
//C# уровень 1, 1 урок, Тинин А.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson1_TininA
{
    class Program
    {
        static void Main(string[] args)
        {   /*
             * 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
                    а) используя  склеивание;
	                б) используя форматированный вывод;
	                в) используя вывод со знаком $.
             * 
             */
            Questionnaire();

            /*
                2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
             * 
             */
            IndexWeightCount();

            /*  3.
                а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
                б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
             */
            Console.WriteLine("\nДля расчета расстояния между двумя точками введите координаты точки!");
            Console.Write("\nВведите координату первой точки x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату первой точки y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("\nВведите координату второй точки x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату второй точки y2: ");
            int y2 = int.Parse(Console.ReadLine());

            double Distance = CalculateDistance((double)x1, (double)y1, (double)x2, (double)y2);
            Console.Write($"Дистанция между точками составляет: {Distance}");
            Console.ReadLine();

            /*
                4.Написать программу обмена значениями двух переменных:
                а) с использованием третьей переменной;
	            б) *без использования третьей переменной.
            */
            Console.WriteLine("\nДля обмена значениями введите сами значения!");
            Console.Write("Значение а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nЗначение b: ");
            int b = int.Parse(Console.ReadLine());
            
            ChangeVariablesWithThirdVariable(ref a, ref b);
            Console.WriteLine($"\nПосле обмена с третьей переменной значение а = {a}; b = {b}") ;

            ChangeVariablesWithoutThirdVariable(ref a, ref b);
            Console.WriteLine($"После обмена без третьей переменной значение а = {a}; b = {b}");
            Console.ReadLine();


            /*  5.
                а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
                б) *Сделать задание, только вывод организовать в центре экрана.
                в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
            */

            Console.Write("\nВведите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваше фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();

            GeekBrains.Print($"Ваш город - {city}; Ваше имя - {name}; Ваша фамилия - {surname}", Console.WindowWidth / 2, Console.WindowHeight / 2);
            GeekBrains.Pause();

        }

        private static void ChangeVariablesWithoutThirdVariable(ref int a, ref int b)
        {
            a = b - a;
            b = b - a;
            a = b + a;
        }

        private static void ChangeVariablesWithThirdVariable(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private static void IndexWeightCount()
        {
            Console.WriteLine("Для расчета индекса массы тела необходимо ввести дополнительные данные!");
            Console.Write("Введите вес в килограммах: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост в метрах: ");
            float height = Convert.ToSingle(Console.ReadLine());

            float Index = Convert.ToSingle(weight) / (height * height);

            Console.Write("Ваш индекс массы тела составляет: " + Index.ToString());
            Console.ReadLine();
        }

        private static void Questionnaire()
        {
            Console.WriteLine("Добрый день!");
            
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваше фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите ваше возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш вес: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:N2}","Ваше имя: " + name +", Ваша фамилия: " + surname + $", Ваш возраст: {age}, Ваш рост: {height}, Ваш вес: {weight}");
            Console.ReadLine();
          

        }
    }

    /*  6.
    *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
    */
    class GeekBrains
    {
        public static void Print(string ms,int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ms);
        }

        public static void Pause()
        {
            Console.ReadLine();
        }
    }
}
