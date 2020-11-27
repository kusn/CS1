//Кудряшов Сергей

// Написать метод, возвращающий минимальное из трёх чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_of_three
{
    class Program
    {
        static double Min_of_three(double a, double b, double c)
        {
            double min = new double();
            if (a <= b)
                min = a;
            else
                min = b;
            if (c < min)
                min = c;            
            return min;
        }

        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Вычислим минимальное из трех чисел.");
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число число");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{Min_of_three(a, b, c)} - минимальное из введенных чисел");
        }
    }
}
