/*Кудряшов Сергей*/
/*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
 * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 * б) Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

using System;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты 2-х точек");
            Console.Write("Введите х1:\t");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1:\t");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите х2:\t");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y2:\t");
            int y2 = Convert.ToInt32(Console.ReadLine());

            #region a)
            double r = new double();
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между 2-мя точками равняется {r:f2}");
            #endregion

            #region б)
            static double Interval(int x1, int y1, int x2, int y2)
            {                
                return  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
            
            double rr = new double();
            
            rr = Interval(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между 2-мя точками равняется {rr:f2}");
            #endregion
        }
    }
}
