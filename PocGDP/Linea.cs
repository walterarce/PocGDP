using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class Linea : Figura
    {
        public Linea(Punto punto1, Punto punto2) : base(punto1, punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
        }
        List<Point> puntos = new List<Point>();

        //setter
        public void AgregarPunto(Point pnt)
        {
            puntos.Add(pnt);
        }

        public override void Dibujar(Form f1)
        {
            Graphics grp = f1.CreateGraphics();
            //grp.DrawLine(new Pen(colorContorno, anchoLapicera), this.punto1.X, this.punto1.Y,this.punto2.X,this.punto2.Y);
            Point point1 = new Point();
            point1.X = punto1.X;
            point1.Y = punto1.Y;
            Point point2 = new Point();
            point2.X = punto2.X- punto1.X;
            point2.Y = punto2.Y - punto1.Y;
            grp.DrawLine(new Pen(colorContorno, anchoLapicera), point1, point2);
            grp.Dispose();
        }

        //getter
        public Point[] ObtenerPuntos()
        {
            return puntos.ToArray();
        }
    }
}
