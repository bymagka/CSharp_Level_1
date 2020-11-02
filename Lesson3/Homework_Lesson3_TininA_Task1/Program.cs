using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson3_TininA_Task1
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета комплексных чисел приветствует вас!");
            Console.WriteLine("Хотите работать с классом или структурой? (класс/структура)");
            string WorkingWay = Console.ReadLine();

            switch (WorkingWay)
            {
                case "класс":
                    WorkingWithComplexClass();
                    break;
                case "структура":
                   WorkingWithComplexStructure();
                    break; 
            }
            Console.WriteLine("Работа программы закончена!");
            Console.ReadLine();
           
        }

                
        public static void WorkingWithComplexClass()     
        {
            double im, re;
            
            Console.Write("Введите значение действительной части первого компклексного числа: ");
            re = double.Parse(Console.ReadLine());

            Console.Write("\nВведите значение мнимой части первого компклексного числа: ");
            im = double.Parse(Console.ReadLine());

            ComplexClass FirstNumber = new ComplexClass(im, re);
   
                
            Console.Write("\nВведите значение действительной части второго компклексного числа: ");
            re = double.Parse(Console.ReadLine());

            Console.Write("\nВведите значение мнимой части второго компклексного числа: ");
            im = double.Parse(Console.ReadLine());

            ComplexClass SecondNumber = new ComplexClass(im, re);
           
            Console.Write("\nВведите необходимую для расчета операцию (Multi/Plus/Minus): ");

            string OperationString = Console.ReadLine();

            Operations Operation;

            switch (OperationString)
            {
                case "Minus":
                    Operation = Operations.Minus;
                    break;
                case "Plus":
                    Operation = Operations.Plus;
                    break;
                case "Multi":
                    Operation = Operations.Multi;
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильную операцию!");
                    return;
            }
            
            Console.WriteLine($"\nРезультат выполненной операции с числами: {FirstNumber.Operation(Operation,SecondNumber)}");
       
            Console.ReadLine(); 
        }
    
        
        public static void WorkingWithComplexStructure()     
        {
            double im, re;
            
            Console.Write("Введите значение действительной части первого компклексного числа: ");
            re = double.Parse(Console.ReadLine());

            Console.Write("\nВведите значение мнимой части первого компклексного числа: ");
            im = double.Parse(Console.ReadLine());

            ComplexStruct FirstNumber = new ComplexStruct(im, re);

                
            Console.Write("\nВведите значение действительной части второго компклексного числа: ");
            re = double.Parse(Console.ReadLine());

            Console.Write("\nВведите значение мнимой части второго компклексного числа: ");
            im = double.Parse(Console.ReadLine());

            ComplexStruct SecondNumber = new ComplexStruct(im, re);

            Console.WriteLine($"\nРазница двух комплексных чисел равна: {FirstNumber.Minus(SecondNumber)}");
            Console.WriteLine($"Сумма двух комплексных чисел равна: {FirstNumber.Plus(SecondNumber)}");
            Console.WriteLine($"Произведение двух комплексных чисел равно: {FirstNumber.Multi(SecondNumber)}");
            Console.ReadLine(); 
        }
    
    }
   
}
