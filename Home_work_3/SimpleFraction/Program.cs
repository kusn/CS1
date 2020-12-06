// Кудряшов Сергей

// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
// *Добавить свойства типа int для доступа к числителю и знаменателю;
// *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// **Добавить проверку, чтобы знаменатель не равнялся 0.
// Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// ***Добавить упрощение дробей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFraction sf1 = new SimpleFraction();
            SimpleFraction sf2 = new SimpleFraction();

            Console.WriteLine("Программа, демонстрирующая все разработанные элементы класса дробей");
            Console.WriteLine("Введите числитель первой дроби (должно быть цело число):");
            sf1.Numerator = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби (должно быть цело число):");
            sf1.Denominator = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите числитель втрой дроби (должно быть цело число):");
            sf2.Numerator = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби (должно быть цело число):");
            sf2.Denominator = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Сумма данных дробей:");
            Console.WriteLine(sf1.Plus(sf2).ToString());
            Console.WriteLine("Разница данных дробей:");
            Console.WriteLine(sf1.Subtract(sf2).ToString());
            Console.WriteLine("Произведение данных дробей:");
            Console.WriteLine(sf1.Multi(sf2).ToString());
            Console.WriteLine("Отношение данных дробей:");
            Console.WriteLine(sf1.Divide(sf2).ToString());
            Console.WriteLine($"Десятичное представление 1-ой дроби: {sf1.ToDecimalFraction}");
            Console.WriteLine($"Десятичное представление 2-ой дроби: {sf2.ToDecimalFraction}");
            Console.WriteLine("Введите дробь в формате \"x/y\"");
        }
    }
}
