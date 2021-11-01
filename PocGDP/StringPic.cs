using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class StringPic : Figura, IFigura
    {
        public string Texto { get; set; }
        public string FuenteTexto { get; set; }
        public float SizeTexto { get; set; }

        public StringPic()
        {
            this.colorRelleno = Color.Black;
        }
        public override void Dibujar(PictureBox f1)
        { 
            
            Graphics grp = f1.CreateGraphics();
            var brocha = new SolidBrush(colorRelleno);
            using (Font myFont = new Font(FuenteTexto, SizeTexto))
            {
                grp.DrawString(Texto, myFont, brocha, this.punto1.X,this.punto1.Y);
            }
        }
        public override string ToString()
        {
            return this.GetType().Name; 
        }
    }
}
