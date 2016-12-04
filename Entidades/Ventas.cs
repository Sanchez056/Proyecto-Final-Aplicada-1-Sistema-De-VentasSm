using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }

        public string Empleado { get; set; }

        public string Cliente { get; set; }


        public int Cantidad { get; set; }
        public double SubTotal { get; set; }

        public double Itebis{ get; set; }

        public double TotalItebis { get; set; }

        public double Total { get; set; }

        public double Abono { get; set; }
        public double Deuda { get; set; }

        public DateTime Fecha { get; set; }


        [Browsable(false)]
        public virtual List<Articulos>  Articulos{ get; set; }
        public Ventas(int VentaId)
        {
            this.VentaId = VentaId;
            this.Articulos = new List<Articulos>();
        }

        public Ventas()
        {
            this.Articulos = new List<Articulos>();
        }

    }
}
