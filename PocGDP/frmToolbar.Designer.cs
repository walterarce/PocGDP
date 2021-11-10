
namespace PocGDP
{
    partial class frmToolbar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolbar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLinea = new System.Windows.Forms.ToolStripButton();
            this.btnCuadrado = new System.Windows.Forms.ToolStripButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripButton();
            this.btnAddTexto = new System.Windows.Forms.ToolStripButton();
            this.btnAddImagen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEscalar = new System.Windows.Forms.ToolStripButton();
            this.btnMover = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.listaimagenes = new System.Windows.Forms.ImageList(this.components);
            this.SeleccionColor = new System.Windows.Forms.ColorDialog();
            this.guardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.guardaImagen = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnAbrir,
            this.toolStripSeparator1,
            this.btnLinea,
            this.btnCuadrado,
            this.btnCirculo,
            this.btnAddTexto,
            this.btnAddImagen,
            this.toolStripSeparator2,
            this.btnEscalar,
            this.btnMover,
            this.toolStripSeparator3,
            this.btnExit});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnNuevo
            // 
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PocGDP.Properties.Resources.nuevo;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::PocGDP.Properties.Resources.save_file;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            resources.ApplyResources(this.btnAbrir, "btnAbrir");
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = global::PocGDP.Properties.Resources.open_file;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnLinea
            // 
            resources.ApplyResources(this.btnLinea, "btnLinea");
            this.btnLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinea.Image = global::PocGDP.Properties.Resources.line_segemnt;
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCuadrado
            // 
            resources.ApplyResources(this.btnCuadrado, "btnCuadrado");
            this.btnCuadrado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCuadrado.Image = global::PocGDP.Properties.Resources.cuadrado;
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            resources.ApplyResources(this.btnCirculo, "btnCirculo");
            this.btnCirculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCirculo.Image = global::PocGDP.Properties.Resources.contorno_del_circulo;
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnAddTexto
            // 
            resources.ApplyResources(this.btnAddTexto, "btnAddTexto");
            this.btnAddTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTexto.Image = global::PocGDP.Properties.Resources.text_document_add_button_with_plus_sign;
            this.btnAddTexto.Name = "btnAddTexto";
            this.btnAddTexto.Click += new System.EventHandler(this.btnAddTexto_Click);
            // 
            // btnAddImagen
            // 
            resources.ApplyResources(this.btnAddImagen, "btnAddImagen");
            this.btnAddImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddImagen.Image = global::PocGDP.Properties.Resources.add_image;
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Click += new System.EventHandler(this.btnAddImagen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnEscalar
            // 
            this.btnEscalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEscalar.Image = global::PocGDP.Properties.Resources.resize;
            resources.ApplyResources(this.btnEscalar, "btnEscalar");
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // btnMover
            // 
            this.btnMover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMover.Image = global::PocGDP.Properties.Resources.move;
            resources.ApplyResources(this.btnMover, "btnMover");
            this.btnMover.Name = "btnMover";
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::PocGDP.Properties.Resources.logout;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listaimagenes
            // 
            this.listaimagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaimagenes.ImageStream")));
            this.listaimagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaimagenes.Images.SetKeyName(0, "archivonuevo");
            this.listaimagenes.Images.SetKeyName(1, "cambiar-el-tamano.png");
            this.listaimagenes.Images.SetKeyName(2, "formato-de-archivo-psd.png");
            this.listaimagenes.Images.SetKeyName(3, "lapicera.png");
            this.listaimagenes.Images.SetKeyName(4, "lata-de-aerosol.png");
            this.listaimagenes.Images.SetKeyName(5, "moverse.png");
            this.listaimagenes.Images.SetKeyName(6, "paleta-de-color.png");
            this.listaimagenes.Images.SetKeyName(7, "retrato.png");
            this.listaimagenes.Images.SetKeyName(8, "seleccione.png");
            this.listaimagenes.Images.SetKeyName(9, "tipografia.png");
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.FileName = "openFileDialog1";
            // 
            // frmToolbar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmToolbar";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmToolbar_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmToolbar_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLinea;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        public System.Windows.Forms.ToolStripButton btnCirculo;
        private System.Windows.Forms.ImageList listaimagenes;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ColorDialog SeleccionColor;
        private System.Windows.Forms.ToolStripButton btnAddTexto;
        private System.Windows.Forms.ToolStripButton btnAddImagen;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnCuadrado;
        private System.Windows.Forms.SaveFileDialog guardarArchivo;
        private System.Windows.Forms.OpenFileDialog abrirArchivo;
        private System.Windows.Forms.ToolStripButton btnEscalar;
        private System.Windows.Forms.SaveFileDialog guardaImagen;
        private System.Windows.Forms.ToolStripButton btnMover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}