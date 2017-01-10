using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class PrestamosBD : DbContext
    {
        public PrestamosBD() : base("ConStr")
        {

        }

        public DbSet<Clientes> Client { get; set; }
    }
}
