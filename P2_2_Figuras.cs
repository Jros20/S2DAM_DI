﻿//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    List<Figura> figuras = new List<Figura>();

    Circulo newCirculo = new Circulo(5.9, Color.Azure);
    TrianguloEquilatero newTriangulo = new TrianguloEquilatero(7, Color.Azure);
    Rectangulo newRectangulo = new Rectangulo(5.9, 4.6, Color.Azure);

    newCirculo.ToString();
    newRectangulo.ToString();
    newTriangulo.ToString();

    newRectangulo.Base = 15.0;
    newRectangulo.Altura = 8.0;
    newRectangulo.Color = Color.Green;


    newCirculo.Radio = 7.5;
    newCirculo.Color = Color.Yellow;

    newTriangulo.Lado = 6.0;
    newTriangulo.Color = Color.Blue;

    newCirculo.ToString();
    newRectangulo.ToString();
    newTriangulo.ToString();
  }

}