using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public class StringPic : Figura, IFigura
    {
        public override void Dibujar(PictureBox f1)
        {
            Graphics grp = f1.CreateGraphics();
            using (Font myFont = new Font("Arial", 14))
            {
                grp.DrawString("Hello .NET Guide!", myFont, Brushes.Green, this.punto1.X,this.punto1.Y);
            }
        }
        public override string ToString()
        {
            return this.GetType().Name; 
        }
    }
}
