/*Кудряшов Сергей*/
/*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $. */

using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите свой возраст:");
            string age = Console.ReadLine();
            
            Console.WriteLine("Введите свой рост:");
            string height = Console.ReadLine();

            Console.WriteLine("Введите свой вес:");
            string weight = Console.ReadLine();

            #region Вывод результата методом склеивания
            Console.WriteLine("--Вывод результата методом склеивания--");

            Console.WriteLine("Ваше имя:\t" + name + "\n" + "Ваша фамилия:\t" + surname + "\n" 
                + "Ваш возраст:\t" + age + "\n" + "Ваш рост:\t" + height + "\n"
                + "Ваш вес:\t" + weight + "\n");
            #endregion

            #region Вывод результата используя форматированный вывод
            Console.WriteLine("--Вывод результата используя форматированный вывод--");
            
            Console.WriteLine("Ваше имя:\t{0}\n" + "Ваша фамилия:\t{1}\n" + "Ваш возраст:\t{2}\n"
                    + "Ваш рост:\t{3}\n" + "Ваш вес:\t{4}\n", name, surname, age, height, weight);
            #endregion

            #region Вывод результата используя знак $
            Console.WriteLine("--Вывод результата используя знак $--");
            Console.WriteLine($"Ваше имя:\t{name}\n" + $"Ваша фамилия:\t{surname}\n" + $"Ваш возраст:\t{age}\n"
                    + $"Ваш рост:\t{height}\n" + $"Ваш вес:\t{weight}\n");
            #endregion
        }
    }
}
