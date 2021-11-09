
namespace PocGDP
{
    partial class frmExplorer
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
            this.listadeobjetos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.colorLinea = new System.Windows.Forms.Panel();
            this.anchoLinea = new System.Windows.Forms.TrackBar();
            this.btnCommit = new System.Windows.Forms.Button();
            this.panelColorFondo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Punto2Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Punto2X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPunto1Y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPunto1X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorFondo = new System.Windows.Forms.ColorDialog();
            this.colorline = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEnviarAtras = new System.Windows.Forms.ToolStripButton();
            this.btnEnviarAlFrente = new System.Windows.Forms.ToolStripButton();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAnchoLapiceraTitulo = new System.Windows.Forms.Label();
            this.lblAnchoLapicera = new System.Windows.Forms.Label();
            this.lblObjectTypeTitle = new System.Windows.Forms.Label();
            this.lblTipoObjeto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anchoLinea)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadeobjetos
            // 
            this.listadeobjetos.Dock = System.Windows.Forms.DockStyle.Left;
            this.listadeobjetos.FormattingEnabled = true;
            this.listadeobjetos.Location = new System.Drawing.Point(0, 0);
            this.listadeobjetos.Name = "listadeobjetos";
            this.listadeobjetos.Size = new System.Drawing.Size(209, 449);
            this.listadeobjetos.TabIndex = 0;
            this.listadeobjetos.SelectedIndexChanged += new System.EventHandler(this.listadeobjetos_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.listadeobjetos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 449);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.colorLinea);
            this.groupBox1.Controls.Add(this.anchoLinea);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.panelColorFondo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Punto2Y);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Punto2X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPunto1Y);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPunto1X);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(209, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Objeto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(6, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Figura";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(6, 231);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar Figura";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // colorLinea
            // 
            this.colorLinea.BackColor = System.Drawing.Color.Black;
            this.colorLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLinea.Location = new System.Drawing.Point(80, 155);
            this.colorLinea.Name = "colorLinea";
            this.colorLinea.Size = new System.Drawing.Size(31, 19);
            this.colorLinea.TabIndex = 17;
            this.colorLinea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorLinea_MouseClick);
            // 
            // anchoLinea
            // 
            this.anchoLinea.LargeChange = 1;
            this.anchoLinea.Location = new System.Drawing.Point(80, 180);
            this.anchoLinea.Minimum = 1;
            this.anchoLinea.Name = "anchoLinea";
            this.anchoLinea.Size = new System.Drawing.Size(104, 45);
            this.anchoLinea.TabIndex = 0;
            this.anchoLinea.Value = 1;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.Yellow;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Location = new System.Drawing.Point(100, 231);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(97, 23);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "Aplicar Cambios";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Visible = false;
            this.btnCommit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelColorFondo
            // 
            this.panelColorFondo.BackColor = System.Drawing.Color.Black;
            this.panelColorFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorFondo.Location = new System.Drawing.Point(80, 126);
            this.panelColorFondo.Name = "panelColorFondo";
            this.panelColorFondo.Size = new System.Drawing.Size(31, 19);
            this.panelColorFondo.TabIndex = 16;
            this.panelColorFondo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorFondo_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Color Fondo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grosor Linea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color Linea";
            // 
            // Punto2Y
            // 
            this.Punto2Y.Location = new System.Drawing.Point(80, 97);
            this.Punto2Y.Name = "Punto2Y";
            this.Punto2Y.Size = new System.Drawing.Size(100, 20);
            this.Punto2Y.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Punto2Y";
            // 
            // Punto2X
            // 
            this.Punto2X.Location = new System.Drawing.Point(80, 71);
            this.Punto2X.Name = "Punto2X";
            this.Punto2X.Size = new System.Drawing.Size(100, 20);
            this.Punto2X.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punto2X";
            // 
            // txtPunto1Y
            // 
            this.txtPunto1Y.Location = new System.Drawing.Point(80, 45);
            this.txtPunto1Y.Name = "txtPunto1Y";
            this.txtPunto1Y.Size = new System.Drawing.Size(100, 20);
            this.txtPunto1Y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Punto1Y";
            // 
            // txtPunto1X
            // 
            this.txtPunto1X.Location = new System.Drawing.Point(80, 19);
            this.txtPunto1X.Name = "txtPunto1X";
            this.txtPunto1X.Size = new System.Drawing.Size(100, 20);
            this.txtPunto1X.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto1X";
            // 
            // colorFondo
            // 
            this.colorFondo.Color = System.Drawing.Color.White;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEnviarAtras,
            this.btnEnviarAlFrente});
            this.toolStrip1.Location = new System.Drawing.Point(209, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 157);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEnviarAtras
            // 
            this.btnEnviarAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEnviarAtras.Image = global::PocGDP.Properties.Resources.send_to_back;
            this.btnEnviarAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviarAtras.Name = "btnEnviarAtras";
            this.btnEnviarAtras.Size = new System.Drawing.Size(21, 20);
            this.btnEnviarAtras.Text = "Lleva atras de todo la figura seleccionada";
            this.btnEnviarAtras.Click += new System.EventHandler(this.btnEnviarAtras_Click);
            // 
            // btnEnviarAlFrente
            // 
            this.btnEnviarAlFrente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEnviarAlFrente.Image = global::PocGDP.Properties.Resources.send_to_front_button;
            this.btnEnviarAlFrente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviarAlFrente.Name = "btnEnviarAlFrente";
            this.btnEnviarAlFrente.Size = new System.Drawing.Size(21, 20);
            this.btnEnviarAlFrente.Text = "Lleva al frente la figura seleccionada";
            this.btnEnviarAlFrente.Click += new System.EventHandler(this.btnEnviarAlFrente_Click);
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.lblTipoObjeto);
            this.grpBox1.Controls.Add(this.lblObjectTypeTitle);
            this.grpBox1.Controls.Add(this.lblAnchoLapicera);
            this.grpBox1.Controls.Add(this.lblAnchoLapiceraTitulo);
            this.grpBox1.Controls.Add(this.lblNombre);
            this.grpBox1.Controls.Add(this.lblNombreTitulo);
            this.grpBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBox1.Location = new System.Drawing.Point(233, 0);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(200, 157);
            this.grpBox1.TabIndex = 6;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Info Figura";
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(4, 20);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreTitulo.TabIndex = 0;
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(10, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = " ";
            // 
            // lblAnchoLapiceraTitulo
            // 
            this.lblAnchoLapiceraTitulo.AutoSize = true;
            this.lblAnchoLapiceraTitulo.Location = new System.Drawing.Point(4, 33);
            this.lblAnchoLapiceraTitulo.Name = "lblAnchoLapiceraTitulo";
            this.lblAnchoLapiceraTitulo.Size = new System.Drawing.Size(70, 13);
            this.lblAnchoLapiceraTitulo.TabIndex = 2;
            this.lblAnchoLapiceraTitulo.Text = "Grosor Linea:";
            // 
            // lblAnchoLapicera
            // 
            this.lblAnchoLapicera.AutoSize = true;
            this.lblAnchoLapicera.Location = new System.Drawing.Point(73, 33);
            this.lblAnchoLapicera.Name = "lblAnchoLapicera";
            this.lblAnchoLapicera.Size = new System.Drawing.Size(10, 13);
            this.lblAnchoLapicera.TabIndex = 3;
            this.lblAnchoLapicera.Text = " ";
            // 
            // lblObjectTypeTitle
            // 
            this.lblObjectTypeTitle.AutoSize = true;
            this.lblObjectTypeTitle.Location = new System.Drawing.Point(4, 46);
            this.lblObjectTypeTitle.Name = "lblObjectTypeTitle";
            this.lblObjectTypeTitle.Size = new System.Drawing.Size(80, 13);
            this.lblObjectTypeTitle.TabIndex = 4;
            this.lblObjectTypeTitle.Text = "Tipo de Objeto:";
            // 
            // lblTipoObjeto
            // 
            this.lblTipoObjeto.AutoSize = true;
            this.lblTipoObjeto.Location = new System.Drawing.Point(90, 46);
            this.lblTipoObjeto.Name = "lblTipoObjeto";
            this.lblTipoObjeto.Size = new System.Drawing.Size(10, 13);
            this.lblTipoObjeto.TabIndex = 5;
            this.lblTipoObjeto.Text = " ";
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmExplorer";
            this.Load += new System.EventHandler(this.frmExplorer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anchoLinea)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listadeobjetos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelColorFondo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Punto2Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Punto2X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPunto1Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPunto1X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        public System.Windows.Forms.ColorDialog colorFondo;
        public System.Windows.Forms.TrackBar anchoLinea;
        private System.Windows.Forms.Panel colorLinea;
        public System.Windows.Forms.ColorDialog colorline;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEnviarAtras;
        private System.Windows.Forms.ToolStripButton btnEnviarAlFrente;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblAnchoLapicera;
        private System.Windows.Forms.Label lblAnchoLapiceraTitulo;
        private System.Windows.Forms.Label lblObjectTypeTitle;
        private System.Windows.Forms.Label lblTipoObjeto;
    }
}