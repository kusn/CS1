// Кудряшов Сергей

// С клавиатуры вводятся числа, пока не будет введен 0.
// Подсчитать сумму всех нечетных положительных чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_odd_positive_numbers
{
    class Program
    {
        static bool Even(int a)
        {
            return a % 2 == 0;
        }

        static void Main(string[] args)
        {
            int number = new int();
            int sum = 0;

            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. " +
                "Подсчитывается сумма всех нечетных положительных чисел.");
            do
            {
                Console.WriteLine("Введите число");
                number = int.Parse(Console.ReadLine());
                if (!Even(number) && number >= 0)
                    sum = sum + number;
            }
            while (number != 0);
            Console.WriteLine("Сумма введеных чисел = {0}", sum);
        }
    }
}
