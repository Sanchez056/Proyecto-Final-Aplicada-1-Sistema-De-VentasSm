namespace ProyectoFinal_Aplicada1.Consultas
{
    partial class MyViewerClientes
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
            this.ClientesreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ClientesreportViewer
            // 
            this.ClientesreportViewer.Location = new System.Drawing.Point(0, 1);
            this.ClientesreportViewer.Name = "ClientesreportViewer";
            this.ClientesreportViewer.Size = new System.Drawing.Size(670, 459);
            this.ClientesreportViewer.TabIndex = 1;
            // 
            // MyViewerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 460);
            this.Controls.Add(this.ClientesreportViewer);
            this.Name = "MyViewerClientes";
            this.Text = "MyViewerClientes";
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ClientesreportViewer;
    }
}