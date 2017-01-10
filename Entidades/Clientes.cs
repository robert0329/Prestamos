using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public int ClientesId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Cedula { get; set; }

        public Clientes(int ClienteId, string Nombres, string Direccion, string Telefono, string Cedula, string Sexo)
        {
            this.ClientesId = ClienteId;
            this.Nombres = Nombres;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Cedula = Cedula;
            this.Sexo = Sexo;
        }
        public Clientes()
        {

        }
    }
}
