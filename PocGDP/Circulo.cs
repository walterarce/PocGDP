using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class Circulo :  Figura
    {
        public Circulo(Punto punto1, Punto punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
        }
        public Circulo()
        {

        }
        public override void Dibujar(Form f1)
        {
            Graphics grp = f1.CreateGraphics();
            grp.DrawEllipse(new Pen(Color.Red, 2), this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
        }
    }
}
