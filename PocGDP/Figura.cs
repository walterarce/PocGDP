using System.Drawing;

namespace PocGDP
{
    public abstract class Figura
    {
        
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private float anchotrazo;

        public float AnchoTrazo
        {
            get { return anchotrazo; }
            set { anchotrazo = value; }
        }

        private Color colortrazo;

        public Color Colortrazo
        {
            get { return colortrazo; }
            set { colortrazo = value; }
        }
        private Pen lapiz;

        public Pen Lapiz
        {
            get { return lapiz; }
            set { lapiz = value; }
        }

        private Brush brocha;

        public Brush Brocha
        {
            get { return brocha; }
            set { brocha = value; }
        }

        public abstract void Dibujar();

    }
}
