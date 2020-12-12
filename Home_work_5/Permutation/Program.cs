// Кудряшов Сергей

// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например:
// badc являются перестановкой abcd.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        public static bool IsPermutation(string str1, string str2)
        {
            bool check = false;

            if (str1 == str2)
            {
                check = true;
            }
            else if (str1.Length == str2.Length)
            {
                int count = 0;
                char[] c1 = str1.ToCharArray();
                char[] c2 = str2.ToCharArray();
                Dictionary<char, int> dict = new Dictionary<char, int>();

                for (int i = 0; i < str1.Length; i++)
                {
                    dict.Add(c1[i], 0);
                }
                for (int i = 0; i < str2.Length; i++)
                {
                    if (dict.ContainsKey(c2[i]))
                    {
                        dict[c2[i]]++;                        
                        if (dict[c2[i]] == 1)
                            count++;
                    }
                }
                if (count == str1.Length)
                    check = true;
            }

            return check;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Метод, определяющий, является ли одна строка перестановкой другой");
            Console.WriteLine("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            Console.WriteLine(IsPermutation(str1, str2));
        }
    }
}
