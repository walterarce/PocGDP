using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocGDP
{
    public class Cuadrado : Figura
    {
        float x, y;
        float ancho, alto;
        public Cuadrado(float x, float y, float ancho, float alto)
        {
            Nombre = this.GetType().ToString();
            this.x = x;
            this.y = y;
            this.ancho = ancho;
            this.alto = alto;
        }

        public override void Dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
