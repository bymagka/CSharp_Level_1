using System;
using System.IO;
using System.Collections.Generic;
/*
 * Tinin A
 * 
 * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
    в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
    возвращает минимум через параметр.
 */
namespace Homework_Lesson6_TininA_Task2
{
    class Program
    {
        public delegate double Function(double x);

        //квадратный корень
        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        //парабола
        public static double Square(double x)
        {
            return x*x;
        }

        //гипербола
        public static double Hyperbole(double x)
        {
            return 1 / x;
        }



        public static void SaveFunc(string fileName, double a, double b, double h, Function Delegate)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Delegate(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            List<double> ValuesList = new List<double>();

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                ValuesList.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return ValuesList.ToArray();
        }
        static void Main(string[] args)
        {
            //инициализируем массив делегатов
            List<Function> FunctionList = FunctionInitialization();

            Console.WriteLine("Программа расчета минимума приветствует вас!");
           
            //ввод всех данных 
            InputData(FunctionList,out int number, out double a, out double b, out double h);

            //рассчитываем функцию на отрезке и сохраняем в файл
            SaveFunc("data.bin", a, b, h, FunctionList[number - 1]);

            //читаем файл в массив , вычисляя паралельно минимум
            double[] ValuesArray = Load("data.bin", out double min);

            //выводим минимум и все значения функции на отрезке
            Console.WriteLine($"Min = {min}");
            Console.WriteLine("Все рассчитанные значения:");

            foreach(double item in ValuesArray)
            {
                Console.Write("{0:f2} ",item);
            }

            Console.ReadKey();
        }

        //метод ввода данных
        private static void InputData(List<Function> FunctionList, out int number, out double a, out double b, out double h)
        {
            Console.WriteLine("Выберите интересующую вас функцию: ");

            //предоставляем возможность выбора из доступных функций
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}. {FunctionList[i - 1].Method.Name}");
            }
            //ввод номера функции
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 1 && number > 3)
                    {
                        Console.WriteLine("Необходимо ввести число от 1 до 3! Попробуйте еще раз");
                    }
                    else break;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести число от 1 до 3! Попробуйте еще раз");
                }
            } while (true);


            //ввод начала отрезка
            do
            {
                Console.WriteLine("Выберите начало отрезка, на котором считать минимум: ");
                if (double.TryParse(Console.ReadLine(), out a)) break;
                else Console.WriteLine("Неправильно введено начало отрезка! Попробуйте еще раз");
            } while (true);

            //ввод конца отрезка
            do
            {
                Console.WriteLine("Выберите конец отрезка, на котором считать минимум: ");
                if (double.TryParse(Console.ReadLine(), out b)) break;
                else Console.WriteLine("Неправильно введен конец отрезка! Попробуйте еще раз");
            } while (true);

            //ввод шага
            do
            {
                Console.WriteLine("Выберите шаг расчета функции: ");
                if (double.TryParse(Console.ReadLine(), out h)) break;
                else Console.WriteLine("Неправильно введено шаг функции! Попробуйте еще раз");
            } while (true);
        }

        //метод возвращает список делегатов для доступных функций
        private static List<Function> FunctionInitialization()
        {
            List<Function> FunctionsList = new List<Function>();

            FunctionsList.Add(Sqrt);
            FunctionsList.Add(Square);
            FunctionsList.Add(Hyperbole);

            return FunctionsList;
        }
    }
}
