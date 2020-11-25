/*Кудряшов Сергей*/
/*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
  б) *Сделать задание, только вывод организовать в центре экрана.
  в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
*/

using System;

namespace About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            string my_Name = "Моё имя - Сергей";
            string my_Surname = "Моя фамилия - Кудряшов";
            string my_City = "Мой город проживания - Нижний Новгород";
            int w_height = Console.WindowHeight;
            int w_width = Console.WindowWidth;

            #region Написать программу, которая выводит на экран ваше имя, фамилию и город проживания

            Console.WriteLine($"Мое имя - {my_Name}\nМоя фамилия - {my_Surname}\nМой город проживания - {my_City}");

            #endregion

            #region Сделать задание, только вывод организовать в центре экрана
                        
            Console.SetCursorPosition(w_width / 2 - my_Name.Length / 2, w_height / 2 - 1);
            Console.WriteLine(my_Name);
            Console.SetCursorPosition(w_width / 2 - my_Surname.Length / 2, w_height / 2);
            Console.WriteLine(my_Surname);
            Console.SetCursorPosition(w_width / 2 - my_City.Length / 2, w_height / 2 + 1);
            Console.WriteLine(my_City);

            #endregion

            #region Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

            static void Print(string ms, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(ms);
            }

            Print(my_Name, w_width / 2 - my_Name.Length / 2, w_height / 2 - 1);
            Print(my_Surname, w_width / 2 - my_Surname.Length / 2, w_height / 2);
            Print(my_City, w_width / 2 - my_City.Length / 2, w_height / 2 + 1);

            #endregion

            
        }
    }
}
