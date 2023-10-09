//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {


    Circulo newCirculo = new Circulo(5.9, Color.Azure);
    TrianguloEquilatero newTriangulo = new TrianguloEquilatero(7, Color.Azure);
    Rectangulo newRectangulo = new Rectangulo(5.9, 4.6, Color.Azure);

    Console.WriteLine(newCirculo.ToString());
    Console.WriteLine(newRectangulo.ToString());
    Console.WriteLine(newTriangulo.ToString());

    newRectangulo.Base = 15.0;
    newRectangulo.Altura = 8.0;
    newRectangulo.Color = Color.Green;


    newCirculo.Radio = 7.5;
    newCirculo.Color = Color.Yellow;

    newTriangulo.Lado = 6.0;
    newTriangulo.Color = Color.Blue;

    Console.WriteLine(newCirculo.ToString());
    Console.WriteLine(newRectangulo.ToString());
    Console.WriteLine(newTriangulo.ToString());

    List<Figura> lista_figuras = new List<Figura>();

    Circulo circulo = new Circulo(5.0, Color.FromArgb(12, 34, 12, 12));
    Rectangulo rectangulo = new Rectangulo(8.0, 4.0, Color.FromArgb(12, 56, 78, 35));
    TrianguloEquilatero triangulo = new TrianguloEquilatero(6.0, Color.FromArgb(78, 35, 12, 12));
    Circulo otroCirculo = new Circulo(3.0, Color.FromArgb(12, 56, 12, 56));
    Rectangulo otroRectangulo = new Rectangulo(10.0, 2.0, Color.FromArgb(12, 34, 12, 12));
    TrianguloEquilatero otroTriangulo = new TrianguloEquilatero(4.0, Color.FromArgb(56, 34, 78, 56));

  }

}