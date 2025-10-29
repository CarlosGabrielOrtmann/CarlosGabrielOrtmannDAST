namespace Vista
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabLibros = new TabPage();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            btnAgregarLibro = new Button();
            btnModificarLibro = new Button();
            btnEliminarLibro = new Button();
            dgvLibros = new DataGridView();

            tabSocios = new TabPage();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnAgregarSocio = new Button();
            btnModificarSocio = new Button();
            btnEliminarSocio = new Button();
            dgvSocios = new DataGridView();

            tabPrestamos = new TabPage();
            lblISBNPrestamo = new Label();
            txtISBNPrestamo = new TextBox();
            lblDNIPrestamo = new Label();
            txtDNIPrestamo = new TextBox();
            btnRegistrarPrestamo = new Button();
            dgvPrestamosActivos = new DataGridView();

            tabDevoluciones = new TabPage();
            lblIDDevolucion = new Label();
            txtIDDevolucion = new TextBox();
            btnRegistrarDevolucion = new Button();
            dgvDevoluciones = new DataGridView();

            tabControlPrincipal.SuspendLayout();
            tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            tabSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            tabPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).BeginInit();
            tabDevoluciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).BeginInit();
            SuspendLayout();

            // ===== TabControl Principal =====
            tabControlPrincipal.Controls.Add(tabLibros);
            tabControlPrincipal.Controls.Add(tabSocios);
            tabControlPrincipal.Controls.Add(tabPrestamos);
            tabControlPrincipal.Controls.Add(tabDevoluciones);
            tabControlPrincipal.Dock = DockStyle.Fill;
            tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new System.Drawing.Size(800, 450);

            // ===== Tab Libros =====
            tabLibros.Controls.Add(lblISBN);
            tabLibros.Controls.Add(txtISBN);
            tabLibros.Controls.Add(lblTitulo);
            tabLibros.Controls.Add(txtTitulo);
            tabLibros.Controls.Add(lblAutor);
            tabLibros.Controls.Add(txtAutor);
            tabLibros.Controls.Add(btnAgregarLibro);
            tabLibros.Controls.Add(btnModificarLibro);
            tabLibros.Controls.Add(btnEliminarLibro);
            tabLibros.Controls.Add(dgvLibros);
            tabLibros.Location = new System.Drawing.Point(4, 24);
            tabLibros.Name = "tabLibros";
            tabLibros.Padding = new Padding(3);
            tabLibros.Size = new System.Drawing.Size(792, 422);
            tabLibros.Text = "Libros";
            tabLibros.UseVisualStyleBackColor = true;

            lblISBN.AutoSize = true;
            lblISBN.Location = new System.Drawing.Point(20, 20);
            lblISBN.Text = "ISBN:";
            txtISBN.Location = new System.Drawing.Point(120, 17);
            txtISBN.Size = new System.Drawing.Size(200, 23);

            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(20, 55);
            lblTitulo.Text = "Título:";
            txtTitulo.Location = new System.Drawing.Point(120, 52);
            txtTitulo.Size = new System.Drawing.Size(200, 23);

            lblAutor.AutoSize = true;
            lblAutor.Location = new System.Drawing.Point(20, 90);
            lblAutor.Text = "Autor:";
            txtAutor.Location = new System.Drawing.Point(120, 87);
            txtAutor.Size = new System.Drawing.Size(200, 23);

            btnAgregarLibro.Location = new System.Drawing.Point(350, 17);
            btnAgregarLibro.Size = new System.Drawing.Size(120, 25);
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.Click += new EventHandler(this.btnAgregarLibro_Click);

            btnModificarLibro.Location = new System.Drawing.Point(350, 52);
            btnModificarLibro.Size = new System.Drawing.Size(120, 25);
            btnModificarLibro.Text = "Modificar Libro";

            btnEliminarLibro.Location = new System.Drawing.Point(350, 87);
            btnEliminarLibro.Size = new System.Drawing.Size(120, 25);
            btnEliminarLibro.Text = "Eliminar Libro";

            dgvLibros.Location = new System.Drawing.Point(10, 130);
            dgvLibros.Size = new System.Drawing.Size(760, 280);
            dgvLibros.ReadOnly = true;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ===== Tab Socios =====
            tabSocios.Controls.Add(lblDNI);
            tabSocios.Controls.Add(txtDNI);
            tabSocios.Controls.Add(lblNombre);
            tabSocios.Controls.Add(txtNombre);
            tabSocios.Controls.Add(lblEmail);
            tabSocios.Controls.Add(txtEmail);
            tabSocios.Controls.Add(lblTelefono);
            tabSocios.Controls.Add(txtTelefono);
            tabSocios.Controls.Add(btnAgregarSocio);
            tabSocios.Controls.Add(btnModificarSocio);
            tabSocios.Controls.Add(btnEliminarSocio);
            tabSocios.Controls.Add(dgvSocios);
            tabSocios.Location = new System.Drawing.Point(4, 24);
            tabSocios.Name = "tabSocios";
            tabSocios.Padding = new Padding(3);
            tabSocios.Size = new System.Drawing.Size(792, 422);
            tabSocios.Text = "Socios";
            tabSocios.UseVisualStyleBackColor = true;

            lblDNI.AutoSize = true;
            lblDNI.Location = new System.Drawing.Point(20, 20);
            lblDNI.Text = "DNI:";
            txtDNI.Location = new System.Drawing.Point(120, 17);
            txtDNI.Size = new System.Drawing.Size(200, 23);

            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(20, 55);
            lblNombre.Text = "Nombre:";
            txtNombre.Location = new System.Drawing.Point(120, 52);
            txtNombre.Size = new System.Drawing.Size(200, 23);

            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(20, 90);
            lblEmail.Text = "Email:";
            txtEmail.Location = new System.Drawing.Point(120, 87);
            txtEmail.Size = new System.Drawing.Size(200, 23);

            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(20, 125);
            lblTelefono.Text = "Teléfono:";
            txtTelefono.Location = new System.Drawing.Point(120, 122);
            txtTelefono.Size = new System.Drawing.Size(200, 23);

            btnAgregarSocio.Location = new System.Drawing.Point(350, 17);
            btnAgregarSocio.Size = new System.Drawing.Size(120, 25);
            btnAgregarSocio.Text = "Agregar Socio";
            btnAgregarSocio.Click += new EventHandler(this.btnAgregarSocio_Click);

            btnModificarSocio.Location = new System.Drawing.Point(350, 52);
            btnModificarSocio.Size = new System.Drawing.Size(120, 25);
            btnModificarSocio.Text = "Modificar Socio";

            btnEliminarSocio.Location = new System.Drawing.Point(350, 87);
            btnEliminarSocio.Size = new System.Drawing.Size(120, 25);
            btnEliminarSocio.Text = "Eliminar Socio";

            dgvSocios.Location = new System.Drawing.Point(10, 170);
            dgvSocios.Size = new System.Drawing.Size(760, 240);
            dgvSocios.ReadOnly = true;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ===== Tab Préstamos =====
            tabPrestamos.Controls.Add(lblISBNPrestamo);
            tabPrestamos.Controls.Add(txtISBNPrestamo);
            tabPrestamos.Controls.Add(lblDNIPrestamo);
            tabPrestamos.Controls.Add(txtDNIPrestamo);
            tabPrestamos.Controls.Add(btnRegistrarPrestamo);
            tabPrestamos.Controls.Add(dgvPrestamosActivos);
            tabPrestamos.Location = new System.Drawing.Point(4, 24);
            tabPrestamos.Name = "tabPrestamos";
            tabPrestamos.Padding = new Padding(3);
            tabPrestamos.Size = new System.Drawing.Size(792, 422);
            tabPrestamos.Text = "Préstamos";
            tabPrestamos.UseVisualStyleBackColor = true;

            lblISBNPrestamo.AutoSize = true;
            lblISBNPrestamo.Location = new System.Drawing.Point(20, 25);
            lblISBNPrestamo.Text = "ISBN:";
            txtISBNPrestamo.Location = new System.Drawing.Point(120, 22);
            txtISBNPrestamo.Size = new System.Drawing.Size(200, 23);

            lblDNIPrestamo.AutoSize = true;
            lblDNIPrestamo.Location = new System.Drawing.Point(20, 60);
            lblDNIPrestamo.Text = "DNI Socio:";
            txtDNIPrestamo.Location = new System.Drawing.Point(120, 57);
            txtDNIPrestamo.Size = new System.Drawing.Size(200, 23);

            btnRegistrarPrestamo.Location = new System.Drawing.Point(350, 22);
            btnRegistrarPrestamo.Size = new System.Drawing.Size(150, 25);
            btnRegistrarPrestamo.Text = "Registrar Préstamo";
            btnRegistrarPrestamo.Click += new EventHandler(this.btnRegistrarPrestamo_Click);

            dgvPrestamosActivos.Location = new System.Drawing.Point(10, 110);
            dgvPrestamosActivos.Size = new System.Drawing.Size(760, 280);
            dgvPrestamosActivos.ReadOnly = true;
            dgvPrestamosActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ===== Tab Devoluciones =====
            tabDevoluciones.Controls.Add(lblIDDevolucion);
            tabDevoluciones.Controls.Add(txtIDDevolucion);
            tabDevoluciones.Controls.Add(btnRegistrarDevolucion);
            tabDevoluciones.Controls.Add(dgvDevoluciones);
            tabDevoluciones.Location = new System.Drawing.Point(4, 24);
            tabDevoluciones.Name = "tabDevoluciones";
            tabDevoluciones.Padding = new Padding(3);
            tabDevoluciones.Size = new System.Drawing.Size(792, 422);
            tabDevoluciones.Text = "Devoluciones";
            tabDevoluciones.UseVisualStyleBackColor = true;

            lblIDDevolucion.AutoSize = true;
            lblIDDevolucion.Location = new System.Drawing.Point(20, 25);
            lblIDDevolucion.Text = "ID Préstamo:";
            txtIDDevolucion.Location = new System.Drawing.Point(120, 22);
            txtIDDevolucion.Size = new System.Drawing.Size(200, 23);

            btnRegistrarDevolucion.Location = new System.Drawing.Point(350, 22);
            btnRegistrarDevolucion.Size = new System.Drawing.Size(150, 25);
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.Click += new EventHandler(this.btnRegistrarDevolucion_Click);

            dgvDevoluciones.Location = new System.Drawing.Point(10, 70);
            dgvDevoluciones.Size = new System.Drawing.Size(760, 320);
            dgvDevoluciones.ReadOnly = true;
            dgvDevoluciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ===== FormPrincipal =====
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControlPrincipal);
            Name = "FormPrincipal";
            Text = "Sistema de Gestión de Biblioteca";

            tabControlPrincipal.ResumeLayout(false);
            tabLibros.ResumeLayout(false);
            tabLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            tabSocios.ResumeLayout(false);
            tabSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            tabPrestamos.ResumeLayout(false);
            tabPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).EndInit();
            tabDevoluciones.ResumeLayout(false);
            tabDevoluciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabLibros;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblAutor;
        private TextBox txtAutor;
        private Button btnAgregarLibro;
        private Button btnModificarLibro;
        private Button btnEliminarLibro;
        private DataGridView dgvLibros;

        private TabPage tabSocios;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnAgregarSocio;
        private Button btnModificarSocio;
        private Button btnEliminarSocio;
        private DataGridView dgvSocios;

        private TabPage tabPrestamos;
        private Label lblISBNPrestamo;
        private TextBox txtISBNPrestamo;
        private Label lblDNIPrestamo;
        private TextBox txtDNIPrestamo;
        private Button btnRegistrarPrestamo;
        private DataGridView dgvPrestamosActivos;

        private TabPage tabDevoluciones;
        private Label lblIDDevolucion;
        private TextBox txtIDDevolucion;
        private Button btnRegistrarDevolucion;
        private DataGridView dgvDevoluciones;
    }
}
