// Кудряшов Сергей

// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения, которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив
// слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
// Здесь требуется использовать класс Dictionary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    class Program
    {
        public static class Message
        {
            public static string GetWordsOfDetLength(string msg, int n)
            {
                StringBuilder words = new StringBuilder();
                string[] ss = msg.Split(' ');

                foreach (var el in ss)
                {
                    if (el.Trim(new Char[] { '.', ',', '!', '?', ';', ':', '-' }).Length <= n)
                        words.Append(el.Trim(new Char[] { '.', ',', '!', '?', ';', ':', '-' }) + " ");
                }
                return words.ToString(); // Можно конечно загнать в массив string[]
            }

            public static string DelWordsOfEndChar(string msg, char c)
            {
                string[] ss = msg.Split(' ');

                for (int i = 0; i < ss.Length; i++)
                {
                    ss[i] = ss[i].Trim(new Char[] { '.', ',', '!', '?', ';', ':', '-' });
                    if (ss[i][ss[i].Length - 1] == c)
                        msg = msg.Remove(msg.IndexOf(ss[i]), ss[i].Length);
                }
                return msg;

            }

            public static string GetMaxLengthWord(string msg)
            {
                string smax = "";
                int max = 0;
                string[] ss = msg.Split(' ');

                for (int i = 0; i < ss.Length; i++)
                {
                    ss[i] = ss[i].Trim(new Char[] { '.', ',', '!', '?', ';', ':', '-' });
                    if (ss[i].Length >= max)
                    {
                        max = ss[i].Length;
                        smax = ss[i];
                    }
                }
                return smax;
            }

            public static string MessageFromMaxWords(string msg)
            {
                StringBuilder sb = new StringBuilder();
                string[] ss = msg.Split(' ');

                for (int i = 0; i < ss.Length; i++)
                {
                    ss[i] = ss[i].Trim(new Char[] { '.', ',', '!', '?', ';', ':', '-' });
                    if (ss[i].Length == Message.GetMaxLengthWord(msg).Length)
                        sb.Append(ss[i] + " ");
                }
                return sb.ToString();
            }

            public static Dictionary<string, int> FreqOfWords(string msg, string[] words)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                StringBuilder sb = new StringBuilder();
                string[] ss = msg.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    dict.Add(words[i], 0);
                }

                for (int i = 0; i < ss.Length; i++)
                {
                    ss[i] = ss[i].Trim(new Char[] { '.', ',', '!', '?', ';', ':', '-' }).ToLower();
                    if (dict.ContainsKey(ss[i]))
                        dict[ss[i]]++;
                }
                return dict;
            }
        }

        static void Main(string[] args)
        {
            // a)
            Console.WriteLine("Выводятся только те слова сообщения, которые содержат не более n букв");
            Console.WriteLine("Введите сообщение из нескольких слов: ");
            string msg = Console.ReadLine();
            Console.WriteLine(System.Environment.NewLine + "Введите максимальную длину слова, которое нужно найти: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Слова с длиной не более {n} символов: {Message.GetWordsOfDetLength(msg, n)}");

            // б)
            Console.WriteLine(System.Environment.NewLine + "Удаляются из сообщения все слова, которые заканчиваются на заданный символ.");
            Console.WriteLine("Введите символ: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Message.DelWordsOfEndChar(msg, c));

            // в)
            Console.WriteLine(System.Environment.NewLine +  "Самое длинное слово сообщения: " + Message.GetMaxLengthWord(msg));

            // г)
            Console.WriteLine(System.Environment.NewLine + "Сформирована строка из самых длинных слов сообщения: " + Message.MessageFromMaxWords(msg));

            // д)
            Console.WriteLine(System.Environment.NewLine + @"метод, который производит частотный анализ текста.
В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз
каждое из слов массива входит в этот текст.");
            Console.WriteLine("Введите слова через пробел");
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict = Message.FreqOfWords(msg, words);
            
            foreach (KeyValuePair<string, int> key in dict)
            {
                Console.WriteLine(key.Key + " " + key.Value.ToString());
            }
        }
    }
}
