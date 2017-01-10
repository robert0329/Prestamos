using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes Client)
        {
            bool resultado = false;
            using (var Conn = new PrestamosBD())
            {
                try
                {
                    var p = Buscar(Client.ClientesId);
                    if (p == null)
                        Conn.Client.Add(Client);
                    else
                        Conn.Entry(Client).State = EntityState.Modified;
                    Conn.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static bool Eliminar(Clientes Client)
        {
            bool resultado = false;
            using (var Conn = new PrestamosBD())
            {
                try
                {
                    Conn.Entry(Client).State = EntityState.Deleted;
                    Conn.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static Clientes Buscar(int Id)
        {
            var c = new Clientes();
            using (var Conn = new PrestamosBD())
            {
                try
                {
                    c = Conn.Client.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();
            using (var conexion = new PrestamosBD())
            {
                try
                {
                    lista = conexion.Client.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Clientes> GetListaId(int ClientesId)
        {
            List<Clientes> list = new List<Clientes>();
            using (var db = new PrestamosBD())
            {
                try
                {
                    list = db.Client.Where(p => p.ClientesId == ClientesId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;
        }
    }
}
