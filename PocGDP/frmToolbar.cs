using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmToolbar : Form
    {
        public frmExplorer exploradorObjetos { get; set; }
        List<Figura> figuras = new List<Figura>();
        public List<Form> formularios = new List<Form>();
        public Figura figura = null;
        public ToolbarEstado toolbarEstado = new ToolbarEstado();
        public ToolStripButton btnchecked { get; set; }
        public frmToolbar()
        {
            InitializeComponent();
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
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                var circuloseleccionado = new Circulo();
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.figura = circuloseleccionado;
                }
              ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Dibujando;
            }
               
        }



        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"])!=null)
            {
                var cuadradoseleccionado = new Cuadrado();
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.figura = cuadradoseleccionado;
                }
                 ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Dibujando;
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
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                var lineaseleccionada = new Linea();
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.figura = lineaseleccionada;
                }
              ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Dibujando;
            }
              
        }

        private void btnAddTexto_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                var texto = new StringPic();
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.figura = texto;
                }

                frmTexto textopic = new frmTexto();
                textopic.ShowDialog();
                ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Dibujando;
            }
              else
            {
                MessageBox.Show("Debe tener un area de trabajo Canvas para utilizar herramientas...");
            }


        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
                { 

                    var imagen = new Imagen();
                    foreach (frmCanvas frm in this.OwnedForms)
                    {
                        frm.figura = imagen;
                        ((Imagen)frm.figura).ImagenSelect = new Bitmap(abrirImagen.FileName);
                    }
                  ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Dibujando;
                }
                else
                {
                    MessageBox.Show("Debe tener un area de trabajo Canvas para utilizar herramientas...");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarArchivo.Filter = "BIN(*.BIN)|*.BIN";
            if (DialogResult.OK == guardarArchivo.ShowDialog())
            {
              
                IFormatter formater = new BinaryFormatter();
                var listafiguras = new List<Figura>();
                Stream stream = new FileStream(guardarArchivo.FileName, FileMode.Create);
                foreach (var figura in ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.Items)
                {
                    listafiguras.Add(((Figura)figura));
                    
                }

                formater.Serialize(stream, listafiguras);
                stream.Close();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrirArchivo.Filter = "BIN(*.BIN)|*.BIN";
            if (DialogResult.OK == abrirArchivo.ShowDialog())
            {
                IFormatter formater = new BinaryFormatter();
                Stream stream = new FileStream(abrirArchivo.FileName, FileMode.Open, FileAccess.Read);
                var nuevalistafigura = (List<Figura>)formater.Deserialize(stream);
                if (formularios.Count == 0)
                {
                    frmCanvas frmcanvas = new frmCanvas();
                    frmcanvas.Owner = this;
                    frmcanvas.Text = "New Canvas_" + this.OwnedForms.Length.ToString();
                    formularios.Add(frmcanvas);
                    frmcanvas.Text = abrirArchivo.FileName;
                    frmcanvas.listafigura = nuevalistafigura;

                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = nuevalistafigura;
                   
                    frmcanvas.Show();


                }
                else
                {
                    try
                    {
                        ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura = nuevalistafigura;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura;
                        ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
                
                stream.Close();
 
            }
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Seleccionando;
            }
            
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada = ((Figura)((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.SelectedItem);
                ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Escalando;

            }

        }

        private void btnMover_Click(object sender, EventArgs e)
        {

            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada = ((Figura)((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.SelectedItem);
                ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Moviendo;
            }
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                var ManoAlzada = new Painter();
                foreach (frmCanvas frm in this.OwnedForms)
                {
                    frm.figura = ManoAlzada;
                }
            ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Dibujando;
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
