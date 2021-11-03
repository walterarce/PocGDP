using System;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmTexto : Form
    {
        public frmTexto()
        {
            InitializeComponent();
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            dlgFuente.ShowDialog();
            texto_insertar.Font = dlgFuente.Font;
        }

        private void btnColorTexto_Click(object sender, EventArgs e)
        {
            colorTexto.ShowDialog();
            texto_insertar.ForeColor = colorTexto.Color;
        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            colorFondo.ShowDialog();
            texto_insertar.BackColor = colorFondo.Color;
        }

        private void btnInsertarText_Click(object sender, EventArgs e)
        {
       
            ((StringPic)((frmCanvas)Application.OpenForms["frmCanvas"]).figura).FuenteTexto = dlgFuente.Font.Name;
            ((StringPic)((frmCanvas)Application.OpenForms["frmCanvas"]).figura).Texto = texto_insertar.Text;
            ((StringPic)((frmCanvas)Application.OpenForms["frmCanvas"]).figura).SizeTexto = dlgFuente.Font.Size;
            ((StringPic)((frmCanvas)Application.OpenForms["frmCanvas"]).figura).colorRelleno = colorTexto.Color;
            this.Close();
        }
    }
}
