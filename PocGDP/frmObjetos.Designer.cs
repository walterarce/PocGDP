
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
            this.SuspendLayout();
            // 
            // listadeobjetos
            // 
            this.listadeobjetos.FormattingEnabled = true;
            this.listadeobjetos.Location = new System.Drawing.Point(30, 26);
            this.listadeobjetos.Name = "listadeobjetos";
            this.listadeobjetos.Size = new System.Drawing.Size(209, 199);
            this.listadeobjetos.TabIndex = 0;
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 307);
            this.Controls.Add(this.listadeobjetos);
            this.Name = "frmExplorer";
            this.Text = "frmExplorer";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listadeobjetos;
    }
}