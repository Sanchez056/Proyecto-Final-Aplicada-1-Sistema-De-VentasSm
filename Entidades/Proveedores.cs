using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Proveedores
    {
       [Key]
        public int ProveedorId { get; set; }

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Fax { get; set; }

        public string Correo { get; set; }

        public DateTime Fecha { get; set; }
        public Proveedores( string nombre)
        {
            
            this.Nombre = nombre;
        }

        public Proveedores()
        {

        }

    }
}
