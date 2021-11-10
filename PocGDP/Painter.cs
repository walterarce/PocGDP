using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class Painter : Figura, IFigura
    {
        public List<Point> Dibujo { get; set; }
        public Painter()
        {
        
        }
        public override void Dibujar(PictureBox f1)
        {
            Console.WriteLine(f1.ToString());
        }
        public void DibujarBrush(PictureBox f1, Point inicial, MouseEventArgs e)
        {
            Graphics grp = f1.CreateGraphics();
            grp.DrawLine(new Pen(Color.Red), inicial, e.Location);
            this.AgregarPunto(e.Location);
            grp.Dispose();
        }
        List<Point> puntos = new List<Point>();

        public void AgregarPunto(Point pnt)
        {
            puntos.Add(pnt);
        }

        public Point[] ObtenerPuntos()
        {
            return puntos.ToArray();
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
