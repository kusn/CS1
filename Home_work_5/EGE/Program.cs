// Кудряшов Сергей

// *Задача ЕГЭ.
/* На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
 * школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
 * превосходит 100, каждая из следующих N строк имеет следующий формат:
 * < Фамилия > < Имя > < оценки >,
 * где < Фамилия > — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая
 * не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам
 * по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
 * Пример входной строки:
 * Иванов Петр 4 5 3
 * Требуется написать как можно более эффективную программу, которая будет выводить на экран
 * фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
 * набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EGE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество учеников N, которое не меньше 10, но не превосходит 100");
            //int N = Convert.ToInt32(Console.ReadLine());

            int N = File.ReadAllLines("..//..//Students.txt").Length;
            StreamReader sr = new StreamReader("..//..//Students.txt");

            string[] students = new string[N- 1];            
            string[] name = new string[N - 1];
            string[] lastname = new string[N - 1];            
            double[] ball = new double[N - 1];
            int[] dball = new int[3];
            Dictionary<string, double> dict = new Dictionary<string, double>();
            double min_ball = 5.0;            
            int i1 = 0;

            sr.ReadLine();
            for (int i = 0; i < N - 1; i++)
            {
                //Console.WriteLine("Введите данные по ученикам в формате < Фамилия > < Имя > < оценки >. Оценки через пробел: ");
                //students[i] = Console.ReadLine();
                students[i] = sr.ReadLine();
                lastname[i] = students[i].Split(' ')[0];
                name[i] = students[i].Split(' ')[1];
                name[i] = lastname[i] + " " + name[i];                
                dball[0] = int.Parse(students[i].Split(' ')[2]);
                dball[1] = int.Parse(students[i].Split(' ')[3]);
                dball[2] = int.Parse(students[i].Split(' ')[4]);
                ball[i] = (double)(dball[0] + dball[1] + dball[2]) / 3.0;
                dict.Add(name[i], ball[i]);
                if (ball[i] <= min_ball)
                {
                    min_ball = ball[i];
                    i1 = i;
                }
            }

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine(dict.ElementAt(i).Key + " " + dict.ElementAt(i).Value);
            }
            Console.WriteLine(Environment.NewLine);

            Dictionary<string, double> ndict = new Dictionary<string, double>();
            ndict.Add(dict.ElementAt(i1).Key, dict.ElementAt(i1).Value);
            Dictionary<string, double> cdict = new Dictionary<string, double>();
            cdict = dict;
            cdict.Remove(dict.ElementAt(i1).Key);
            
            min_ball = 5.0;
            for (int i = 0; i < cdict.Count; i++)
            {
                if (cdict.ElementAt(i).Value <= min_ball)
                {
                    min_ball = cdict.ElementAt(i).Value;
                    i1 = i;
                }
            }
            ndict.Add(cdict.ElementAt(i1).Key, cdict.ElementAt(i1).Value);
            cdict.Remove(dict.ElementAt(i1).Key);
            
            min_ball = 5.0;
            for (int i = 0; i < dict.Count; i++)
            {
                if (cdict.ElementAt(i).Value <= min_ball)
                {
                    min_ball = cdict.ElementAt(i).Value;
                    i1 = i;
                }
            }
            ndict.Add(cdict.ElementAt(i1).Key, cdict.ElementAt(i1).Value);
            
            for (int i = 0; i < ndict.Count; i++)
            {
                Console.WriteLine(ndict.ElementAt(i).Key + " " + ndict.ElementAt(i).Value);
            }

            for (int i = 0; i < dict.Count; i++)
            {
                if (dict.ElementAt(i).Value == ndict.ElementAt(2).Value)
                    Console.WriteLine(dict.ElementAt(i).Key + " " + dict.ElementAt(i).Value);
            }
            sr.Close();
        }
    }
}
