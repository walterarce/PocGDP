using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq.Expressions;
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

        }

        private void listadeobjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((Figura)this.listadeobjetos.SelectedItem) != null)
                {
                    if (((frmCanvas)Application.OpenForms["frmCanvas"])==null)
                    {
                        frmCanvas frmcanvas = new frmCanvas();
                        frmcanvas.Owner = this;
                        frmcanvas.Text = "New Canvas_" + this.OwnedForms.Length.ToString();
                        frmcanvas.Owner = this;
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
                    ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada = ((Figura)this.listadeobjetos.SelectedItem);
                    ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();
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
    }
}
