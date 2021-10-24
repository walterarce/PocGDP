using System.Collections.Generic;

namespace PocGDP
{
    public static class FiguraFactory
    {
       
        public static IFigura FabricarObjeto(string tipoDibujo)
        {
            switch (tipoDibujo)
            {
                case "Cuadrado":
                    return new Cuadrado();
                case "Circulo":
                    return new Circulo();
                default:
                    return new Cuadrado();
            }
        }
    }
}
