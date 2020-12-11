// Кудряшов Сергей

// Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
// при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) **с использованием регулярных выражений.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            Console.WriteLine("Программа, которая проверяет корректность ввода логина");
            Console.WriteLine();
            Console.WriteLine(@"Корректным логином будет строка от 2 до 10 символов,
содержащая только буквы латинского алфавита или цифры,
при этом цифра не может быть первой");
            Console.WriteLine();
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine().ToLower();
            char[] cLogin = new char[login.Length];
            cLogin = login.ToCharArray();
            if ((login.Length >= 2 && login.Length <= 10) && !char.IsDigit(cLogin[0]))
            {
                for (int i = 0; i < cLogin.Length; i++)
                {
                    if ((int)cLogin[i] >= 97 && (int)cLogin[i] <= 122)
                    {
                        check = true;
                    }
                }
                Console.WriteLine("Логин верного формата");
            }
            else
            {
                Console.WriteLine("Логин не верного формата");
                Console.ReadLine();
            }
        }
    }
}
