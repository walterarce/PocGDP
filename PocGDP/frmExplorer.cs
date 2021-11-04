using System;
using System.Drawing;
using System.Windows.Forms;

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

        ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();

        }

        private void listadeobjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Figura)this.listadeobjetos.SelectedItem) != null)
            {
                txtPunto1X.Text = ((Figura)this.listadeobjetos.SelectedItem).punto1.X.ToString();
                txtPunto1Y.Text = ((Figura)this.listadeobjetos.SelectedItem).punto1.Y.ToString();
                Punto2X.Text = ((Figura)this.listadeobjetos.SelectedItem).punto2.X.ToString();
                Punto2Y.Text = ((Figura)this.listadeobjetos.SelectedItem).punto2.Y.ToString();
                panelColorFondo.BackColor = ((Figura)this.listadeobjetos.SelectedItem).colorRelleno;
                colorLinea.BackColor = ((Figura)this.listadeobjetos.SelectedItem).colorContorno;
                anchoLinea.Value = ((Figura)this.listadeobjetos.SelectedItem).anchoLapicera;
                ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada = ((Figura)this.listadeobjetos.SelectedItem);
              //  ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar(((Figura)this.listadeobjetos.SelectedItem));
            }
                
        }


        private void colorLinea_MouseClick(object sender, MouseEventArgs e)
        {
            colorline.ShowDialog();
            colorLinea.BackColor = colorline.Color;
        }
    }
}
