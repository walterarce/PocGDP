using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmToolbar : Form
    {
        public frmExplorer exploradorObjetos { get; set; }
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
       
       
       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCanvas frmcanvas = new frmCanvas();
            frmcanvas.Owner = this;
            frmcanvas.Text = "New Canvas_" + this.OwnedForms.Length.ToString();
            frmcanvas.Owner = this;
            exploradorObjetos = new frmExplorer();
          
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
           
            btnCuadrado.Checked = false;
            btnCirculo.Checked = false;
        }

        private void frmToolbar_Load(object sender, EventArgs e)
        {
            exploradorObjetos = new frmExplorer();
            exploradorObjetos.Show();
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
            frmExplorer ventanadeobjetos = new frmExplorer();
            ventanadeobjetos.Owner = this;
            ventanadeobjetos.Name = "ventanaobjetos";
            formularios.Add(ventanadeobjetos);
            ventanadeobjetos.Show();
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            var lineaseleccionada = new Linea();
            foreach (frmCanvas frm in this.OwnedForms)
            {
                frm.figura = lineaseleccionada;
            }
        }

        private void btnAddTexto_Click(object sender, EventArgs e)
        {
            var texto = new StringPic();
            foreach (frmCanvas frm in this.OwnedForms)
            {
                frm.figura = texto;
            }

            frmTexto textopic = new frmTexto();
            textopic.ShowDialog();



        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                //((frmCanvas)Application.OpenForms["frmCanvas"]).canvas.Image = new Bitmap(abrirImagen.FileName);
                var imagen = new Imagen();
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.figura = imagen;
                    ((Imagen)frm.figura).ImagenSelect = new Bitmap(abrirImagen.FileName);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarArchivo.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            if (DialogResult.OK == guardarArchivo.ShowDialog())
            {
              
                BinaryFormatter formater = new BinaryFormatter();
                var listafiguras = new List<Figura>();
                Stream stream = new FileStream(guardarArchivo.FileName, FileMode.Append);
                foreach (var figura in ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.Items)
                {
                    listafiguras.Add(((Figura)figura));
                    formater.Serialize(stream, ((Figura)figura));
                }

                
                stream.Close();
            }
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
