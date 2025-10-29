namespace Modelo
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public Libro LibroAsociado { get; set; }
        public Socio SocioAsociado { get; set; }
    }
}
