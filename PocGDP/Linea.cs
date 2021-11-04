using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    [Serializable]
    public class Linea : Figura, IFigura
    {
        public Linea() : base()
        {

        }
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

        public override void Dibujar(PictureBox f1)
        {
            Graphics grp = f1.CreateGraphics();
            Point point1 = new Point();
            point1.X = punto1.X;
            point1.Y = punto1.Y;
            Point point2 = new Point();
            point2.X = punto2.X- punto1.X;
            point2.Y = punto2.Y - punto1.Y;
            grp.DrawLine(new Pen(colorContorno, anchoLapicera), this.punto1.X, this.punto1.Y, this.punto2.X, this.punto2.Y);
            grp.Dispose();
        }

        public Point[] ObtenerPuntos()
        {
            return puntos.ToArray();
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public override void MoverFigura(PictureBox f1, Punto punto1, Punto punto2)
        {
            throw new NotImplementedException();
        }
    }
}
