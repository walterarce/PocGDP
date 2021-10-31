
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelColorFondo = new System.Windows.Forms.Panel();
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
            this.colorFondo = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadeobjetos
            // 
            this.listadeobjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.listadeobjetos.FormattingEnabled = true;
            this.listadeobjetos.ItemHeight = 20;
            this.listadeobjetos.Location = new System.Drawing.Point(0, 0);
            this.listadeobjetos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listadeobjetos.Name = "listadeobjetos";
            this.listadeobjetos.Size = new System.Drawing.Size(313, 304);
            this.listadeobjetos.TabIndex = 0;
            this.listadeobjetos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listadeobjetos_DrawItem);
            this.listadeobjetos.SelectedIndexChanged += new System.EventHandler(this.listadeobjetos_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.listadeobjetos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 691);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.panelColorFondo);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(313, 460);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Objeto";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(130, 320);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar Objeto";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelColorFondo
            // 
            this.panelColorFondo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelColorFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorFondo.Location = new System.Drawing.Point(130, 269);
            this.panelColorFondo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelColorFondo.Name = "panelColorFondo";
            this.panelColorFondo.Size = new System.Drawing.Size(46, 28);
            this.panelColorFondo.TabIndex = 16;
            this.panelColorFondo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorFondo_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Color Fondo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 229);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 26);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grosor Linea";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 189);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 26);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color Linea";
            // 
            // Punto2Y
            // 
            this.Punto2Y.Location = new System.Drawing.Point(120, 149);
            this.Punto2Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Punto2Y.Name = "Punto2Y";
            this.Punto2Y.Size = new System.Drawing.Size(148, 26);
            this.Punto2Y.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Punto2Y";
            // 
            // Punto2X
            // 
            this.Punto2X.Location = new System.Drawing.Point(120, 109);
            this.Punto2X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Punto2X.Name = "Punto2X";
            this.Punto2X.Size = new System.Drawing.Size(148, 26);
            this.Punto2X.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punto2X";
            // 
            // txtPunto1Y
            // 
            this.txtPunto1Y.Location = new System.Drawing.Point(120, 69);
            this.txtPunto1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPunto1Y.Name = "txtPunto1Y";
            this.txtPunto1Y.Size = new System.Drawing.Size(148, 26);
            this.txtPunto1Y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Punto1Y";
            // 
            // txtPunto1X
            // 
            this.txtPunto1X.Location = new System.Drawing.Point(120, 29);
            this.txtPunto1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPunto1X.Name = "txtPunto1X";
            this.txtPunto1X.Size = new System.Drawing.Size(148, 26);
            this.txtPunto1X.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto1X";
            // 
            // colorFondo
            // 
            this.colorFondo.Color = System.Drawing.Color.White;
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 715);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExplorer";
            this.Text = "frmExplorer";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listadeobjetos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelColorFondo;
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
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.ColorDialog colorFondo;
    }
}