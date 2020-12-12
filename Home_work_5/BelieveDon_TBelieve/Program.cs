// Кудряшов Сергей

//5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет.
// Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные,
// случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос и
// набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BelieveDon_TBelieve
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int N = File.ReadAllLines("..//..//Questions.txt").Length;
            StreamReader sr = new StreamReader("..//..//Questions.txt");

            for (int i = 0; i < N; i++)
            {
                string str = sr.ReadLine();
                dict.Add(str.Split('|')[0], str.Split('|')[1].ToLower());
            }
            sr.Close();

            Random rand = new Random();
            int count = 0;
            bool flag = true;
            while (flag == true)
            {
                int value = rand.Next(0, 9);
                Console.WriteLine(dict.ElementAt(value).Key);
                var enter = Console.ReadLine();
                if (enter.ToLower() == dict.ElementAt(value).Value)
                    points += 5; // +5 очков
                else
                    Console.WriteLine("Ответ неверный");
                count++;
                if (count >= 5) flag = false;
            }
            Console.WriteLine("Ваши очки = {0}", points);
            Console.ReadLine();
        }
    }
}
