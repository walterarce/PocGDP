
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
            this.listaobjetos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listaobjetos
            // 
            this.listaobjetos.HideSelection = false;
            this.listaobjetos.Location = new System.Drawing.Point(12, 29);
            this.listaobjetos.Name = "listaobjetos";
            this.listaobjetos.Size = new System.Drawing.Size(317, 234);
            this.listaobjetos.TabIndex = 0;
            this.listaobjetos.UseCompatibleStateImageBehavior = false;
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 307);
            this.Controls.Add(this.listaobjetos);
            this.Name = "frmExplorer";
            this.Text = "frmExplorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaobjetos;
    }
}