using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Windows.Forms;

namespace BLL
{
   public  class ProveedoresBLL
    {

        public static bool Insertar(Proveedores proveedor)
        {
            bool resultado = false;
            using (var conexion = new SistemaVentasDb())
            {
                try
                {
                    conexion.Proveedore.Add(proveedor);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return resultado;
            }
        }

        public static List<Proveedores> GetLista()
        {
            List<Proveedores> lista = new List<Proveedores>();

            using (var conexion = new SistemaVentasDb())
            {
                try
                {
                    lista = conexion.Proveedore.ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    
                }
                return lista;
            }

        }
        public static bool Modificar(int id, Proveedores prov)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Proveedores p = db.Proveedore.Find(id);
                    p.Nombre = prov.Nombre;
                    p.Telefono = prov.Telefono;
                    p.Ciudad = prov.Ciudad;
                    p.Correo = prov.Correo;
                    p.Direccion = prov.Direccion;
                    p.Fax = prov.Fax;

                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }


        public static Proveedores Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Proveedore.Find(id);


        }

        public static bool Eliminar(int id)
        {
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Proveedores p = new Proveedores();
                    p = db.Proveedore.Find(id);

                    db.Proveedore.Remove(p);
                    db.SaveChanges();
                    return false;
                }


            }
            catch (Exception)
            {
                return true;
                throw;


            }

        }
        public static List<Proveedores> GetLista(int proveedorId)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedore.Where(p => p.ProveedorId == proveedorId).ToList();

            return lista;

        }



        public static List<Proveedores> GetListaNombreProveedor(string aux)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedore.Where(p => p.Nombre == aux).ToList();

            return lista;

        }




        public static List<Proveedores> GetListaFecha(DateTime aux)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedore.Where(p => p.Fecha == aux).ToList();

            return lista;

        }
        public static List<Proveedores> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedore.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

            return lista;

        }

    }
}

