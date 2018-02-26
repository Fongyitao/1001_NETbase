using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_面向对象_计算器
{
    class Calc
    {
        double _num1, _num2;

        public double Num1 { get => _num1; set => _num1 = value; }
        public double Num2 { get => _num2; set => _num2 = value; }

        public Calc(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
            
        }

        public Calc()
        {
        }

        public double Add()
        {
            return Math.Round(Num1 + Num2,4);
        }
        public double Sub()
        {
            return Math.Round(Num1 - Num2, 4);
        }
        public double Mult()
        {
            return Math.Round(Num1 * Num2, 4);
        }
        public double Division()
        {
            return Math.Round(Num1 / Num2, 4);
        }

    }
}
