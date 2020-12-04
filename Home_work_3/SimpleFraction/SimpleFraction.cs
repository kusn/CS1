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
            set { denominator = value; }
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
                DivideByZeroException e = new DivideByZeroException();
                Console.WriteLine(e.Message);                
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public SimpleFraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public SimpleFraction Plus(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();
            int leastCommonMultiple = getLeastCommonMultiple(denominator, sf2.denominator);
            sf3.numerator = numerator * leastCommonMultiple / denominator + sf2.numerator * leastCommonMultiple / sf2.numerator;
            sf3.denominator = leastCommonMultiple;
            return sf3;
        }

        public SimpleFraction Subtract(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();
            int leastCommonMultiple = getLeastCommonMultiple(denominator, sf2.denominator);
            sf3.numerator = numerator * leastCommonMultiple / denominator - sf2.numerator * leastCommonMultiple / sf2.numerator;
            sf3.denominator = leastCommonMultiple;
            return sf3;
        }

        public SimpleFraction Multi(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();
            sf3.numerator = numerator * sf2.numerator;
            sf3.denominator = denominator * sf2.denominator;
            return sf3;
        }

        public SimpleFraction Divide(SimpleFraction sf2)
        {
            SimpleFraction sf3 = new SimpleFraction();
            sf3.numerator = numerator * sf2.denominator;
            sf3.denominator = denominator * sf2.numerator;
            return sf3;
        }

        public override string ToString()
        {
            string s = numerator + "/" + denominator;
            if (numerator * denominator < 0)
                s = "-" + numerator + "/" + denominator;
            return s;
        }

        public double ToDecimalFraction(SimpleFraction sf)
        {
            return Convert.ToDouble(sf.numerator) / Convert.ToDouble(sf.denominator);
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

        // Возвращает наименьшее общее кратное
        private static int getLeastCommonMultiple(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            return a * b / getGreatestCommonDivisor(a, b);
        }

    }
}
