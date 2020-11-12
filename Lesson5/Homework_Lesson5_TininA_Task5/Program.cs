using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * Tinin A
 * 
 * 5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.
 */
namespace Homework_Lesson5_TininA_Task5
{
    partial class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Игра верю не верю приветствует вас!");

            //ввод данных для игры, на выходе массив из 5 вопросов
            InputData(out Question[] QuestionsArray);

            //вывод вопросов
            GameEngine(QuestionsArray);

        }

        private static void GameEngine(Question[] questionsArray)
        {
            int Score = 0;
            Console.WriteLine("Сейчас будет выведено 5 случайных вопросов из файла. Надо ответить Да или Нет.");
            foreach(Question item in questionsArray)
            {
                Console.WriteLine(item);
                if (item.CheckAnswer(Console.ReadLine().ToLower()))
                {
                    Score++;
                    Console.WriteLine("Ответ верный!");
                }
                else Console.WriteLine("Ответ неверный");
            }
            Console.WriteLine($"Ваш итоговый счет: {Score}");
            Console.ReadLine();
        }

        private static void InputData(out Question[] QuestionsArray)
        {
            Console.WriteLine("Введите название файла txt в каталоге проекта, где содержатся вопросы и ответы в формате \"Вопрос : ответ\"");
            string filename = $"..\\..\\{Console.ReadLine()}.txt";

            while (!File.Exists(filename))
            {
                Console.WriteLine("Такого файла не существует в каталоге проекта, попробуйте еще раз!");
                filename = $"..\\..\\{Console.ReadLine()}.txt";
            }

            QuestionsArray = new Question[5];
            int count = 0;
            Question[] AllQuestions = new Question[0];

            //собираем все строки, исключая неправильно введенные
            foreach(string item in File.ReadAllLines(filename))
            {
                string[] SplittedString = item.Split(new string[1] { " : " },StringSplitOptions.None);

                if(SplittedString.Length != 2)
                {
                    Console.WriteLine("Одна из строк введена неверно");
                }
                else
                {
                    Array.Resize(ref AllQuestions, ++count);
                    AllQuestions[count - 1] = new Question(SplittedString[0], SplittedString[1]);                
                }
            }

            //заполнение 5 случайными вопросами из общего списка
            count = 0;
            Random rnd = new Random();
            int index = 0;
            while (count < 5)
            {
                index = rnd.Next(0,AllQuestions.Length);
                if (Array.FindAll(QuestionsArray, x => x.GetQuestion() == AllQuestions[index].GetQuestion()).Length == 0)
                {
                    QuestionsArray[count] = AllQuestions[index];
                    count++;
                }
            }

    
        }
    }
}
