using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SocioModelo
    {
        public void Agregar(Socio socio)
        {
            Context.Socios.Add(socio);
        }

        public void Modificar(Socio socio)
        {
            var existente = Context.Socios.FirstOrDefault(s => s.DNI == socio.DNI);
            if (existente != null)
            {
                existente.NombreCompleto = socio.NombreCompleto;
                existente.Email = socio.Email;
                existente.Telefono = socio.Telefono;
            }
        }

        public void Eliminar(string dni)
        {
            var socio = Context.Socios.FirstOrDefault(s => s.DNI == dni);
            if (socio != null)
                Context.Socios.Remove(socio);
        }

        public Socio ObtenerPorDNI(string dni)
        {
            return Context.Socios.FirstOrDefault(s => s.DNI == dni);
        }

        public List<Socio> ObtenerTodos()
        {
            return Context.Socios.ToList();
        }
    }
}
