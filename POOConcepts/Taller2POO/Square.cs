using System.Drawing;

namespace Taller2POO;

public class Square : Geometricfigure
{
    public Square(string v, double a) : base(v)
    {
        A = a;
    }

    private double _a;

  public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
  

    private double ValidateA(double side)
    {
        if (side <= 0)
        {
            throw new Exception($"The side: {side}, not is valid.");
        }
        return side;
    }
 


    public override double GetPerimeter()
    {
        return 4 * _a;
    }

    public override double GetArea()
    {
        return _a * _a;
    }
}
