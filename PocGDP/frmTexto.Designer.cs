
namespace PocGDP
{
    partial class frmTexto
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
            this.texto_insertar = new System.Windows.Forms.RichTextBox();
            this.btnInsertarText = new System.Windows.Forms.Button();
            this.btnFuente = new System.Windows.Forms.Button();
            this.dlgFuente = new System.Windows.Forms.FontDialog();
            this.btnColorTexto = new System.Windows.Forms.Button();
            this.colorTexto = new System.Windows.Forms.ColorDialog();
            this.colorFondo = new System.Windows.Forms.ColorDialog();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_insertar
            // 
            this.texto_insertar.Location = new System.Drawing.Point(12, 12);
            this.texto_insertar.Name = "texto_insertar";
            this.texto_insertar.Size = new System.Drawing.Size(639, 310);
            this.texto_insertar.TabIndex = 0;
            this.texto_insertar.Text = "";
            // 
            // btnInsertarText
            // 
            this.btnInsertarText.Location = new System.Drawing.Point(576, 328);
            this.btnInsertarText.Name = "btnInsertarText";
            this.btnInsertarText.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarText.TabIndex = 1;
            this.btnInsertarText.Text = "Insertar";
            this.btnInsertarText.UseVisualStyleBackColor = true;
            this.btnInsertarText.Click += new System.EventHandler(this.btnInsertarText_Click);
            // 
            // btnFuente
            // 
            this.btnFuente.Location = new System.Drawing.Point(12, 328);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(114, 23);
            this.btnFuente.TabIndex = 2;
            this.btnFuente.Text = "Cambiar Fuente";
            this.btnFuente.UseVisualStyleBackColor = true;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // btnColorTexto
            // 
            this.btnColorTexto.Location = new System.Drawing.Point(132, 328);
            this.btnColorTexto.Name = "btnColorTexto";
            this.btnColorTexto.Size = new System.Drawing.Size(114, 23);
            this.btnColorTexto.TabIndex = 3;
            this.btnColorTexto.Text = "Cambiar Color";
            this.btnColorTexto.UseVisualStyleBackColor = true;
            this.btnColorTexto.Click += new System.EventHandler(this.btnColorTexto_Click);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.Location = new System.Drawing.Point(252, 328);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(132, 23);
            this.btnColorFondo.TabIndex = 4;
            this.btnColorFondo.Text = "Cambiar Color Fondo";
            this.btnColorFondo.UseVisualStyleBackColor = true;
            this.btnColorFondo.Click += new System.EventHandler(this.btnColorFondo_Click);
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 355);
            this.Controls.Add(this.btnColorFondo);
            this.Controls.Add(this.btnColorTexto);
            this.Controls.Add(this.btnFuente);
            this.Controls.Add(this.btnInsertarText);
            this.Controls.Add(this.texto_insertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTexto";
            this.Text = "Insertar Texto...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox texto_insertar;
        private System.Windows.Forms.Button btnInsertarText;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.FontDialog dlgFuente;
        private System.Windows.Forms.Button btnColorTexto;
        private System.Windows.Forms.ColorDialog colorTexto;
        private System.Windows.Forms.ColorDialog colorFondo;
        private System.Windows.Forms.Button btnColorFondo;
    }
}