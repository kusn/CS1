// Кудряшов Сергей

// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
// и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static double MassDifference(double m, double h)
        {
            double norm_BMI = 21.75;
            double norm_mass = new double();
            norm_mass = norm_BMI * 0.01 * h * 0.01 * h;
            return m - norm_mass;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите свой вес в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в сантиметрах: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double bmi = m / Math.Pow(0.01 * h, 2);
            Console.WriteLine($"Ваш индекс массы тела - {bmi}");

            if (bmi < 18.5)
            {
                Console.WriteLine($"Вам нужно набрать вес на {-1.0 * MassDifference(m, h)} кг");
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                Console.WriteLine("Ваш вес в норме.");
            }
            else
            {
                Console.WriteLine($"Вам нужно похудеть на {MassDifference(m, h)} кг");
            }
        }
    }
}
