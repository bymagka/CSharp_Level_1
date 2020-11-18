using System;
using System.Collections.Generic;
using System.IO;

/*
 * 
 * TininA 
 * 
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
    в) отсортировать список по возрасту студента;
    г) *отсортировать список по курсу и возрасту студента;
    д) разработать единый метод подсчета количества студентов по различным параметрам
    выбора с помощью делегата и методов предикатов.
 */

public class Program
{
    public delegate bool FindAllTest(Student test, FindingParametrs fp);
    static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
    {

        return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
    }

    //в) отсортировать список по возрасту студента;
    static int SortingByAge(Student st1, Student st2) 
    {
        if (st1.age < st2.age) return -1;
        if (st1.age > st2.age) return 1;
        return 0;
    }

    //г) *отсортировать список по курсу и возрасту студента;
    static int SortingByCourseAndAge(Student st1, Student st2)
    {
        if (st1.course < st2.course) return -1;
        if (st1.course > st2.course) return 1;

        if (st1.age < st2.age) return -1;
        if (st1.age > st2.age) return 1;
   
        return 0;
    }

    //   д) разработать единый метод подсчета количества студентов по различным параметрам
    //      выбора с помощью делегата и методов предикатов.
    static int MaxByParametr(List<Student> list)
    {
        Console.WriteLine("Введите поле и значение для отбора");
        FindingParametrs.Field = Console.ReadLine();
        FindingParametrs.Value = Console.ReadLine();

        Predicate<Student> pr = new Predicate<Student>(FindingParametrs.FindAll);

        return list.FindAll(pr).Count;
    }

    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;

        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        int FiveAndSixCourses = 0;

        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
        Dictionary<int, int> FrequencyArray = new Dictionary<int, int>();


        List<Student> list = new List<Student>();                             // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("..\\..\\students_6.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[6]), int.Parse(s[5]), int.Parse(s[7]), s[8]));
                // Одновременно подсчитываем количество бакалавров и магистров
                int course = int.Parse(s[6]);

                if (course < 5) bakalavr++; else magistr++;

                //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
                if (course == 5 || course == 6) FiveAndSixCourses++;

                //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
              
                if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                {
                    if (FrequencyArray.ContainsKey(course)) FrequencyArray[course]++;
                    else FrequencyArray.Add(course, 1);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        list.Sort(new Comparison<Student>(MyDelegat));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);

        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        Console.WriteLine("Количество на 5 и 6 курсах:{0}", FiveAndSixCourses);

        foreach (var v in list) Console.WriteLine($"{v.firstName} {v.course}");

        //в) отсортировать список по возрасту студента;
        list.Sort(new Comparison<Student>(SortingByAge));
        Console.WriteLine("После сортировки по возрасту");
        foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

        
       
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
        Console.WriteLine("Вывод частотного массива в формате курс/количество учеников");

        foreach (var item in FrequencyArray.Keys)
        {
            Console.WriteLine($"{item}/{FrequencyArray[item]}");
        };

        //г) *отсортировать список по курсу и возрасту студента;
        list.Sort(new Comparison<Student>(SortingByCourseAndAge));
        Console.WriteLine("После сортировки по курсу и возрасту");
        foreach (var v in list) Console.WriteLine($"{v.firstName} {v.course} {v.age}");

        //   д) разработать единый метод подсчета количества студентов по различным параметрам
        //      выбора с помощью делегата и методов предикатов.
        int Max = MaxByParametr(list);
        Console.WriteLine($"Количество студентов по отбору: {Max}");
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}
