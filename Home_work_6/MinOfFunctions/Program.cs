// Кудряшов Сергей

// Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию
// в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции
// и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором
// хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она
// возвращает минимум через параметр (с использованием модификатора out). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinOfFunctions
{
    public delegate double Fun(double x);

    class Program
    {
        public static double SquareFunc(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double LinFunc(double x)
        {
            return 3 * x;
        }

        public static double CubeFunc(double x)
        {
            return x * x * x - 50 * x * x - 25 * x - 10;
        }

        public static double SinFunc(double x)
        {
            return 5 * Math.Sin(x * Math.PI / 180);
        }

        public static void SaveFunc(Fun FF, string fileName, double a, double b, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(FF(x));
                x += step;// x=x+step;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            List<double> d = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d.Add(bw.ReadDouble());
                //d[i] = bw.ReadDouble();
                if (d[i] < min) min = d[i];
            }
            bw.Close();
            fs.Close();
            return d;
        }

        static void Main(string[] args)
        {
            Fun[] funs = { SquareFunc, LinFunc, CubeFunc, SinFunc };
            int n = 0;
            double x1, x2;
            List<double> d = new List<double>();
            double min;

            Console.WriteLine("Программа нахождения минимума функции на определенном отрезке");
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1  -  x^2-50x+10");
            Console.WriteLine("2  -  3*x");
            Console.WriteLine("3  -  x^3-50*x^2-25*x-10");
            Console.WriteLine("4  -  5*sin(x)");
            Console.WriteLine("Введите соответсвующий номер функции: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало и конец интервала (вводить через пробел от большего к меньшему): ");
            string[] str  = Console.ReadLine().Split(' ');
            x1 = double.Parse(str[0]);
            x2 = double.Parse(str[1]);

            switch (n)
            {
                case 1:
                    {
                        SaveFunc(funs[0], "data.bin", x1, x2, 0.5);
                        break;
                    }
                case 2:
                    {
                        SaveFunc(funs[1], "data.bin", x1, x2, 0.5);
                        break;
                    }
                case 3:
                    {
                        SaveFunc(funs[2], "data.bin", x1, x2, 0.5);
                        break;
                    }
                case 4:
                    {
                        SaveFunc(funs[3], "data.bin", x1, x2, 0.5);
                        break;
                    }
            }

            d = Load("data.bin", out min);

            for (int i = 0; i < d.Count; i++)
                Console.WriteLine(d[i]);

            Console.WriteLine("Минимум функции на данном отрезке: " + min);
            Console.ReadKey();
        }
    }
}
