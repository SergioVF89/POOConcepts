using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2POO
{
    
    public class Parallelogram : Rectangle
    {

        private double _h;
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }
        private double ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The side: {value}, not is valid.");
            }
            return value;
        }
        public Parallelogram(string v, double a, double b, double h) : base(v, a, b)
        {
            H = h;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        public override double GetArea()
        {
            return B * H;
        }
    }
}
