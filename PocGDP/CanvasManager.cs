using System.Collections.Generic;

namespace PocGDP
{
    public class CanvasManager
    {
        public CanvasManager()
        {
            figuras_canvas = new List<Figura>();
        }
        public List<Figura> figuras_canvas { get; set; }
    }
}
