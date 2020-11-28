// Кудряшов Сергей

// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
// На выходе истина, если прошел авторизацию, и ложь, если не прошел
// (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля,
// написать программу: пользователь вводит логин и пароль, программа пропускает его дальше
// или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_check
{
    class Program
    {
        static bool AccessCheck(string login_key, string pass_key, string login_in, string pass_in)
        {
            return (login_in == login_key && pass_in == pass_key);
        }

        static void Main(string[] args)
        {
            const string login_key = "root";
            const string pass_key = "GeekBrains";

            Console.WriteLine("АВТОРИЗУЙТЕСЬ");
            int i = 0;
            do
            {
                i++;
                Console.Write("Введите логин: ");
                string login_in = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string pass_in = Console.ReadLine();
                if (AccessCheck(login_key, pass_key, login_in, pass_in))
                    break;
            }
            while(i < 3);

            Console.WriteLine()
        }
    }
}
