using Controladora;
using Modelo;
using System.Text.RegularExpressions;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        private readonly ControladoraBiblioteca controladora;

        public FormPrincipal()
        {
            InitializeComponent();
            controladora = ControladoraBiblioteca.Instancia;

            CargarLibros();
            CargarSocios();
            CargarPrestamosActivos();
        }

        // =========================
        // LIBROS
        // =========================
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            var isbnRegex = @"^\d{3}-\d-\d{4}-\d{4}-\d$";
            if (!Regex.IsMatch(txtISBN.Text, isbnRegex))
            {
                MessageBox.Show("El ISBN no tiene un formato válido.");
                return;
            }

            var libro = new Libro(txtISBN.Text, txtTitulo.Text, txtAutor.Text, "disponible");
            string mensaje = controladora.RegistrarLibro(libro);
            MessageBox.Show(mensaje);
            CargarLibros();
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = controladora.ObtenerLibros();
        }

        // =========================
        // SOCIOS
        // =========================
        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            var dniRegex = @"^\d{8}$";
            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var telRegex = @"^\d{4}-\d{6}$";

            if (!Regex.IsMatch(txtDNI.Text, dniRegex))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }
            if (!Regex.IsMatch(txtEmail.Text, emailRegex))
            {
                MessageBox.Show("Email inválido.");
                return;
            }
            if (!Regex.IsMatch(txtTelefono.Text, telRegex))
            {
                MessageBox.Show("Teléfono inválido.");
                return;
            }

            var socio = new Socio(txtDNI.Text, txtNombre.Text, txtEmail.Text, txtTelefono.Text);
            string mensaje = controladora.RegistrarSocio(socio);
            MessageBox.Show(mensaje);
            CargarSocios();
        }

        private void CargarSocios()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = controladora.ObtenerSocios();
        }

        // =========================
        // PRÉSTAMOS
        // =========================
        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            string isbn = txtISBNPrestamo.Text;
            string dni = txtDNIPrestamo.Text;

            string mensaje = controladora.RegistrarPrestamo(isbn, dni);
            MessageBox.Show(mensaje);
            CargarPrestamosActivos();
        }

        private void CargarPrestamosActivos()
        {
            dgvPrestamosActivos.DataSource = null;
            dgvPrestamosActivos.DataSource = controladora.ListarPrestamosActivos();
        }

        // =========================
        // DEVOLUCIONES
        // =========================
        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDDevolucion.Text, out int idPrestamo))
            {
                MessageBox.Show("ID de préstamo inválido.");
                return;
            }

            string mensaje = controladora.RegistrarDevolucion(idPrestamo);
            MessageBox.Show(mensaje);
            CargarPrestamosActivos();
        }
    }
}

