using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class ComplexClass
    {        
        double im;        
        double re;
        
        public ComplexClass()
        {
            im = 0;
            re = 0;
        }
        
        public ComplexClass(double im, double re)
        {                          
            this.im = im;            
            this.re = re;
        }
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public ComplexClass Subtract(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();            
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }

        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();            
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                //if (value >= 0) im = value;
                im = value;
            }
        }
        
        public override string ToString()
        {
            string s = "";
            if (im >= 0)
                s = re + "+" + im + "i";
            else
                s = re + "-" + Math.Abs(im) + "i";

            return s;
        }

    }
}
