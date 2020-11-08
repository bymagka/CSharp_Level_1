using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
/*
 * TininA
 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    а) + Вывести только те слова сообщения,  которые содержат не более n букв.
    б) + Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) + Найти самое длинное слово сообщения.
    г) + Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 * 
 */

namespace Homework_Lesson5_TininA_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа работы со сообщениями приветствует вас!");
            Console.Write("Введите сообщение для обработки: ");

            string InputMessage = Console.ReadLine();

            //а) Вывести только те слова сообщения,  которые содержат не более n букв.
            Console.Write("\nВведите максимальное число букв: ");
            int n = 0;

            
            while (!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("\nНеправильно введено целое значине, повторите снова!");
            }
            Message.ShortStrings(InputMessage, n);

            //в) Найти самое длинное слово сообщения.
            Console.WriteLine($"\nСамые длинные слова сообщения: {Message.LongestWords(InputMessage)}");

            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            Console.WriteLine($"\nСамые длинные слова сообщения: {Message.LongestWordsWithStringBuilder(InputMessage)}");
           

            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            Console.Write("\nВведите символ, на который заканчиваются удаляемые слова: ");

            char Symbol = char.MinValue;

            while (!char.TryParse(Console.ReadLine(), out Symbol))
            {
                Console.WriteLine("\nНеправильно введен символ, повторите снова!");
            }
            Message.RemoveWords(ref InputMessage, Symbol);
            Console.WriteLine($"\nСтрока после удаления слов, оканчивающихся на введённый символ: {InputMessage}");


            //д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
            Console.WriteLine("Начните вводить слова, по которым будет найдено количество совпадений в тексте. Ввод пробела - конец ввода");
            string InputWord = Console.ReadLine();

            int Numerator = 0;
            string[] StringArray = new string[0];
            while (!string.IsNullOrWhiteSpace(InputWord))
            {
                Array.Resize(ref StringArray, Numerator + 1);
                StringArray[Numerator] = InputWord;
                Numerator++;
                InputWord = Console.ReadLine();
            }
            //метод возвращает количество совпадений, сохраненных в словарь
            Dictionary<string, int> FrequencyList = Message.WordsFrequency(StringArray, InputMessage);

            //печать частотного анализа
            Console.WriteLine("Ниже представлено количество совпадений введенных слов в строке");
            Message.PrintWordsFrequency(FrequencyList);

            Console.ReadLine();
        }
    }
}
