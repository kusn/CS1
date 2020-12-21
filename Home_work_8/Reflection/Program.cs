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
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }


        static void Main(string[] args)
        {
            Type type = typeof(DateTime);
            DateTime dateTime = new DateTime();
            
            Console.WriteLine(type);
            Console.WriteLine(type.GetType());
            
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").Name);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").Attributes);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CustomAttributes);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetMethod);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").IsSpecialName);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").MemberType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").MetadataToken);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").Module);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").PropertyType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").ReflectedType);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").SetMethod);

            Console.ReadKey();
        }
    }
}
