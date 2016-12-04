namespace ProyectoFinal_Aplicada1.Consultas
{
    partial class MyViewerArticulos
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
            this.ArticulosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ArticulosreportViewer
            // 
            this.ArticulosreportViewer.Location = new System.Drawing.Point(1, 1);
            this.ArticulosreportViewer.Name = "ArticulosreportViewer";
            this.ArticulosreportViewer.Size = new System.Drawing.Size(732, 431);
            this.ArticulosreportViewer.TabIndex = 1;
            // 
            // MyViewerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 426);
            this.Controls.Add(this.ArticulosreportViewer);
            this.Name = "MyViewerArticulos";
            this.Text = "MyViewerArticulos";
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ArticulosreportViewer;
    }
}