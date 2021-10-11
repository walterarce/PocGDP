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
        List<Circulo> DibujoCirculo = new List<Circulo>();
        Linea ln = null;
        Color ColorLinea =Color.Red;
        float AnchoLinea = 1;
        Graphics grp = null;
       
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

      

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            inicial = e.Location;
            ln = new Linea();
        }

   

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Elemento is Linea)
            {
                inicial = e.Location;
                ln = new Linea();
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = e.Location.ToString();
            if (e.Button == MouseButtons.Left)
            {
                grp = CanvasPrincipal.ActiveForm.CreateGraphics();

                if (Elemento is Linea)
                {
                    grp.DrawLine(new Pen(ColorLinea, AnchoLinea), inicial, e.Location);
                    ln.AgregarPunto(e.Location);
                    Dibujo.Add(ln);
                }
                if (Elemento is Circulo)
                {
                    Size mysize = new Size(e.Location.X,e.Location.Y);
                    Rectangle myRectangle = new Rectangle(e.Location, mysize);
                    grp.DrawEllipse(new Pen(ColorLinea, AnchoLinea), myRectangle);
                }
              
                inicial = e.Location;
            }
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
            Elemento = new Circulo(ColorSeleccionado.BackColor,AnchoLinea);
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Elemento = new Cuadrado();
        }



        private void CanvasPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            if (Elemento is Cuadrado)
            {
                Rectangle myRectangle = new Rectangle(e.Location.X, e.Location.Y, 20, 20);
                grp.DrawRectangle(new Pen(ColorLinea, AnchoLinea), myRectangle);
            }
        }
    }
}
