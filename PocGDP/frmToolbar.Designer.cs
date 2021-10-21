
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
            this.listaimagenes = new System.Windows.Forms.ImageList(this.components);
            this.SeleccionColor = new System.Windows.Forms.ColorDialog();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnColor = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnLinea = new System.Windows.Forms.ToolStripButton();
            this.btnCuadrado = new System.Windows.Forms.ToolStripButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripButton();
            this.btnSeleccion = new System.Windows.Forms.ToolStripButton();
            this.btnAddTexto = new System.Windows.Forms.ToolStripButton();
            this.btnAddImagen = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripButton1,
            this.toolStripButton2,
            this.btnColor,
            this.btnLimpiar,
            this.btnLinea,
            this.btnCuadrado,
            this.btnCirculo,
            this.btnSeleccion,
            this.btnAddTexto,
            this.btnAddImagen,
            this.btnExit});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
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
            // btnNuevo
            // 
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::PocGDP.Properties.Resources.canvas;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.btnNuevo_MouseEnter);
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PocGDP.Properties.Resources.save_file;
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::PocGDP.Properties.Resources.open_file;
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // btnColor
            // 
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColor.Image = global::PocGDP.Properties.Resources.paint_palette;
            this.btnColor.Name = "btnColor";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = global::PocGDP.Properties.Resources.cross;
            this.btnLimpiar.Name = "btnLimpiar";
            // 
            // btnLinea
            // 
            resources.ApplyResources(this.btnLinea, "btnLinea");
            this.btnLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinea.Name = "btnLinea";
            // 
            // btnCuadrado
            // 
            resources.ApplyResources(this.btnCuadrado, "btnCuadrado");
            this.btnCuadrado.CheckOnClick = true;
            this.btnCuadrado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCuadrado.Image = global::PocGDP.Properties.Resources.cuadrado;
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            resources.ApplyResources(this.btnCirculo, "btnCirculo");
            this.btnCirculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCirculo.CheckOnClick = true;
            this.btnCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCirculo.Image = global::PocGDP.Properties.Resources.contorno_del_circulo;
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnSeleccion
            // 
            resources.ApplyResources(this.btnSeleccion, "btnSeleccion");
            this.btnSeleccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSeleccion.Image = global::PocGDP.Properties.Resources.seleccione;
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnAddTexto
            // 
            resources.ApplyResources(this.btnAddTexto, "btnAddTexto");
            this.btnAddTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTexto.Image = global::PocGDP.Properties.Resources.text_document_add_button_with_plus_sign;
            this.btnAddTexto.Name = "btnAddTexto";
            // 
            // btnAddImagen
            // 
            resources.ApplyResources(this.btnAddImagen, "btnAddImagen");
            this.btnAddImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddImagen.Image = global::PocGDP.Properties.Resources.add_image;
            this.btnAddImagen.Name = "btnAddImagen";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::PocGDP.Properties.Resources.logout;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
        private System.Windows.Forms.ToolStripButton btnColor;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnLinea;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        public System.Windows.Forms.ToolStripButton btnCuadrado;
        public System.Windows.Forms.ToolStripButton btnSeleccion;
        public System.Windows.Forms.ToolStripButton btnCirculo;
        private System.Windows.Forms.ImageList listaimagenes;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ColorDialog SeleccionColor;
        private System.Windows.Forms.ToolStripButton btnAddTexto;
        private System.Windows.Forms.ToolStripButton btnAddImagen;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}