namespace Modelo
{
    public class PrestamoModelo
    {
        public void RegistrarPrestamo(Libro libro, Socio socio)
        {
            Context.UltimoIdPrestamo++;
            var prestamo = new Prestamo
            {
                IdPrestamo = Context.UltimoIdPrestamo,
                LibroAsociado = libro,
                SocioAsociado = socio,
                FechaPrestamo = System.DateTime.Now
            };
            Context.Prestamos.Add(prestamo);
            libro.Estado = "prestado";
        }

        public void RegistrarDevolucion(int idPrestamo)
        {
            var prestamo = Context.Prestamos.FirstOrDefault(p => p.IdPrestamo == idPrestamo);
            if (prestamo != null && prestamo.FechaDevolucion == null)
            {
                prestamo.FechaDevolucion = System.DateTime.Now;
                prestamo.LibroAsociado.Estado = "disponible";
            }
        }

        public List<Prestamo> ObtenerActivos()
        {
            return Context.Prestamos.Where(p => p.FechaDevolucion == null).ToList();
        }
    }
}
