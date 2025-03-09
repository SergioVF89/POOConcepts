namespace Taller2POO;

class Circle : Geometricfigure
{
    public Circle(string v, double r) : base(v)
    {
        R = r;
    }
    private double _r;
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    private double ValidateR(double side)
    {
        if (side <= 0)
        {
            throw new Exception($"The Radio: {side}, not is valid.");
        }
        return side;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }


}
