using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tinin A
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
namespace Homework_Lesson2_TininA_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int AttemptsCount = 0;
            string login = String.Empty;
            string password = String.Empty;
            do
            {
                if (AttemptsCount != 0)
                {
                    Console.WriteLine("Попробуйте ещё раз!");
                }
                Console.WriteLine("Введите пользователя и пароль");
                Console.Write("Пользователь: ");
                login = Console.ReadLine();

                Console.Write("Пароль: ");
                password = Console.ReadLine();
                if (!checkPassword(login,password))
                {
                    AttemptsCount++;
                    Console.WriteLine("Неправильно введён пароль!");
                }
                else
                {
                    Console.WriteLine("Вы правильно ввели пароль, поздравляем!");
                    break;
                }
            } while (AttemptsCount < 3);
            if (AttemptsCount == 3)
            {
                Console.WriteLine("Вы истратили все три попытки ввода пароля!");
            }
            Console.ReadLine();
        }
        
        public static bool checkPassword(string login, string password)
        {
            return login == "root" && password == "GeekBrains";
        }
    }
}
