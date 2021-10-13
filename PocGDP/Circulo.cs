using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class Circulo :  Figura
    {
        public Circulo(Punto punto1, Punto punto2) : base(punto1, punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
        }

        public override void Dibujar(Form f1)
        {
            Graphics grp = f1.CreateGraphics();
            rellenosolido.Color = Color.Red;
            grp.FillEllipse(new SolidBrush(colorRelleno), this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
            grp.DrawEllipse(new Pen(colorContorno, anchoLapicera), this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
            
        }
    }
}
