
using System.Collections.Generic;

namespace PocGDP
{
    partial class frmCanvas
    {
        public List<Figura> listafigura = new List<Figura>();
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelSeleccion = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Punto2Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Punto2X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPunto1Y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPunto1X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listaobjetos = new System.Windows.Forms.ListBox();
            this.panelColorFondo = new System.Windows.Forms.Panel();
            this.colorFondo = new System.Windows.Forms.ColorDialog();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelSeleccion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1613, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.listaobjetos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1324, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 707);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelColorFondo);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Punto2Y);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Punto2X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPunto1Y);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPunto1X);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Objeto";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(80, 201);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Color Fondo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(80, 149);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "GrososLinea";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ColorLinea";
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(187, 492);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar Objeto";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listaobjetos
            // 
            this.listaobjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaobjetos.FormattingEnabled = true;
            this.listaobjetos.Location = new System.Drawing.Point(0, 0);
            this.listaobjetos.Name = "listaobjetos";
            this.listaobjetos.Size = new System.Drawing.Size(287, 251);
            this.listaobjetos.TabIndex = 0;
            this.listaobjetos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaobjetos_MouseDown);
            // 
            // panelColorFondo
            // 
            this.panelColorFondo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelColorFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorFondo.Location = new System.Drawing.Point(87, 175);
            this.panelColorFondo.Name = "panelColorFondo";
            this.panelColorFondo.Size = new System.Drawing.Size(31, 19);
            this.panelColorFondo.TabIndex = 16;
            this.panelColorFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColorFondo_Paint);
            this.panelColorFondo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorFondo_MouseClick);
            // 
            // colorFondo
            // 
            this.colorFondo.Color = System.Drawing.Color.White;
            // 
            // frmCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1613, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Name = "frmCanvas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Canvas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCanvas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCanvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCanvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCanvas_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelSeleccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaobjetos;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Punto2Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Punto2X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPunto1Y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPunto1X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelColorFondo;
        private System.Windows.Forms.ColorDialog colorFondo;
    }
}

