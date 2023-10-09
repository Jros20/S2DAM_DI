using System.Diagnostics;
using System.Drawing;

namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
 
    protected double _base,_altura;

    public Rectangulo(double newbase ,double altura, Color newcolor)
    {
        _base=newbase;
        _altura=altura;
        _color = newcolor;
    }

    public Color Color { get => _color; set => _color = value; }
    public double Base { get => _base; set => _base = value; }
    public double Altura { get => _altura; set => _altura = value; }

    public override double GetArea()
    {
        return _altura*_base;
    }

    public override string ToString()
    {
        return $"""
            ________________________________
            FIGURA CIRCULO
            -Altura: {_altura}
            -Base:{_base}
            -Color :{_color}
            """;
    }
}
