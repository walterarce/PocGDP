using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace PocGDP
{
    public abstract class Figura
    {
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public SolidBrush rellenosolido { get; set; }
        public int anchoLapicera { get; set; }
        public Color colorRelleno { get; set; }
        public Color colorContorno { get; set; }
        public string NombreFigura { get; set; }
        public Figura()
        {
            this.rellenosolido = new SolidBrush(colorRelleno);
        }

        public Figura(Punto punto1, Punto punto2)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
            this.colorContorno = Color.Black;
            this.colorRelleno = Color.White;
            this.rellenosolido = new SolidBrush(colorRelleno);
        }
        public Figura(Punto punto1, Punto punto2, Color colorcontorno)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
            this.colorContorno = colorcontorno;
            this.colorRelleno = Color.White;
            this.rellenosolido = new SolidBrush(colorRelleno);
        }
        public Figura(Punto punto1, Punto punto2, Color colorcontorno, Color colorrelleno)
        {
            this.punto1 = punto1;
            this.punto2 = punto2;
            this.colorContorno = colorcontorno;
            this.colorRelleno = colorrelleno;
        }

        public abstract void Dibujar(Form f1);

        public bool FiguraContenida(int x , int y)
        {
            return (x >= punto1.X && x <= punto2.X && y >= punto1.Y && y <= punto2.Y);
        }

    }
}
