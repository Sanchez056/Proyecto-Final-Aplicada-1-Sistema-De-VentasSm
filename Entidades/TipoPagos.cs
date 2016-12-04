using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public  class TipoPagos
    {
        [Key]
        public int TipoId { get; set; }

        public string Descripcion { get; set; }
    }
}
