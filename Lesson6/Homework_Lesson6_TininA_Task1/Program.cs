
using System;
/*
 * TininA
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 */
public delegate double Fun(double x);

//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
public delegate double MyFun(double x, double a);

class Program
{
    
    public static void Table(MyFun F, double x, double b,double a)
    {
        Console.WriteLine("----- X ----- Y -----A-----");
        while (x <= b)
        {
            //Изменил тип делегата и вызов функции делегата
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, F(x,a),a);
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // Создаем метод для передачи его в качестве параметра в Table
    //a*sin(x)
    public static double Sin(double x,double a)
    {
        return a * Math.Sin(x);
    }

    //a* x^2 
    public static double MyFunc(double x, double a)
    {
        return a * x * x;
    }

    static void Main()
    {
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции MyFunc (a * x^2 ):");
        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        Table(new MyFun(MyFunc), -2, 2, 5);
        Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
        // Упрощение(c C# 2.0).Делегат создается автоматически.            
        Table(MyFunc, -2, 2, 5);
        //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)
        Console.WriteLine("Таблица функции Sin:");
        Table(Sin, -2, 2, 5);      // Можно передавать уже созданные методы
        Console.WriteLine("Таблица функции a *x^2:");
        // Упрощение(с C# 2.0). Использование анонимного метода
        Table(delegate (double x,double a) { return a*x*x; }, 0, 3,5);
        Console.ReadLine();
    }
}
