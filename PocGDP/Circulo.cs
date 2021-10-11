using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocGDP
{
    public class Circulo :  Figura
    {
        public Circulo(Color colortrazo, float anchotrazo)
        {
            Nombre = this.GetType().ToString();
            Colortrazo = colortrazo;
            AnchoTrazo = anchotrazo;
        }
    }
}
