using System.Diagnostics;
using System.Drawing;

namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
    private Color color;
    protected double _base,_altura;

    public Rectangulo(double newbase ,double altura, Color newcolor)
    {
        _base=newbase;
        _altura=altura;
        color = newcolor;
    }

    public Color Color { get => color; set => color = value; }
    public double Radio { get => _radio; set => _radio = value; }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radio, 2);
    }

    public override string ToString()
    {
        return $"""
            ________________________________
            FIGURA CIRCULO
            -Radio: {_radio}
            -Color :{color}
            """;
    }
}
