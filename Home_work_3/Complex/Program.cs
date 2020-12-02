// Кудряшов Сергей

// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    struct ComplexStruct
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        // Пример вычитания двух комплексных чисел
        public ComplexStruct Subtract(ComplexStruct x)
        {
            ComplexStruct y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        //  Пример произведения двух комплексных чисел
        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            string s = "";
            if (im >= 0)
                s = re + "+" + im + "i";
            else
                s = re + "-" + Math.Abs(im) + "i";

            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexStruct complex1;
            ComplexStruct complex2;

            Console.WriteLine("Демонстрация работы структуры Complex");
            Console.WriteLine("Введите действительную часть 1-го комплексного числа");
            complex1.re = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мнимую 1-го часть комплексного числа");
            complex1.im = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительную часть 2-го комплексного числа");
            complex2.re = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мнимую 2-го часть комплексного числа");
            complex2.im = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма чисел {complex1} и {complex2} равна: " + complex1.Plus(complex2));
            Console.WriteLine($"Разница чисел {complex1} и {complex2} равна: " + complex1.Subtract(complex2));
            Console.WriteLine($"Произведение чисел {complex1} и {complex2} равно: " + complex1.Multi(complex2));
        }
    }
}
