using System.Drawing;
using System.Windows.Forms;
namespace PocGDP
{
    public abstract class Figura
    {
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }

        private int ancho;

        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }


        private int alto;

        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }



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



        public abstract void Dibujar(Form f1 , int alto, int ancho);

    }
}
