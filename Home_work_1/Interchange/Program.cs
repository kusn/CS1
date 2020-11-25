/*Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) без использования третьей переменной.*/

using System;

namespace Interchange
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C использованием третьей переменной
            int ss = new int();
            Console.Write("Введите 1-ю целочисленную переменную:\t");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ю целочисленную переменную:\t");
            int s2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n--C использованием третьей переменной--");
            ss = s1;
            s1 = s2;
            s2 = ss;
            Console.WriteLine($"1-я переменная: {s1}; 2-я переменная: {s2}\n");
            #endregion

            #region без использования третьей переменной
            Console.WriteLine("\n--Без использования третьей переменной--");
            s1 = s1 + s2;
            s2 = s1 - s2;
            s1 = s1 - s2;
            Console.WriteLine($"1-я переменная: {s1}; 2-я переменная: {s2}\n");
            #endregion

            #region c использованием исключающего ИЛИ (XOR)
            Console.WriteLine("\n--C использованием исключающего ИЛИ (XOR)--");
            s1 = s1 ^ s2;
            s2 = s2 ^ s1;
            s1 = s1 ^ s2;
            Console.WriteLine(s1 ^ s2);
            Console.WriteLine($"1-я переменная: {s1}; 2-я переменная: {s2}\n");
            #endregion
        }
    }
}
