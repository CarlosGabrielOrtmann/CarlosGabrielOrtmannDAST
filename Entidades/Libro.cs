using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Estado { get; set; }

        public Libro() { }

        public Libro(string isbn, string titulo, string autor, string estado)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Estado = estado;
        }
    }
}
