using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LibroModelo
    {
        public void Agregar(Libro libro)
        {
            Context.Libros.Add(libro);
        }

        public void Modificar(Libro libro)
        {
            var existente = Context.Libros.FirstOrDefault(l => l.ISBN == libro.ISBN);
            if (existente != null)
            {
                existente.Titulo = libro.Titulo;
                existente.Autor = libro.Autor;
                existente.Estado = libro.Estado;
            }
        }

        public void Eliminar(string isbn)
        {
            var libro = Context.Libros.FirstOrDefault(l => l.ISBN == isbn);
            if (libro != null)
                Context.Libros.Remove(libro);
        }

        public Libro ObtenerPorISBN(string isbn)
        {
            return Context.Libros.FirstOrDefault(l => l.ISBN == isbn);
        }

        public List<Libro> ObtenerTodos()
        {
            return Context.Libros.ToList();
        }
    }
}
