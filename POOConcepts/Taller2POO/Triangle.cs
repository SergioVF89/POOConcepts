using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2POO
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        private double ValidateC(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The side: {value}, not is valid.");
            }
            return value;
        }
      

        private double ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The side: {value}, not is valid.");
            }
            return value;
        }
        public Triangle(string v, double a, double b, double c, int h) : base(v, a, b)
        {
            C = c;
            H = h;
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

    }
}
