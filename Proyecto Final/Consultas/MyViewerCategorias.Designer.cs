namespace ProyectoFinal_Aplicada1.Consultas
{
    partial class MyViewerCategorias
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
            this.CategoriareportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // CategoriareportViewer
            // 
            this.CategoriareportViewer.Location = new System.Drawing.Point(1, 0);
            this.CategoriareportViewer.Name = "CategoriareportViewer";
            this.CategoriareportViewer.Size = new System.Drawing.Size(424, 275);
            this.CategoriareportViewer.TabIndex = 1;
            // 
            // MyViewerCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 271);
            this.Controls.Add(this.CategoriareportViewer);
            this.Name = "MyViewerCategorias";
            this.Text = "MyViewerCategorias";
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer CategoriareportViewer;
    }
}