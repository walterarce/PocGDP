using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class Painter : Figura, IFigura
    {
        public List<Point> PointsCollection { get; set; }
        public Point inicial { get; set; }
        public Painter()
        {
            PointsCollection = new List<Point>();
        }
        public override void Dibujar(PictureBox f1)
        {
            Graphics grp = f1.CreateGraphics();
            foreach (var item in PointsCollection)
            {
                grp.DrawLine(new Pen(colorContorno), inicial, new Point(this.punto2.X, this.punto2.Y));
            }
           

            grp.Dispose();
        }
       
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
