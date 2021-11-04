﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PocGDP
{
    [Serializable]
    public class Cuadrado : Figura,IFigura
    {
        [XmlIgnore]
        public SolidBrush brochaSolida { get; set; } 
        public Cuadrado():base()
        {
       
            brochaSolida =  new SolidBrush(colorRelleno); 
        }
        public Cuadrado(Punto punto1, Punto punto2) : base(punto1, punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
        }
        public override void Dibujar(PictureBox f1)
        {
            Graphics grp = f1.CreateGraphics();
            grp.FillRectangle(brochaSolida, this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
            grp.DrawRectangle(new Pen(colorContorno, anchoLapicera), this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
        }



        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
