using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2POO
{
    public class Rectangle : Square
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

        public Rectangle(string v, double a, double b) : base(v,a)
        {
            B = b;
        }


       


    }
}
