using Modelo;
using System.Text.RegularExpressions;

namespace Controladora
{
    public class ControladoraBiblioteca
    {
        // Singleton
        private static ControladoraBiblioteca _instancia;
        public static ControladoraBiblioteca Instancia
        {
            get
            {
                _instancia ??= new ControladoraBiblioteca();
                return _instancia;
            }
        }

        private readonly LibroModelo libroModelo = new();
        private readonly SocioModelo socioModelo = new();
        private readonly PrestamoModelo prestamoModelo = new();

        private ControladoraBiblioteca() { }

        // Libros
        public string RegistrarLibro(Libro libro)
        {
            if (libroModelo.ObtenerPorISBN(libro.ISBN) != null)
                return "Ya existe un libro con ese ISBN.";
            libroModelo.Agregar(libro);
            return "Libro registrado correctamente.";
        }

        public List<Libro> ObtenerLibros() => libroModelo.ObtenerTodos();

        // Socios
        public string RegistrarSocio(Socio socio)
        {
            if (socioModelo.ObtenerPorDNI(socio.DNI) != null)
                return "Ya existe un socio con ese DNI.";
            socioModelo.Agregar(socio);
            return "Socio registrado correctamente.";
        }

        public List<Socio> ObtenerSocios() => socioModelo.ObtenerTodos();

        // Préstamos
        public string RegistrarPrestamo(string isbn, string dni)
        {
            var libro = libroModelo.ObtenerPorISBN(isbn);
            var socio = socioModelo.ObtenerPorDNI(dni);

            if (libro == null) return "Libro no encontrado.";
            if (socio == null) return "Socio no encontrado.";
            if (libro.Estado == "prestado") return "El libro ya está prestado.";

            prestamoModelo.RegistrarPrestamo(libro, socio);
            return "Préstamo registrado correctamente.";
        }

        public string RegistrarDevolucion(int idPrestamo)
        {
            var activos = prestamoModelo.ObtenerActivos();
            var prestamo = activos.Find(p => p.IdPrestamo == idPrestamo);
            if (prestamo == null) return "Préstamo no encontrado o ya devuelto.";
            prestamoModelo.RegistrarDevolucion(idPrestamo);
            return "Devolución registrada correctamente.";
        }

        public List<Prestamo> ListarPrestamosActivos() => prestamoModelo.ObtenerActivos();
    }
}
