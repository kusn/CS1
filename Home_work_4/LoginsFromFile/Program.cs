// Кудряшов Сергей

// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
// Создайте структуру Account, содержащую Login и Password.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginsFromFile
{
    class Program
    {
        public struct Account
        {            
            public string Login { get; set; }
            public string Password { get; set; }
            public void Change(string login, string pswd)
            {
                this.Login = login;
                this.Password = pswd;
            }
        }

        static Account[] AccountsFromFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            //  Считываем количество пар "логин-пароль"            
            int N = File.ReadAllLines(file).Length;
            Account[] acc = new Account[N];
            for (int i = 0; i < N; i++)
            {
                string str = sr.ReadLine();
                int to = str.IndexOf(';');
                acc[i].Login = str.Substring(0, to);
                acc[i].Password = str.Substring(++to);
            }
            return acc;
        }

        static bool AccessCheck(string login_key, string pass_key, string login_in, string pass_in)
        {
            return (login_in == login_key && pass_in == pass_key);
        }

        static void Main(string[] args)
        {
            string login_key;
            string pass_key;
            bool check = false;
            int i = 0;

            int N = File.ReadAllLines("..\\..\\Logins.txt").Length;
            Account[] acc = new Account[N];
            acc = AccountsFromFile("..\\..\\Logins.txt");

            Console.WriteLine("АВТОРИЗУЙТЕСЬ");

            do
            {
                i++;
                if (i > 3)
                {
                    Console.WriteLine("Вы исчерпали количество попыток. Программа будет завершена.");
                    Environment.Exit(1);
                }
                Console.WriteLine("Попытка № " + i);
                Console.Write("Введите логин: ");
                string login_in = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string pass_in = Console.ReadLine();
                for (int j = 0; j < acc.Length; j++)
                {
                    login_key = acc[j].Login;
                    pass_key = acc[j].Password;
                    check = AccessCheck(login_key, pass_key, login_in, pass_in); 
                }
                //check = AccessCheck(login_key, pass_key, login_in, pass_in);
            }
            while (i < 4 && !check);

            Console.WriteLine("Привет!");
        }
    }
}
