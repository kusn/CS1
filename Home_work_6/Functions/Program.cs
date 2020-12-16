// Кудряшов Сергей

// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа
// double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
// функцией a*sin(x).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public delegate double Fun(double a, double x);

    class Program
    {
        public static void Table(Fun F, double a, double x1, double x2)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x1 <= x2)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x1, F(a, x1));
                x1 += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        public static double SquareFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double SinFunc(double a, double x)
        {
            return a * Math.Sin(x * Math.PI / 180.0);
        }


        static void Main(string[] args)
        {            
            Console.WriteLine("Таблица функции SquareFunc (a * x^2):");            
            Table(new Fun(SquareFunc), 3, -2, 2);
            Console.WriteLine("Таблица функции SinFunc (a * sin(x)):");
            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(new Fun(SinFunc), 3, -2, 2);            
        }
    }
}
