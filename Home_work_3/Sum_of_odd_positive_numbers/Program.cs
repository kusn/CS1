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
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Подсчёт суммы всех нечётных положительных чисел");
            Console.WriteLine("Введите любое целое число. Для выхода нажмите 0");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n != 0);
        }
    }
}
