using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
namespace BLL
{
    public class UsuariosBLL
    {

        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                var db = new SistemaVentasDb();

                db.Usuarios.Add(usuario);

                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;

        }

        public static bool Eliminar(int id)
        {
            bool obtener = false;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    Usuarios us = db.Usuarios.Find(id);

                    db.Usuarios.Remove(us);

                    db.SaveChanges();

                    obtener = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return obtener;
            }

        }

        public static Usuarios Buscar(int id)
        {

            var us = new Usuarios();
            var conn = new SistemaVentasDb();

            us = conn.Usuarios.Find(id);
            return us;

        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.ToList();

            return lista;
        }

        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.UsuarioId == usuarioId).ToList();

            return lista;
        }




        public static List<Usuarios> GetListaNombreUsuario(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.Nombre == aux).ToList();

            return lista;

        }
        public static bool Modificar(int id, Usuarios us)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Usuarios usa = db.Usuarios.Find(id);
                    usa.Nombre = us.Nombre;
                    usa.Contrasena = us.Contrasena;
                    usa.Tipo = us.Tipo;
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






        public static List<Usuarios> getContraseña(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.Contrasena == aux).ToList();

            return lista;

        }

    }
}
