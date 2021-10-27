using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PocGDP
{
    public partial class frmCanvas : Form
    {
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
        private void Redibujar()
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

            
            if (figura != null)
            {
                nuevafigura.anchoLapicera = 2;
                nuevafigura.colorContorno = Color.Black;
                nuevafigura.colorRelleno = Color.White;
                nuevafigura.punto2 = new Punto(e.X, e.Y);
                nuevafigura.Dibujar(this);
                listafigura.Add(nuevafigura);
                listaobjetos.DataSource = null;
                listaobjetos.DataSource = listafigura;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        { 
            txtPunto1X.Text = ((Figura)listaobjetos.SelectedItem).punto1.X.ToString();
            txtPunto1Y.Text = ((Figura)listaobjetos.SelectedItem).punto1.Y.ToString();
            panelColorFondo.BackColor = ((Figura)listaobjetos.SelectedItem).colorRelleno;
            figuraSeleccionada = SeleccionaFigura(((Figura)listaobjetos.SelectedItem).punto1.X, ((Figura)listaobjetos.SelectedItem).punto1.Y);
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

        private void listaobjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Figura)listaobjetos.SelectedItem) !=null)
               MessageBox.Show(((Figura)listaobjetos.SelectedItem).NombreFigura);
        }

        private void panelColorFondo_MouseClick(object sender, MouseEventArgs e)
        {
            colorFondo.ShowDialog();
            panelColorFondo.BackColor =  colorFondo.Color;
        }

        private void frmCanvas_Load(object sender, EventArgs e)
        {
            frmToolbar.ActiveForm.Activate();
        }
    }
}
