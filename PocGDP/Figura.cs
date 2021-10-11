using System.Drawing;

namespace PocGDP
{
    public class Figura
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


    }
}
