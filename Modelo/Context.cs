using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context
    {
        public static List<Libro> Libros { get; } = new();
        public static List<Socio> Socios { get; } = new();
        public static List<Prestamo> Prestamos { get; } = new();
        public static int UltimoIdPrestamo { get; set; } = 0;
    }
}
