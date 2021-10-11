using System.Collections.Generic;
using System.Drawing;

namespace PocGDP
{
    public class Linea
    {
        List<Point> puntos = new List<Point>();

        //setter
        public void AgregarPunto(Point pnt)
        {
            puntos.Add(pnt);
        }

        //getter
        public Point[] ObtenerPuntos()
        {
            return puntos.ToArray();
        }
    }
}
