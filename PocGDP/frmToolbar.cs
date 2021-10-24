using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmToolbar : Form
    {
        private frmObjetos ventanadeobjetos;
        List<Figura> figuras = new List<Figura>();
        List<Form> formularios = new List<Form>();
        public Figura figura = null;

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
       
       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCanvas frmcanvas = new frmCanvas();
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
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.BackColor = Color.Black;
                }
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            
            var circuloseleccionado= new Circulo();
            foreach (frmCanvas frm in this.OwnedForms)
            {
                frm.figura = circuloseleccionado;
            }
        }



        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            var cuadradoseleccionado = new Cuadrado();
            foreach (frmCanvas frm in this.OwnedForms)
            {
                frm.figura = cuadradoseleccionado;
            }
        
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            btnSeleccion.Checked = true;
            btnCuadrado.Checked = false;
            btnCirculo.Checked = false;
        }

        private void frmToolbar_Load(object sender, EventArgs e)
        {
            //frmlateraltools = new frmLateralTools();
            //frmlateraltools.Owner = this;
            //formularios.Add(frmlateraltools);
            //frmlateraltools.Show();
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            SeleccionColor.ShowDialog();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            //bool estaAbierto = frmObjetos.detectarFormularioAbierto("ventanadeobjetos");
            //if (!estaAbierto)
            //{
            //    frmObjetos ventanadeobjetos = new frmObjetos();
            //    ventanadeobjetos.Owner = this;
            //    formularios.Add(ventanadeobjetos);
            //    ventanadeobjetos.Show();
            //}
            
        }
        public static bool detectarFormularioAbierto(string formulario)
        {
            bool abierto = false;

            if (Application.OpenForms[formulario] != null)
            {
                abierto = true;
            }
            return abierto;
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            frmObjetos ventanadeobjetos = new frmObjetos();
            ventanadeobjetos.Owner = this;
            formularios.Add(ventanadeobjetos);
            ventanadeobjetos.Show();
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
