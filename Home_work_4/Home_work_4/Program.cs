// Кудряшов Сергей

//Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения
// от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу,
// позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится
// на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. 
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

using System;

namespace PairDividedIntoThree
{
    class Program
    {
        class MyArray
        {
            int[] a;
            
            //  Создание массива и заполнение его случайными числами от min до max
            public MyArray(int n, int min, int max)
            {
                a = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                    a[i] = rnd.Next(min, max);                
            }
            // Получение элементов массива
            public int[] Items
            {
                get
                {
                    return a;
                }
            }
        }

        static void Main(string[] args)
        {
            MyArray myarray = new MyArray(20, -10000, 10000);
            int count = 0;

            for (int i = 0; i < 20; i++)
                Console.Write(myarray.Items[i] + " ");
            Console.WriteLine("\n");
            for (int i = 0; i < 19; i++)
            {
                if (myarray.Items[i] % 3 == 0)
                {
                    Console.WriteLine($"Пара:{myarray.Items[i]};{myarray.Items[i + 1]}");
                    count++;
                }
            }
            Console.WriteLine("Количество пар: " + count);
        }
    }
}