using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * TininA
 * 
 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <оценки>,
    где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
    Иванов Петр 4 5 3
    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

 */
namespace Homework_Lesson5_TininA_Task4
{
    class Program
    {
        //структура данных для хранения информации об оценке
        private struct PupilInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public double AverageMark { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName} - {AverageMark}";
            }
        }


        static void Main(string[] args)
        {
            //ввод данных с консоли со всеми проверками, возвращает массив структур с оценками
            InputData(out PupilInfo[] Pupils); 
            
            //упорядочивание массива по убыванию с использованием анонимного метода
            IEnumerable<PupilInfo> query = Pupils.OrderByDescending(x => x.AverageMark);
            Console.WriteLine("Лучшие ученики");
            //печать результатов
            PrintLeaders(query);
        }

        //метод ввода данных со всеми проверками
        private static void InputData(out PupilInfo[] pupils)
        {
            Console.WriteLine("Программа вывода лидеров по средней оценке приветствует!");

            Console.Write("Введите количество учеников: ");
            int count = 0;
            while (!int.TryParse(Console.ReadLine(),out count) && count > 100 && count < 10)
            {
                Console.WriteLine("\n Неправильно введено количество учеников, введите повторно");
            }

            pupils = new PupilInfo[count];

            Console.WriteLine("Начинайте вводить данных об учениках по правилам задачи");

            while(count > 0)
            {
                string[] SplittedArray = Console.ReadLine().Split(' ');
                if(SplittedArray.Length != 5)
                {
                    Console.WriteLine("Неправильно введена строка, должно быть 5 элементов с пробелом. Попробуйте повторно");
                    continue;
                }
                
                if(SplittedArray[0].Length > 20 && SplittedArray[1].Length > 15)
                {
                    Console.WriteLine("Неправильно введены фио. Попробуйте повторно");
                    continue;
                }

                int sum = 0;
                bool Error = false;

                for(int i = 2; i < 5; i++)
                {
                    if(int.TryParse(SplittedArray[i],out int Mark))
                    {
                        sum += Mark;

                    }
                    else Error = true;                            
                }
                if(Error)
                {
                    Console.WriteLine("Неправильно введен один из номеров. Попробуйте повторно");
                    continue;
                }

                PupilInfo newPupil = new PupilInfo();
                newPupil.FirstName = SplittedArray[0];
                newPupil.LastName = SplittedArray[1];
                newPupil.AverageMark = (double)sum / 3;

                pupils[count - 1] = newPupil;
                count--;

            }
            
            
        }

        //печать результатов. Если ученики набрали одинаковые баллы, то они выводятся на одном месте. Для этого введена переменная index и lastAverageMark
        private static void PrintLeaders(IEnumerable<PupilInfo> query)
        {
            int index = 0;
            double lastAverageMark = 0;
            foreach (var item in query)
            {
                if (index > 3) break;
                if (item.AverageMark != lastAverageMark)
                {
                    index++;
                    lastAverageMark = item.AverageMark;
                }
                Console.WriteLine($"{index}. {item}");

               
            }
            Console.ReadLine();
        }
    }
}
