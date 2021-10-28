using System;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmCanvas : Form
    {
        public Figura figuraSeleccionada;
        private Figura nuevafigura;
        Graphics grp = null;
        private Punto p1_actual;
        public Figura figura { get; set; } 
        public frmCanvas()
        {
            InitializeComponent();
        }
        public Figura SeleccionaFigura(int x, int y)
        {
            for (int i = listafigura.Count - 1; i >= 0; i--)
            {
                if (listafigura[i].FiguraContenida(x, y))
                    return listafigura[i];
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
        public void Redibujar()
        {
            foreach (var figura in listafigura)
            {
                figura.Dibujar(this);
            }
        }
        private void frmCanvas_MouseDown(object sender, MouseEventArgs e)
        {
           if (figura != null)
            {
                //aca fabrico el objeto que seleccione, y aplico un nombre con su codigo hash de objeto, 
                // asimismo le asigno el punto de la punta izquierda superior
                nuevafigura = (Figura)FiguraFactory.FabricarObjeto(figura.ToString());
                nuevafigura.NombreFigura = nuevafigura.GetType().Name + nuevafigura.GetHashCode();
                p1_actual = new Punto(e.X, e.Y);
                nuevafigura.punto1 = p1_actual;
            }
            
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
                foreach (var figura in listafigura)
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
                foreach (var figura in listafigura)
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
            // cuando libero soltando el mouse, le doy el resto de las propiedades al objeto
            // como ser colores de linea y fondo, y ancho , tambien genero un nuevo punto para la esquina inferior derecha
            // lo dibujo en this, es decir en el form que es lo que el metodo espera en la implementacion de cada objeto
            // me lo llevo a una coleccion y asigno la coleccion a la lista visual
            
            if (figura != null)
            {
                nuevafigura.anchoLapicera = 2;
                nuevafigura.colorContorno = Color.Black;
                nuevafigura.colorRelleno = ((frmExplorer)Application.OpenForms["frmExplorer"]).colorFondo.Color;
                nuevafigura.punto2 = new Punto(e.X, e.Y);
                nuevafigura.Dibujar(this);
                listafigura.Add(nuevafigura);
                if (Application.OpenForms["frmExplorer"] !=null)
                {
                    ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                    ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                    
                }
                
                
            }
           
        }
    }
}
