using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PocGDP
{
    public partial class CanvasPrincipal : Form
    {
        Point inicial = new Point();
        Object Elemento = null;
        List<Linea> Dibujo = new List<Linea>();
        List<Figura> figuras = new List<Figura>();
        Linea ln = null;
        Color ColorLinea =Color.Red;
        float AnchoLinea = 1;
        Graphics grp = null;
        private string estado = "normal";
        private Punto p1_actual;
        public CanvasPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorSeleccionado.BackColor = ColorLinea;
           
        }
      
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            toolStripStatusLabel1.Text = colorDialog1.Color.ToString();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            botonMaximizar.Visible = true;
        }

        private void botonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            botonMaximizar.Visible = true;
            botonMinimizar.Visible = true;
            btnRestaurar.Visible = false;
        }



        private void btnPintar_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ColorLinea = colorDialog1.Color;
            ColorSeleccionado.BackColor = ColorLinea;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ColorLinea = colorDialog1.Color;
            ColorSeleccionado.BackColor = ColorLinea;
        }

        private void Ancho1_Click(object sender, EventArgs e)
        {
            AnchoLinea = 2.5f;
        }

        private void Ancho2_Click(object sender, EventArgs e)
        {
            AnchoLinea = 4.5f;
        }

        private void Ancho3_Click(object sender, EventArgs e)
        {
            AnchoLinea = 6.5f;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            grp.Clear(Color.White);
            grp.Dispose();
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            Elemento = new Linea();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Elemento = new Circulo();
        }



        private void CanvasPrincipal_Paint(object sender, PaintEventArgs e)
        {
            foreach (var figura in figuras)
            {
                figura.Dibujar(this);
            }
            
        }

        private void CanvasPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            estado = "dibujando";
            p1_actual = new Punto(e.X,e.Y);

            if (Elemento is Linea)
            {
                inicial = e.Location;
                ln = new Linea();
            }
        }

        private void CanvasPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (estado=="dibujando")
            {
                toolStripStatusLabel1.Text = String.Format($"x:{e.X}, y:{e.Y}");
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
            toolStripStatusLabel1.Text = String.Format($"x:{e.X}, y:{e.Y}");
            if (Elemento is Cuadrado && estado == "dibujando")
            {
                Cuadrado cuadrado = new Cuadrado(p1_actual, new Punto(e.X, e.Y));
                cuadrado.Dibujar(this);
                figuras.Add(cuadrado);
                estado = "normal";
            }
            if (Elemento is Circulo && estado == "dibujando")
            {
                Circulo circulo = new Circulo(p1_actual, new Punto(e.X, e.Y));
                circulo.Dibujar(this);
                figuras.Add(circulo);
                estado = "normal";
            }

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Elemento = new  Cuadrado();
        }
    }
}
