using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PocGDP
{
    [Serializable]
    public abstract class Figura : ICloneable
    {
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public int anchoLapicera { get; set; }
        public Color colorRelleno { get; set; }
        public Color colorContorno { get; set; }
        public string NombreFigura { get; set; }

        public Figura()
        {
          
        }

        public Figura(Punto punto1, Punto punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
        }



        public abstract void Dibujar(PictureBox f1);

        public abstract void MoverFigura(PictureBox f1, Punto punto1, Punto punto2);


        public bool FiguraContenida(Punto punto1 , Punto punto2)
        {
            return (punto1.X >= punto1.X && punto2.X <= punto2.X && punto1.Y >= punto1.Y && punto2.Y <= punto2.Y);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
