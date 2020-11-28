// Кудряшов Сергей

// Написать метод подсчета количества цифр числа.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_digits
{
    class Program
    {
        static int NumOfDigits(int number)
        {
            int n = 0;
            while(number != 0)
            {
                n++;
                number = number / 10;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчитаем количество цифр в целом числе.");
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число состоит из {NumOfDigits(number)} цифр");
        }
    }
}
