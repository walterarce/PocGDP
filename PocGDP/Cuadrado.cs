using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocGDP
{
    public class Cuadrado : Figura
    {
        public Cuadrado()
        {
            Nombre = this.GetType().ToString();
        }
    }
}
