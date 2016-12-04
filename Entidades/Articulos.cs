using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Articulos
    {
        [Key]
        
        public int ArticuloId{ get; set; }        

        public string Nombre { get; set; }

        [Browsable(false)]
        public string Descripcion { get; set; }

        public Double Precio { get; set; }

        
        [Browsable(false)]
        public string Marca { get; set; }


        public int Cantidad { get; set; }

        public Double Importe { get; set; }

        public virtual List<Ventas> Ventas { get; set; }

        public Articulos()
        {
            this.Ventas = new List<Ventas>();
        }

        public Articulos(int articuloId, string nombre, string descripcion, int precio, int unidad,string marca)
        {
            this.ArticuloId = articuloId;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad= Cantidad;
            this.Marca = marca;
            this.Ventas = new List<Ventas>();
        }

        public Articulos(int articuloId, string nombre, Double precio, int cantidad)
        {
            this.ArticuloId = articuloId;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Importe = cantidad * precio;

            this.Ventas = new List<Ventas>();
        }
    }
}
