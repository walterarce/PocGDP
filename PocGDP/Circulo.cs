using System;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    [Serializable]
    public class Circulo :  Figura, IFigura
    {
       
        public Circulo():base()
        {
           
        }
        public Circulo(Punto punto1, Punto punto2) : base(punto1, punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
            
        }

        public override void Dibujar(PictureBox f1)
        {
            Graphics grp = f1.CreateGraphics();
            grp.FillEllipse(new SolidBrush(colorRelleno), this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
            grp.DrawEllipse(new Pen(colorContorno, anchoLapicera), this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
        }

        public override void MoverFigura(PictureBox f1, Punto punto1, Punto punto2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
