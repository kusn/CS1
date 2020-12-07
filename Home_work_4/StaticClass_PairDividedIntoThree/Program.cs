// Кудряшов Сергей

// Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
// в)**Добавьте обработку ситуации отсутствия файла на диске.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StaticClass_PairDividedIntoThree
{
    static class MyArray
    {
        // Получение рандомного массива
        public static int[] GetRndArray(int n, int min, int max)
        {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            return a;
        }
        // Получение массива из файла
        public static int[] GetArrayFromFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            //  Считываем количество элементов массива            
            int N = File.ReadAllLines(file).Length;
            int[] a = new int[N];
            //  Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
            return a;
        }

        // Запись массива в файл
        public static void SetArrayToFile(string file, int[] a)
        {            
            StreamWriter sw = new StreamWriter(file);

            for (int i = 0; i < a.Length; i++)
            {
                sw.WriteLine(a[i]);
            }
            sw.Close();
        }

        // Получение списка пар
        public static List<int> PairDividedIntoThree(int[] a)
        {
            List<int> list = new List<int>();            
            
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] % 3 == 0 && a[i - 1] %3 != 0)
                {
                    list.Add(a[i - 1]);
                    list.Add(a[i]);                    
                }
                else if (a[i] % 3 != 0 && a[i - 1] % 3 == 0)
                {
                    list.Add(a[i - 1]);
                    list.Add(a[i]);
                }
            }
            return list;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            int[] a = new int[20];
            List<int> list = new List<int>();

            a = MyArray.GetRndArray(20, -10000, 10000);
            list = MyArray.PairDividedIntoThree(a);

            Console.WriteLine("Массив: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");
            for(int i = 0; i < list.Count - 1; i = i + 2)
            {
                Console.WriteLine(list[i] + ", " + list[i + 1]);
            }
            Console.WriteLine($"Количество пар: {list.Count / 2}");
            
            // Работа с файлом
            Console.WriteLine("Запись массива в файл");
            try
            {
                MyArray.SetArrayToFile("..\\..\\file.txt", MyArray.GetRndArray(20, -10000, 10000));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                a = MyArray.GetArrayFromFile("..\\..\\file.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            list = MyArray.PairDividedIntoThree(a);

            Console.WriteLine("Массив: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");
            for (int i = 0; i < list.Count - 1; i = i + 2)
            {
                Console.WriteLine(list[i] + ", " + list[i + 1]);
            }
            Console.WriteLine($"Количество пар: {list.Count / 2}");
        }
    }
}
