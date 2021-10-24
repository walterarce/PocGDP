using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PocGDP
{
    public partial class frmCanvas : Form
    {
        List<Figura> figuras = new List<Figura>();
        CanvasManager canvasManager = new CanvasManager();
        private Figura figuraSeleccionada;
        private Figura nuevafigura;
        Graphics grp = null;
        private Punto p1_actual;
        public Figura figura { get; set; } 
        public frmCanvas()
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

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            grp.Clear(Color.White);
            grp.Dispose();
        }


        private void frmCanvas_Paint(object sender, PaintEventArgs e)
        {
            Redibujar();

        }
        private void Redibujar()
        {
            foreach (var figura in listafigura)
            {
                figura.Dibujar(this);
            }
        }
        private void frmCanvas_MouseDown(object sender, MouseEventArgs e)
        {
           
            nuevafigura = (Figura)FiguraFactory.FabricarObjeto(figura.ToString());
                p1_actual = new Punto(e.X, e.Y);
            nuevafigura.punto1 = p1_actual;
            //else if (estado == "seleccionando")
            //{
            //    SelecciondeObjeto(e);
            //}

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

        private void frmCanvas_MouseMove(object sender, MouseEventArgs e)
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


        private void frmCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            labelSeleccion.Text = String.Format($"x:{e.X}, y:{e.Y}");

            
            if (figura != null)
            {
                nuevafigura.anchoLapicera = 2;
                nuevafigura.colorContorno = Color.Black;
                nuevafigura.colorRelleno = Color.White;
                nuevafigura.punto2 = new Punto(e.X, e.Y);
                nuevafigura.Dibujar(this);
                nuevafigura.listadefiguras.Add(nuevafigura);
                canvasManager.figuras_canvas.Add(nuevafigura);
                figuras.Add(nuevafigura);
                listafigura.Add(nuevafigura);
                listaobjetos.DataSource = null;
                listaobjetos.DataSource = listafigura;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaobjetos.SelectedItem.ToString());
        }
    }
}
