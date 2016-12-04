namespace ProyectoFinal_Aplicada1.VentanasReportes
{
    partial class FacturaReporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Productos";
            reportDataSource1.Value = this.ArticulosBindingSource;
            reportDataSource2.Name = "Facturas";
            reportDataSource2.Value = this.VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal_Aplicada1.Reportes.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(650, 488);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ArticulosBindingSource
            // 
            this.ArticulosBindingSource.DataSource = typeof(Entidades.Articulos);
            this.ArticulosBindingSource.CurrentChanged += new System.EventHandler(this.ArticulosBindingSource_CurrentChanged);
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataSource = typeof(Entidades.Ventas);
            this.VentasBindingSource.CurrentChanged += new System.EventHandler(this.VentasBindingSource_CurrentChanged);
            // 
            // FacturaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 488);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FacturaReporte";
            this.Text = "FacturaReporte";
            this.Load += new System.EventHandler(this.FacturaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArticulosBindingSource;
        private System.Windows.Forms.BindingSource VentasBindingSource;
    }
}