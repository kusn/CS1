/*Кудряшов Сергей*/
/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
 где m — масса тела в килограммах, h — рост в метрах.*/

using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой вес в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в сантиметрах: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double I = m / Math.Pow(0.01 * h, 2);
            Console.WriteLine($"Ваш индекс массы тела - {I}");
        }
    }
}
