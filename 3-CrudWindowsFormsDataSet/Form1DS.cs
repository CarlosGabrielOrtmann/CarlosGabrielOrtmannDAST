using _3_CrudWindowsFormsDataSet.Repositorios;
using _3_CrudWindowsFormsDataSet.Repositorios._3_CrudWindowsFormsDataSet.Repositorios;
using System;
using System.Data;
using System.Windows.Forms;

namespace _3_CrudWindowsFormsDataSet.Formularios
{
    public partial class Form1DS : Form
    {
        private RepositorioPeopleDS repo = new RepositorioPeopleDS();

        public Form1DS()
        {
            InitializeComponent();
        }

        private void Form1DS_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.GetAll();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoDS frm = new FrmNuevoDS();
            frm.ShowDialog();
            LoadDataGrid();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmNuevoDS frm = new FrmNuevoDS(Id.Value);
                frm.ShowDialog();
                LoadDataGrid();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null && MessageBox.Show("¿Eliminar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repo.Delete(Id.Value);
                LoadDataGrid();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
    }
}
