using System.Diagnostics;
using System.Drawing;

namespace P2_2_Figuras;

internal class TrianguloEquilatero : Figura
{
    protected double _lado;

    public TrianguloEquilatero(double lado, Color newcolor)
    {
        _lado = lado;
        _color = newcolor;
    }

    public Color Color { get => _color; set => _color = value; }
    public double Lado { get => _lado; set => _lado = value; }


    public override double GetArea()
    {
        return (Math.Pow(_lado, 2) * Math.Sqrt(3)) / 4;
    }

    public override string ToString()
    {
        return $"""
            ________________________________
            FIGURA TRIANGULO
            -Lado: {_lado}
            -Color :{_color}
            """;
    }
}
