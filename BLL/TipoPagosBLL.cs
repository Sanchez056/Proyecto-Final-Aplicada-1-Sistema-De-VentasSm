using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TipoPagosBLL
    {
        public static bool Insertar(TipoPagos c)
        {
            bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.CodicionPagos.Add(c);
                    db.SaveChanges();
                    retorna = true;
                }


            }
            catch (Exception)
            {
                throw;

            }
            return retorna;

        }
        public static bool Modificar(int id, TipoPagos cps)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    TipoPagos cp = db.CodicionPagos.Find(id);
                    cp.Descripcion = cps.Descripcion;
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


        public static TipoPagos Buscar(int id)
        {
            var db = new SistemaVentasDb();
            return db.CodicionPagos.Find(id);
        }

        public static bool Eliminar(int id)
        {

            try
            {

                using (var db = new SistemaVentasDb())
                {
                    TipoPagos cps = new TipoPagos();
                    cps = db.CodicionPagos.Find(id);

                    db.CodicionPagos.Remove(cps);
                    db.SaveChanges();
                    db.Dispose();
                    return false;
                }


            }
            catch (Exception)
            {
                return true;
                throw;


            }

        }





        public static List<TipoPagos> GetListaDescripcion(string aux)
        {
            List<TipoPagos> lista = new List<TipoPagos>();

            var db = new SistemaVentasDb();

            lista = db.CodicionPagos.Where(p => p.Descripcion == aux).ToList();

            return lista;

        }

        public static List<TipoPagos> GetLista(int id)
        {
            List<TipoPagos> lista = new List<TipoPagos>();

            var db = new SistemaVentasDb();

            lista = db.CodicionPagos.Where(p => p.TipoId == id).ToList();

            return lista;

        }

        public static List<TipoPagos> GetLista()
        {
            List<TipoPagos> lista = new List<TipoPagos>();

            var db = new SistemaVentasDb();

            lista = db.CodicionPagos.ToList();

            return lista;


        }
    }
}
