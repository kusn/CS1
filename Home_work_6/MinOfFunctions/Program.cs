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
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            Fun[] funs = new Fun[4];            
            
            SaveFunc(new Fun(F), "data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}
