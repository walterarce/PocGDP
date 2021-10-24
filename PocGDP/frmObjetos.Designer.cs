
namespace PocGDP
{
    partial class frmObjetos
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
            this.listadefiguras = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listadefiguras
            // 
            this.listadefiguras.HideSelection = false;
            this.listadefiguras.Location = new System.Drawing.Point(12, 29);
            this.listadefiguras.Name = "listadefiguras";
            this.listadefiguras.Size = new System.Drawing.Size(317, 234);
            this.listadefiguras.TabIndex = 0;
            this.listadefiguras.UseCompatibleStateImageBehavior = false;
            // 
            // frmObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 275);
            this.Controls.Add(this.listadefiguras);
            this.Name = "frmObjetos";
            this.Text = "frmObjetos";
            this.Load += new System.EventHandler(this.frmObjetos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listadefiguras;
    }
}