// Кудряшов Сергей

// Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
// в) отсортировать список по возрасту студента;
// г) *отсортировать список по курсу и возрасту студента;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Collections
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }


    class Program
    {
        static int MyDelegat_firstName(Student st1, Student st2)                  // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);        // Сравниваем две строки
        }

        static int MyDelegat_course(Student st1, Student st2)                  // Создаем метод для сравнения для экземпляров
        {
            if (st1.course > st2.course) return 1;
            else if (st1.course > st2.course) return -1;
            else return 0;
        }

        static int MyDelegat_age(Student st1, Student st2)                  // Создаем метод для сравнения для экземпляров
        {
            if (st1.age > st2.age) return 1;
            else if (st1.age > st2.age) return -1;
            else return 0;
        }


        static void Main(string[] args)
        {
            int count_stud_5 = 0;                                       // Кол-во студентов на 5 курсе
            int count_stud_6 = 0;                                       // Кол-во студентов на 6 курсе
            Dictionary<int, int> dict = new Dictionary<int, int>();     // Создаем кол-во студентов от 18 до 20 лет на каждом курсе
            List<Student> list = new List<Student>();                   // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..//..//students.csv", Encoding.GetEncoding(1251));
            int i = 0;
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) == 5) count_stud_5++;
                    else if (int.Parse(s[6]) == 6) count_stud_6++;

                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                        if (dict.Count != 0 && dict.ContainsValue(int.Parse(s[6])))
                        {
                            dict[int.Parse(s[6])]++;
                        }
                    else
                        {
                            dict.Add(int.Parse(s[6]), 1);
                        }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
                i++;
            }
            sr.Close();
            //list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Всего студентов на 5 курсе: {0}", count_stud_5);
            Console.WriteLine("Всего студентов на 6 курсе: {0}", count_stud_6);

            Console.WriteLine(System.Environment.NewLine + "Кол-во студентов от 18 до 20 лет на каждом курсе.");
            Console.WriteLine("Курс - кол-во:");
            foreach (var v in dict)
                Console.WriteLine(v.Key + " - " + v.Value);

            Console.WriteLine(System.Environment.NewLine + "Сортировка студентов по возрасту:");
            list.Sort(new Comparison<Student>(MyDelegat_age));
            foreach (var v in list) Console.WriteLine(v.firstName + "-" + v.age);

            Console.WriteLine(System.Environment.NewLine + "Сортировка студентов по курсу и возрасту:");
            list.Sort(new Comparison<Student>(MyDelegat_course));
            foreach (var v in list) Console.WriteLine(v.firstName);

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
