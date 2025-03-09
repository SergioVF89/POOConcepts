using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2POO
{
    public class Kite: Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        private double ValidateB(double value)
        {
            if (value <= 0)
            {
                throw new Exception($"The side: {value}, not is valid.");
            }
            return value;
        }

        public Kite(string v, double a, int d1, int d2, int b) : base(v, a, d1, d2)
        {
            B = b;
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

       
    }
}
