using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrayLib
{
    public class TwoDimensionalArray
    {
        //Реализовать библиотеку с классом для работы с двумерным массивом.
        private int[,] a;
        Random rnd = new Random();


        //свойство, возвращающее минимальный элемент массива
        public int Min
        {
            get
            {
               int min = int.MaxValue;
               for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min) min = a[i, j];
                    }
                }
                return min;
            }
        }

        //свойство, возвращающее максимальный элемент массива 
        public int Max
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max) max = a[i, j];
                    }
                }
                return max;
            }
        }

        //Реализовать конструктор, заполняющий массив случайными числами.
        public TwoDimensionalArray(int FirstRankLength,int SecondRankLength)
        {
            a = new int[FirstRankLength, SecondRankLength];
            for(int i = 0; i < FirstRankLength; i++)
            {
                for(int j = 0; j < SecondRankLength; j++)
                {
                    a[i, j] = rnd.Next(-10_000, 10_000);
                }
            }
        }

        //Добавить конструктор который загружают данные из файла 
        public TwoDimensionalArray(string filename)
        {
            filename = $"..\\..\\{filename}.txt";

            //Обработать возможные исключительные ситуации при работе с файлами.
            try
            {
                StreamReader sr = new StreamReader(filename);

                int FirstRankLength = int.Parse(sr.ReadLine());
                int SecondRankLength = int.Parse(sr.ReadLine());

                a = new int[FirstRankLength, SecondRankLength];
                for (int i = 0; i < FirstRankLength; i++)
                {
                    string Line = sr.ReadLine();

                    string[] TechArray = Line.Split(' ');

                    for(int j = 0;j < TechArray.Length; j++)
                    {
                        a[i, j] = int.Parse(TechArray[j]);
                    }

                }
                sr.Close();

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        //методы,которые записывают данные в файл.
        public void PrintToFile(string filename, int firstRankBorder, int secondRankBorder)
        {
            filename = $"..\\..\\{filename}.txt";
            try
            {
                StreamWriter sw = new StreamWriter(filename,true);
                
                MaxElementIndex(out int FirstRankIndex, out int SecondRankIndex);

                sw.WriteLine($"\nМаксимальный элемент массива: {Max}. Индекс максимального элемента: [{FirstRankIndex},{SecondRankIndex}]");
                sw.WriteLine($"Минимальный элемент массива: {Min}");
                sw.WriteLine($"Сумма всех элементов массива: {Sum()}");
                sw.WriteLine($"Сумма элементов ниже введенной границы: {Sum(firstRankBorder, secondRankBorder)}");


                for(int i = 0; i < a.GetLength(0); i++)
                {
                    string Line = String.Empty;
                    for(int j = 0; j < a.GetLength(1); j++)
                    {
                        Line += $"{a[i,j]} ";
                    }
                    sw.WriteLine(Line);
                }
                sw.Close();
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        //методы, которые возвращают сумму всех элементов массива
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }


        //сумму всех элементов массива больше заданного
        public int Sum(int FirstBorder, int SecondBorder)
        {
            int sum = 0;
            for (int i = FirstBorder; i < a.GetLength(0); i++)
            {
                for (int j = SecondBorder; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }

        //метод,возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
        public void MaxElementIndex(out int FirstRankIndex, out int SecondRankIndex)
        {
            FirstRankIndex = 0;
            SecondRankIndex = 0;
            int max = int.MinValue;
           
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        FirstRankIndex = i;
                        SecondRankIndex = j;
                    }
                }
            }
        }
    }
}
