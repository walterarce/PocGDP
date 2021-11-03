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
                case "Linea":
                    return new Linea();
                case "StringPic":
                    return new StringPic();
                case "Imagen":
                    return new Imagen();
                default:
                    return new Cuadrado();
            }
        }
    }
}
