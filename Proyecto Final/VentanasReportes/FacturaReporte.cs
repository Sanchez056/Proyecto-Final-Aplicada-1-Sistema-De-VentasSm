using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.VentanasReportes
{
    public partial class FacturaReporte : Form
    {

        public int VentaId { get; set; }

        public FacturaReporte()
        {
            InitializeComponent();
        }

        private void FacturaReporte_Load(object sender, EventArgs e)
        {
            Ventas vent = BLL.VentasBLL.Buscar(VentaId);
            VentasBindingSource.Add(vent);
            foreach (var articul in BLL.ArticulosBLL.Articulo(VentaId))
            {
                ArticulosBindingSource.Add(articul);

            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void VentasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ArticulosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
