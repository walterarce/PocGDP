﻿using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class Cuadrado: Figura
    {   

        public Cuadrado(Punto punto1, Punto punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
        }
        public Cuadrado()
        {

        }

        public override void Dibujar(Form f1)
        {
            Graphics grp = f1.CreateGraphics();
            grp.DrawRectangle(new Pen(Color.Red, 2), this.punto1.X, this.punto1.Y,this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
        }
    }
}
