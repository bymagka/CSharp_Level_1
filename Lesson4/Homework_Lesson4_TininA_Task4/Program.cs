/*
 * 
 * Тинин А
 * Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
 * 
 * Задача из урока 2:
 * 
 *  Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson4_TininA_Task4
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

                Account NewAccount = new Account("Passwords");

                if (!NewAccount.checkPassword(login, password))
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

        struct Account
        {
            private string Login { get; set; }
            private string Password { get; set; }


            public Account(string PasswordsFileName)
            {
                string[] PasswordsArray = File.ReadAllLines($"..\\..\\{PasswordsFileName}.txt");

                if(PasswordsArray.GetLength(0) != 0)
                {
                    Login = PasswordsArray[0];
                    Password = PasswordsArray[1];
                }
                else
                {
                    Login = String.Empty; Password = String.Empty;
                }
            }

            public bool checkPassword(string login, string password)
            {
                return login == this.Login && password == this.Password;
            }
        }
    }
}
