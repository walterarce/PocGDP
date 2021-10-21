using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PocGDP
{
    public partial class CanvasPrincipal : Form
    {
        public string valorchecked { get; set; }
        Point inicial = new Point();
        Object Elemento = null;
        List<Linea> Dibujo = new List<Linea>();
        List<Figura> figuras = new List<Figura>();
        private Figura figuraSeleccionada;
        Figura figura = null;
        Linea ln = null;
        Color ColorLinea =Color.Red;
        float AnchoLinea = 1;
        Graphics grp = null;
        private string estado = "normal";
        private Punto p1_actual;
        frmToolbar formutool = new frmToolbar();
        public CanvasPrincipal()
        {
            InitializeComponent();
        }
        private Figura SeleccionaFigura(int x, int y)
        {
            for (int i = figuras.Count - 1; i >= 0; i--)
            {
                if (figuras[i].FiguraContenida(x, y))
                    return figuras[i];
            }
            return null;
        }

      
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            labelSeleccion.Text = colorDialog1.Color.ToString();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ColorLinea = colorDialog1.Color;

        }


  

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            grp.Clear(Color.White);
            grp.Dispose();
        }


        private void CanvasPrincipal_Paint(object sender, PaintEventArgs e)
        {
            foreach (var figura in figuras)
            {
                figura.Dibujar(this);
            }
            
        }
        private void Redibujar()
        {
            foreach (var figura in figuras)
            {
                figura.Dibujar(this);
            }
        }
        private void CanvasPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (estado == "dibujando")
            {
                p1_actual = new Punto(e.X, e.Y);
            }
            
            else if (estado == "seleccionando")
            {
                SelecciondeObjeto(e);
            }

        }

        private void SelecciondeObjeto(MouseEventArgs e)
        {
            figuraSeleccionada = SeleccionaFigura(e.X, e.Y);
            if (figuraSeleccionada != null)
            {
                figuraSeleccionada.colorRelleno = Color.Red;
                labelSeleccion.Text = figuraSeleccionada.GetType().ToString();
                foreach (var figura in figuras)
                {
                    if (figura != figuraSeleccionada)
                        figura.colorRelleno = Color.White;
                }
                Redibujar();
            }
        }
        private void DeseleccionObjeto()
        {
            if (figuraSeleccionada != null)
            {
                foreach (var figura in figuras)
                {
                    if (figura == figuraSeleccionada)
                        figura.colorRelleno = figuraSeleccionada.colorRelleno;
                }
            }
            Redibujar();
        }

        private void CanvasPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (estado=="dibujando")
            {
                labelSeleccion.Text = String.Format($"x:{e.X}, y:{e.Y}");
                //if (e.Button == MouseButtons.Left)
                //{
                //    grp = CanvasPrincipal.ActiveForm.CreateGraphics();

                //    if (Elemento is Linea)
                //    {
                //        grp.DrawLine(new Pen(ColorLinea, AnchoLinea), inicial, e.Location);
                //        ln.AgregarPunto(e.Location);
                //        Dibujo.Add(ln);
                //    }
 
                //}
            }
            
        }


        private void CanvasPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            labelSeleccion.Text = String.Format($"x:{e.X}, y:{e.Y}");

            foreach (ToolStrip item in this.Owner.Controls)
            {
                foreach (ToolStripButton boton in item.Items)
                {

                    if (boton.Checked && boton.Text == "Circulo")
                    {
                        estado = "dibujando";
                        figura = new Circulo(p1_actual, new Punto(e.X, e.Y));
                    }
                    if (boton.Checked && boton.Name == "btnCuadrado")
                    {
                        estado = "dibujando";
                        figura = new Cuadrado(p1_actual, new Punto(e.X, e.Y));
                    }
                    if (boton.Checked && boton.Name == "btnCirculo")
                    {
                        estado = "seleccionando";
                    }
                }
                
            }

            if (figura != null)
            {
                figura.Dibujar(this);
                figuras.Add(figura);
            }

        }




    }
}
