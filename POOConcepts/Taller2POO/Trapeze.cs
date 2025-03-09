using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2POO
{
    public class Trapeze : Triangle
    {
        private double _d;
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        private double ValidateD(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The side: {value}, not is valid.");
            }
            return value;
        }

        public Trapeze(string v, double a, double b, double c, int d, int h) : base(v, a, b, c,h)
        {
            D = d;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
        public override double GetArea()
        {
            return ((B + H) * D) / 2;
        }
    }


}
