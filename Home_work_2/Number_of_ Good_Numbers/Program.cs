// Кудряшов Сергей

// *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
// «Хорошим» называется число, которое делится на сумму своих цифр.
// Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of__Good_Numbers
{
    class Program
    {
        static int SumOfDigits(int number)
        {
            int s = 0;
            while (number > 0)
            {
                s = s + number % 10;
                number = number / 10;
            }
            return s;
        }

        static int NumberOfGoodNumbers()
        {
            int numbers = 0;            

            for (int i = 1; i <= 1000000000; i++)
            {
                int sum = 0;
                sum = SumOfDigits(i);
                if (i % sum == 0)
                {
                    numbers++;
                }
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("Происходит подсчет...");
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            k = NumberOfGoodNumbers();
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            Console.WriteLine($"Количество хороших чисел от 1 до 1000000000 равно {k}");
            Console.WriteLine($"Для вычисления понадобилось {resultTime.TotalMilliseconds} мс");
        }
    }
}
