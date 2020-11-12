
/*
 * 
 * Tinin A
 * 
 * Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework_Lesson5_TininA_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка ввода пароля! Введите пароль: ");
            string Password = Console.ReadLine();

            //проверка без использования регулярных выражений;
            Console.WriteLine($"Пароль без использования регулярок: {CheckPasswordWithoutRegex(Password)}");

            //проверка с использованием регулярных выражений;   
            Console.WriteLine($"Проверка c использованием регулярок: {CheckPasswordWithRegex(Password)}");
            Console.ReadLine();
        }

        //метод осуществляет проверку введенной строки по заданным в задании условиям с использованием регулярных выражений
        private static bool CheckPasswordWithRegex(string password)
        {
            string pattern = @"^[a-z]([a-z]|\d){1,9}$";
            Regex myRegex = new Regex(pattern,RegexOptions.IgnoreCase);
            return myRegex.IsMatch(password);

        }

        //метод осуществляет проверку введенной строки по заданным в задании условиям без использования регулярных выражений
        private static bool CheckPasswordWithoutRegex(string password)
        {
            int passwordLength = password.Length;

            if (passwordLength < 2 || passwordLength > 10) return false;

            if (char.IsDigit(password[0])) return false;

            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item)) return false;
                if (item > 'а' && item < 'я') return false;
            }

            return true;
        }
    }

}
