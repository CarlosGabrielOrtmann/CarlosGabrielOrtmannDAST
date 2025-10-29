using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Socio
    {
        public string DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Socio() { }

        public Socio(string dni, string nombreCompleto, string email, string telefono)
        {
            DNI = dni;
            NombreCompleto = nombreCompleto;
            Email = email;
            Telefono = telefono;
        }
    }
}
