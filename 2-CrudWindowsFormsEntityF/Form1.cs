using _2_CrudWindowsFormsEntityF.Models;

namespace _2_CrudWindowsFormsEntityF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            RepositorioPeople oPeopleDB = new RepositorioPeople();
            dataGridView1.DataSource = oPeopleDB.Get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            frm.ShowDialog();
            LoadDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmNuevo frmEdit = new FrmNuevo(Id.Value);
                frmEdit.ShowDialog();
                LoadDataGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {
                if (Id != null)
                {
                    if (MessageBox.Show("¿Seguro que deseas eliminar este registro?",
                                        "Confirmar eliminación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RepositorioPeople oPeopleDB = new RepositorioPeople();
                        oPeopleDB.Delete(Id.Value);
                        LoadDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message);
            }
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}

