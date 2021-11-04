using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PocGDP
{
    [Serializable]
    public abstract class Figura
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


        public bool FiguraContenida(int x , int y)
        {
            return (x >= punto1.X && x <= punto2.X && y >= punto1.Y && y <= punto2.Y);
        }

    }
}
