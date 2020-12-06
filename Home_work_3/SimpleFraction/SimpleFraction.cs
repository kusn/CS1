using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFractions
{
    class SimpleFraction
    {
        int numerator;
        int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (denominator == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                    throw new DivideByZeroException("В знаменателе не может быть нуля");
                }
                else
                    denominator = value;
            }
        }

        public SimpleFraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public SimpleFraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }
            else
                {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }

        // Представление целого числа в виде обыкновенной дроби
        public SimpleFraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        // Сложение дробей
        public SimpleFraction Plus(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();            
            sf3.numerator = numerator * sf2.denominator + sf2.numerator * denominator;
            sf3.denominator = denominator * sf2.denominator;
            sf3 = Reduce(sf3);
            return sf3;
        }

        // Вычитание дробей
        public SimpleFraction Subtract(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();            
            sf3.numerator = numerator * sf2.denominator - sf2.numerator * denominator;
            sf3.denominator = denominator * sf2.denominator;
            sf3 = Reduce(sf3);
            return sf3;
        }

        // Умножение дробей
        public SimpleFraction Multi(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();
            sf3.numerator = numerator * sf2.numerator;
            sf3.denominator = denominator * sf2.denominator;
            sf3 = Reduce(sf3);
            return sf3;
        }

        // Деление дробей
        public SimpleFraction Divide(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();
            sf3.numerator = numerator * sf2.denominator;
            sf3.denominator = denominator * sf2.numerator;
            sf3 = Reduce(sf3);
            return sf3;
        }

        // Вывод в виде строки
        public override string ToString()
        {
            string s = numerator + "/" + denominator;
            if (numerator * denominator < 0)
                s = "-" + Math.Abs(numerator) + "/" + Math.Abs(denominator);
            return s;
        }

        // Десятичное представление
        public double ToDecimalFraction
        {
            get
            {
                return Convert.ToDouble(numerator) / Convert.ToDouble(denominator);
            }
        }

        // Возвращает наибольший общий делитель
        private static int getGreatestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Сокращение дроби
        private static SimpleFraction Reduce(SimpleFraction sf)
        {
            SimpleFraction sf2 = new SimpleFraction();
            int d = getGreatestCommonDivisor(sf.numerator, sf.denominator);
            sf2.numerator = sf.numerator / d;
            sf2.denominator = sf.denominator / d;
            return sf2;
        }
    }
}
