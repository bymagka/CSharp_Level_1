/*
 * 
 * Тинин А
 * 
 * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
 */
using System;

namespace Homework_Lesson3_TininA_Task3
{
    class Fractions
    {
        private int numerator;
        private int denominator;
  
 

        public double DoubleView { get => (double)this.numerator / (double)this.denominator; }

        public override string ToString()
        {
                return $"Нормальный вид дроби: {numerator}/{denominator}. Десятичный вид дроби: {DoubleView}";
       
        }

    
        public Fractions(int numerator,int denominator)
        {
            if (denominator == 0)  throw new ArgumentException(); 

            if(denominator < 0)
            {
                this.numerator = -1*numerator;
                this.denominator = -1*denominator;
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }

            Reduction();
        }

        public void Reduction()
        {
            int NOD = Math.Abs(FindNOD(numerator, denominator));

            numerator /= NOD;
            denominator /= NOD;

        }

        public static Fractions InputFraction(int count)
        {
            int numerator = 0;
            int denominator = 0;
            do
            {
                Console.Write($"\nВведите числитель {count} дроби: ");
                if (!int.TryParse(Console.ReadLine(), out int numeratorTech))
                {
                    Console.WriteLine("Вы ввели не целое число! Попробуйте повторно!");
                    continue;
                }
                else
                {
                    numerator = numeratorTech;
                    break;
                }
            } while (true);

            do
            {
                Console.Write($"\nВведите знаменатель {count} дроби: ");
                if (!int.TryParse(Console.ReadLine(), out int denominatorTech))
                {
                    Console.WriteLine("Вы ввели не целое число! Попробуйте повторно!");
                    continue;
                }
                else
                {
                    denominator = denominatorTech;
                    break;
                }
            } while (true);

            try
            {
                Fractions Fraction = new Fractions(numerator, denominator);
                return Fraction;
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Не удалось создать дробь по причине: {ex.Message}! Попробуйте ввести дробь повторно");
                return InputFraction(count);
            }
        }
    
        public static Fractions operator *(Fractions Fraction1, Fractions Fraction2)
        {
            return new Fractions(Fraction1.numerator * Fraction2.numerator, Fraction1.denominator * Fraction2.denominator);
        }

        public static Fractions operator /(Fractions Fraction1, Fractions Fraction2)
        {
            try
            {
                return new Fractions(Fraction1.numerator * Fraction2.denominator, Fraction1.denominator * Fraction2.numerator);
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"\nНа 0 делить нельзя, частное вычислить не удалось! {ex.ToString()}");
                return Fraction1;
            }
           
        }

        public static Fractions operator +(Fractions Fraction1, Fractions Fraction2)
        {
            if (Fraction1.denominator == Fraction2.denominator) return new Fractions(Fraction1.numerator + Fraction2.numerator, Fraction1.denominator);
            else 
            {
                int NOK = FindNOK(Fraction1.denominator, Fraction2.denominator);
                return new Fractions(Fraction1.numerator * (NOK / Fraction1.denominator) + Fraction2.numerator * (NOK / Fraction2.denominator), NOK);
            } 
        }

        public static Fractions operator -(Fractions Fraction1, Fractions Fraction2)
        {
            if (Fraction1.denominator == Fraction2.denominator) return new Fractions(Fraction1.numerator + Fraction2.numerator, Fraction1.denominator + Fraction2.denominator);
            else
            {
                int NOK = FindNOK(Fraction1.denominator, Fraction2.denominator);
                return new Fractions(Fraction1.numerator * (NOK / Fraction1.denominator) - Fraction2.numerator * (NOK / Fraction2.denominator), NOK);
            }
        }
        private static int FindNOD(int numerator,int denominator)
        {
    
           while(denominator != 0)
            {
                int temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }
            return numerator;
        }

        private static int FindNOK(int FirstDenumerator, int SecondDenumerator)
        {

            return FirstDenumerator * SecondDenumerator / FindNOD(FirstDenumerator, SecondDenumerator);
        }

    }
}
