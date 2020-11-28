// Кудряшов Сергей

// a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
// б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion__from_A_to_B
{
    class Program
    {
        static void RecursionFromAToB(int a, int b)
        {
            if (a != 0 && a < b + 1)
            {                
                Console.WriteLine(a);
                RecursionFromAToB(a + 1, b);
            }            
        }

        static int SumFromAToB(int a, int b)
        {
            if (a != 0 && a < b + 1)
            {
                int sum = a + SumFromAToB(a + 1, b);
                return sum;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Метод, который выводит на экран числа от А до B (A<B)");
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            RecursionFromAToB(a, b);
            Console.WriteLine("Сумма этих чисел равна: " + SumFromAToB(a, b));
        }
    }
}
