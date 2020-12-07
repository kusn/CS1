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

namespace StaticClass_PairDividedIntoThree
{
    static class MyArray
    {
        public static int[] GetRndArray(int n, int min, int max)
        {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
            return a;
        }

        public static int[,] PairDividedIntoThree(int[] a)
        {
            List<List<int>> list = new List<List<int>>(); 
            int[,] aa = new int[2, a.Length];
            int count = 0;
            
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0)
                {
                    list[0].Add(a[i]);
                    list[1].Add(a[i + 1]);
                    //aa[0, count] = a[i];
                    //aa[1, count] = a[i + 1];
                    count++;
                }
            }
            for (int i = 0; i <= count; i++)
            {
                aa[0, i] = list[0].ElementAt(i);
                aa[1, i] = list[1].ElementAt(i);
            }
            return aa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            int[] a = new int[20];
            int[,] aa = new int[2,20];
            a = StaticClass_PairDividedIntoThree.MyArray.GetRndArray(20, -10000, 10000);
            aa = MyArray.PairDividedIntoThree(a);
            for(int i = 0; i < aa.Length; i++)
            {
                Console.Write(aa[0, i]);
                Console.WriteLine(aa[1, i]);
            }
        }
    }
}
