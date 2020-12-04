// Кудряшов Сергей

// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
// Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран,
// используя tryParse.

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
                bool succes = Int32.TryParse(Console.ReadLine(), out number);
                if (succes)
                {
                    if (!Even(number) && number >= 0)
                        sum = sum + number;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных");
                }
            }
            while (number != 0);
            Console.WriteLine("Сумма введеных чисел = {0}", sum);
        }
    }
}
