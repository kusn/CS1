/*Кудряшов Сергей*/
/*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).*/

using System;

namespace My_Class
{
    public class My_Class
    {
        public void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        public void Pause()
        {
            Console.ReadLine();
        }
    }
}
