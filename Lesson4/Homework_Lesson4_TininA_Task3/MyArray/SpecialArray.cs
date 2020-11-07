
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyArray
{
    /*
     *  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
     */
    //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки

    public class SpecialArray
    {
        private int[] a;
        Random rnd = new Random();

        //Создать свойство Sum, которое возвращает сумму элементов массива
        public int Sum
        {
            get
            {
                int sum = 0;

                foreach (int item in a)
                {
                    sum += item;
                }
                return sum;
            }
        }

        //свойство MaxCount, возвращающее количество максимальных элементов
        public int MaxCount 
        { 
            get 
            {
                int count = 0;
                int MaxElement = a.Max();
                foreach(int item in a)
                {
                    if (item == MaxElement) count++;
                }
                return count;
            } 
        }

        public int Length { get { return a.Length;} }
        public int Max
        {
            get
            {
                return a.Max();
            }
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public SpecialArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 101);
        }

        //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        public SpecialArray(int Length,int StartValue,int Step)
        {
            a = new int[Length];
            for (int i = 0;i < Length; i++)
            {
                a[i] = StartValue;
                StartValue += Step;
            }
        }



        public SpecialArray(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл 
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }




        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
        }

        // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
        public int[] Inverse()
        {
            int[] ReturnArray = new int[a.Length];
            
            for(int i = 0; i < a.Length; i++)
            {
                ReturnArray[i] = a[i] * -1;
            }
            return ReturnArray;
        }

        
        //метод Multi, умножающий каждый элемент массива на определённое число
        public void Multi(int multiplier)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                a[i] += a[i] * multiplier;
            }
        }
    }
}
