using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmToolbar : Form
    {
        Point inicial = new Point();
        Object Elemento = null;
        List<Linea> Dibujo = new List<Linea>();
        List<Figura> figuras = new List<Figura>();
        List<Form> formularios = new List<Form>();
        private Figura figuraSeleccionada;
        Figura figura = null;
        Linea ln = null;
        Color ColorLinea = Color.Red;
        float AnchoLinea = 1;
        Graphics grp = null;
        private string estado_fr = "normal";
        private Punto p1_actual;

        public ToolbarEstado toolbarEstado = new ToolbarEstado();
        public ToolStripButton btnchecked { get; set; }
        public frmToolbar()
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
        private void Redibujar()
        {
            foreach (var figura in figuras)
            {
                figura.Dibujar(this);
            }
        }
        private void SelecciondeObjeto(MouseEventArgs e)
        {
            figuraSeleccionada = SeleccionaFigura(e.X, e.Y);
            if (figuraSeleccionada != null)
            {
                figuraSeleccionada.colorRelleno = Color.Red;
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CanvasPrincipal frmcanvas = new CanvasPrincipal();
            frmcanvas.Owner = this;
            frmcanvas.Text = "New Canvas_" + this.OwnedForms.Length.ToString();
            frmcanvas.Owner = this;
            formularios.Add(frmcanvas);
            frmcanvas.Show();
        }

        private void frmToolbar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                foreach (CanvasPrincipal frm in this.OwnedForms)
                {
                    frm.BackColor = Color.Black;
                }
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            DeseleccionObjeto();
            btnCirculo.Checked = true;
            btnCuadrado.Checked = false;
            btnSeleccion.Checked = false;
        }



        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            DeseleccionObjeto();
            btnCirculo.Checked = false;
            btnCuadrado.Checked = true;
            btnSeleccion.Checked = false;
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            btnSeleccion.Checked = true;
            btnCuadrado.Checked = false;
            btnCirculo.Checked = false;
        }

        private void frmToolbar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnColor_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            SeleccionColor.ShowDialog();
        }
    }
    public class ToolbarEstado
     {
        public ToolbarEstado()
        {
            Seleccionado = false;
        }
        public Figura tipo_objeto { get; set; }
        public bool Seleccionado { get; set; }
        public string Estado_Accion { get; set; }
        public string Nombre_Figura { get; set; }
    }
}
