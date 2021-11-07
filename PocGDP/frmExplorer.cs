using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace PocGDP
{
    public partial class frmExplorer : Form
    {
        public Figura figura { get; set; }
        public frmExplorer()
        {
            InitializeComponent();
        }

        private void panelColorFondo_MouseClick(object sender, MouseEventArgs e)
        {
            colorFondo.ShowDialog();
            panelColorFondo.BackColor = colorFondo.Color;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (((Figura)this.listadeobjetos.SelectedItem) !=null  && ((frmCanvas)Application.OpenForms["frmCanvas"]) != null)
            {
                ((Figura)this.listadeobjetos.SelectedItem).punto1 = new Punto(Int16.Parse(txtPunto1X.Text), Int16.Parse(txtPunto1Y.Text));
                ((Figura)this.listadeobjetos.SelectedItem).punto2 = new Punto(Int16.Parse(Punto2X.Text), Int16.Parse(Punto2Y.Text));
                ((Figura)this.listadeobjetos.SelectedItem).colorRelleno = panelColorFondo.BackColor;
                ((Figura)this.listadeobjetos.SelectedItem).colorContorno = colorLinea.BackColor;
                ((Figura)this.listadeobjetos.SelectedItem).anchoLapicera = anchoLinea.Value;

                foreach (var figuraencontrada in ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura)
                {
                    if (figuraencontrada == ((Figura)this.listadeobjetos.SelectedItem))
                    {
                        figuraencontrada.punto1 = ((Figura)this.listadeobjetos.SelectedItem).punto1;
                        figuraencontrada.punto2 = ((Figura)this.listadeobjetos.SelectedItem).punto2;
                        figuraencontrada.colorRelleno = ((Figura)this.listadeobjetos.SelectedItem).colorRelleno;
                        figuraencontrada.colorContorno = ((Figura)this.listadeobjetos.SelectedItem).colorContorno;
                        figuraencontrada.anchoLapicera = ((Figura)this.listadeobjetos.SelectedItem).anchoLapicera;
                    }
                }
             ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();
                btnCommit.Visible = false;
                ((frmCanvas)Application.OpenForms["frmCanvas"]).estado_canvas = Estados.Seleccionando;
            }
            
        }

        private void listadeobjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((Figura)this.listadeobjetos.SelectedItem) != null)
                {

                    if (((frmCanvas)Application.OpenForms["frmCanvas"]) == null)
                    {
                        frmCanvas frmcanvas = new frmCanvas();
                        frmcanvas.Owner = this;
                        frmcanvas.Text = "New Canvas_" + this.OwnedForms.Length.ToString();
                        frmcanvas.Owner = ((frmToolbar)Application.OpenForms["frmToolbar"]);
                        ((frmToolbar)Application.OpenForms["frmToolbar"]).formularios.Add(frmcanvas);
                        frmcanvas.Show();

                    }

                    txtPunto1X.Text = ((Figura)this.listadeobjetos.SelectedItem).punto1.X.ToString();
                    txtPunto1Y.Text = ((Figura)this.listadeobjetos.SelectedItem).punto1.Y.ToString();
                    Punto2X.Text = ((Figura)this.listadeobjetos.SelectedItem).punto2.X.ToString();
                    Punto2Y.Text = ((Figura)this.listadeobjetos.SelectedItem).punto2.Y.ToString();
                    panelColorFondo.BackColor = ((Figura)this.listadeobjetos.SelectedItem).colorRelleno;
                    colorLinea.BackColor = ((Figura)this.listadeobjetos.SelectedItem).colorContorno;
                    anchoLinea.Value = ((Figura)this.listadeobjetos.SelectedItem).anchoLapicera;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
        }


        private void colorLinea_MouseClick(object sender, MouseEventArgs e)
        {
            colorline.ShowDialog();
            colorLinea.BackColor = colorline.Color;
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"])!=null)
            ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"])!= null && this.listadeobjetos.Items.Count >0)
            {
                var nuevalistafigura = new List<Figura>();
                nuevalistafigura = ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura;
                nuevalistafigura.Remove(((Figura)this.listadeobjetos.SelectedItem));


                listadeobjetos.DataSource = null;
                listadeobjetos.DataSource = nuevalistafigura;
                ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"])!= null)
            {
                ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar(((Figura)this.listadeobjetos.SelectedItem));
                btnCommit.Visible = true;
            }
           
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null && this.listadeobjetos.Items.Count > 0 && this.listadeobjetos.SelectedIndex < this.listadeobjetos.Items.Count-1)
            {
              
                var nuevalistafigura = new List<Figura>();
                nuevalistafigura.Add(((Figura)this.listadeobjetos.SelectedItem));
                foreach (var item in ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura)
                {
                    if (item != ((Figura)this.listadeobjetos.SelectedItem))
                    nuevalistafigura.Add(item);
                }
                listadeobjetos.DataSource = null;
                listadeobjetos.DataSource = nuevalistafigura;
                ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura = new List<Figura>();
                foreach (Figura item in this.listadeobjetos.Items)
                {
                    if (item != null)
                        ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura.Add(item);
                }
                ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            if (((frmCanvas)Application.OpenForms["frmCanvas"]) != null && this.listadeobjetos.Items.Count > 0 && this.listadeobjetos.SelectedIndex >=0)
            {
                var nuevalistafigura = new List<Figura>();
                
                foreach (var item in ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura)
                {
                    if (item != ((Figura)this.listadeobjetos.SelectedItem))
                        nuevalistafigura.Add(item);
                }
                nuevalistafigura.Add(((Figura)this.listadeobjetos.SelectedItem));
                listadeobjetos.DataSource = null;
                listadeobjetos.DataSource = nuevalistafigura;
                ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura = new List<Figura>();
                foreach (Figura item in this.listadeobjetos.Items)
                {
                    if (item != null)
                    ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura.Add(item);
                }
                ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();

            }
        }
    }
}
