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
            txtPunto1X.Text = ((Figura)this.listadeobjetos.SelectedItem).punto1.X.ToString();
            txtPunto1Y.Text = ((Figura)this.listadeobjetos.SelectedItem).punto1.Y.ToString();
            Punto2X.Text = ((Figura)this.listadeobjetos.SelectedItem).punto2.X.ToString();
            Punto2Y.Text = ((Figura)this.listadeobjetos.SelectedItem).punto2.Y.ToString();
            panelColorFondo.BackColor = ((Figura)this.listadeobjetos.SelectedItem).colorRelleno;
            ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada = ((frmCanvas)Application.OpenForms["frmCanvas"]).SeleccionaFigura(((Figura)this.listadeobjetos.SelectedItem).punto1.X, ((Figura)this.listadeobjetos.SelectedItem).punto1.Y);
            if (((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada != null)
            {
                ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada.colorRelleno = Color.Red;

                //foreach (var figura in ((frmCanvas)Application.OpenForms["frmCanvas"]).listafigura)
                //{
                //    if (figura != ((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada)
                //        figura.colorRelleno = Color.White;
                //}
                ((frmCanvas)Application.OpenForms["frmCanvas"]).Redibujar();

            }
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
                //((frmCanvas)Application.OpenForms["frmCanvas"]).figuraSeleccionada = ((frmCanvas)Application.OpenForms["frmCanvas"]).SeleccionaFigura(((Figura)this.listadeobjetos.SelectedItem).punto1.X, ((Figura)this.listadeobjetos.SelectedItem).punto1.Y);

            }
                
        }


        private void colorLinea_MouseClick(object sender, MouseEventArgs e)
        {
            colorline.ShowDialog();
            colorLinea.BackColor = colorline.Color;
        }
    }
}
