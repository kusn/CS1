// Кудряшов Сергей

// *а) Реализовать библиотеку с классом для работы с двумерным массивом.
// Реализовать конструктор, заполняющий массив случайными числами. Создать методы,
// которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
// свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент
// массива, метод, возвращающий номер максимального элемента массива (через параметры, используя
// модификатор ref или out).
// **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
// **в) Обработать возможные исключительные ситуации при работе с файлами.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayLibrary;

namespace MyTwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("массив случайных чисел");
            MyTwoDArray array = new MyTwoDArray(6, 7, -100, 100);
            Console.WriteLine(array.ToString());
            Console.WriteLine($"Сумма всех элементов: {array.Sum()}");
            Console.WriteLine($"Сумма всех элементов массива больше заданного: {array.SumFromNumber(10)}");
            Console.WriteLine($"Минимальный элемент: {array.Min}");
            Console.WriteLine($"Максимальный элемент: {array.Max}");
            int m_max;
            int n_max;
            array.MaxElement(out m_max, out n_max);
            Console.WriteLine($"Номер максимального элемента массива: {m_max}, {n_max}");
            array.MyTwoDArrayToFile("..\\..\\file.txt");
            Console.WriteLine("Чтение массива из файла");
            MyTwoDArray aa = new MyTwoDArray("..\\..\\file.txt");
            Console.WriteLine(aa.ToString());
        }
    }
}
