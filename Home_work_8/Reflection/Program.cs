// Кудряшов Сергей

// С помощью рефлексии выведите все свойства структуры DateTime

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Type type = typeof(DateTime);
            
            Console.WriteLine(type);
            Console.WriteLine(type.GetType());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---Properties of DateTime---");
            foreach (var el in type.GetProperties())
                Console.WriteLine(el);
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
    }
}
