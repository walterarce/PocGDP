using System;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    [Serializable]
    public class Imagen : Figura, IFigura
    {
        public Image ImagenSelect { get; set; }
        public override void Dibujar(PictureBox f1)
        {
            Graphics grp = f1.CreateGraphics();
            
            grp.DrawImage(ImagenSelect, this.punto1.X, this.punto1.Y, this.punto2.X - this.punto1.X, this.punto2.Y - this.punto1.Y);
        }


        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
