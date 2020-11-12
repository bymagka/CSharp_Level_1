using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework_Lesson5_TininA_Task2
{
    static class Message
    {
        //Метод для вывода только тех слов сообщения,  которые содержат не более n букв.
        public static void ShortStrings(string Message, int n)
        {
            string[] WordsArray = SplitTheMessage(Message);
            foreach (string item in WordsArray)
            {
                if (item.Length < n && item != String.Empty) Console.WriteLine(item);
            }
        }

        //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static void RemoveWords(ref string Message, char Symbol)
        {
            //делит строку на слова, исключая знаки препинания
            string[] WordsArray = SplitTheMessage(Message);

            for(int i = WordsArray.Length - 1; i >= 0; i--)
            {
                if (char.Equals(WordsArray[i][WordsArray[i].Length - 1], Symbol))
                {
                    WordsArray[i] = "";
                }
            }

            Message = string.Join(" ",WordsArray).Trim();

        }

        //в) + Найти самое длинное слово сообщения.
        public static string LongestWords(string Message)
        {
           
            int MaxLength = 0;
            //делит строку на слова, исключая знаки препинания
            string[] WordsArray = SplitTheMessage(Message);

            //сначала вычисляем максимальную длину слова в сообщении
            foreach (string item in WordsArray)
            {
                if (item.Length > MaxLength)
                {
                    MaxLength = item.Length;
                }
            }
            string returnString = String.Empty;

            //выбираем все слова, длина которых равна максимальной
            foreach (string item in WordsArray)
            {
                if (item.Length == MaxLength)
                {
                    returnString = String.Concat(returnString,item, " ");
                }
            }
            return returnString.Trim();
        }

        // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        public static string LongestWordsWithStringBuilder(string Message)
        {

            int MaxLength = 0;
            //делит строку на слова, исключая знаки препинания
            string[] WordsArray = SplitTheMessage(Message);
            foreach (string item in WordsArray)
            {
                if (item.Length > MaxLength)
                {
                    MaxLength = item.Length;
                }
            }

            StringBuilder returnableStringBuilder = new StringBuilder();

            foreach (string item in WordsArray)
            {
                if (item.Length == MaxLength)
                {
                    returnableStringBuilder.Append(item).Append(' ');
                }
            }
            return returnableStringBuilder.ToString().Trim();
        }

        //делит строку на слова, исключая знаки препинания
        private static string[] SplitTheMessage(string Message)
        {
            return Message.Split(',', ' ', '.', ':', ';', '!', '?', '-');
        }


        //Метод для подсчета количества вхождений слов в строку.
        public static Dictionary<string,int> WordsFrequency(string[] Words, string Message)
        {
            Dictionary<string, int> FrequencyDictionary = new Dictionary<string, int>();
            
            string pattern = String.Empty;

            foreach(string item in Words)
            {
                pattern = $@"\b{item}\b";
                Regex FrequencyRegex = new Regex(pattern);
                FrequencyDictionary.Add(item, FrequencyRegex.Matches(Message).Count);
            }
            return FrequencyDictionary;
        }

        //метод для печати словаря
        public static void PrintWordsFrequency(Dictionary<string,int> FrequencyList)
        {

            foreach(string key in FrequencyList.Keys)
            {
                Console.WriteLine($"{key} - {FrequencyList[key]}");
            }
        }
    }
}
