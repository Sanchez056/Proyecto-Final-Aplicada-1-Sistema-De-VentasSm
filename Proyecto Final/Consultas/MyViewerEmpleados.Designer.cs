﻿namespace ProyectoFinal_Aplicada1.Consultas
{
    partial class MyViewerEmpleados
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
            this.EmpleadoreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // EmpleadoreportViewer
            // 
            this.EmpleadoreportViewer.Location = new System.Drawing.Point(0, -1);
            this.EmpleadoreportViewer.Name = "EmpleadoreportViewer";
            this.EmpleadoreportViewer.Size = new System.Drawing.Size(786, 390);
            this.EmpleadoreportViewer.TabIndex = 1;
            // 
            // MyViewerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 387);
            this.Controls.Add(this.EmpleadoreportViewer);
            this.Name = "MyViewerEmpleados";
            this.Text = "MyViewerEmpleados";
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer EmpleadoreportViewer;
    }
}