﻿using System.Xml.Linq;

namespace Taller2POO;

public abstract class Geometricfigure
{

    protected Geometricfigure(string name)
    {
        Name = name;
    }
   
    public string Name { get; set; } = null!;
    public abstract double GetPerimeter();
    public abstract double GetArea();

    public override string ToString()
    {
        return $"{Name,-13}   => Area.....:  {GetArea(),15:N5}  Perimeter:  {GetPerimeter(),15:N5}";
    }
}
