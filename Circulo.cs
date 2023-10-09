using System.Diagnostics;
using System.Drawing;

namespace P2_2_Figuras;

internal class Circulo : Figura
{
    private Color color;
    protected double _radio;

    public Circulo(double radio, Color newcolor)
    {
        _radio = radio;
        color = newcolor;
    }

    public Color Color { get => color; set => color = value; }
    public double Radio { get => _radio; set => _radio = value; }

    public override double Area => Math.PI * Math.Pow(_radio, 2);

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
