using Entidades;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class SistemaVentasDb : DbContext
    {
        public SistemaVentasDb() : base("name=ConStr")
        {
                
        }


        public virtual DbSet<Usuarios> Usuarios { get; set; }

        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }

        public virtual DbSet<Clientes> Clientes{ get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }

        public virtual DbSet<TipoPagos> CodicionPagos { get; set; }

        public virtual DbSet<Proveedores> Proveedore { get; set; }

        public virtual DbSet<Ventas> Ventas{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ventas>()
                .HasMany<Articulos>(v => v.Articulos)
                .WithMany(a=> a.Ventas)
                .Map(Va=>
                {
                    Va.MapLeftKey("VentaId");
                    Va.MapRightKey("ArticuloId");
                    Va.ToTable("DetalleVentas");
                });
        }
    }
}
