using _3_CrudWindowsFormsDataSet.Repositorios;
using _3_CrudWindowsFormsDataSet.Repositorios._3_CrudWindowsFormsDataSet.Repositorios;
using System;
using System.Data;
using System.Windows.Forms;

namespace _3_CrudWindowsFormsDataSet.Formularios
{
    public partial class FrmNuevoDS : Form
    {
        private int? Id;
        private RepositorioPeopleDS repo = new RepositorioPeopleDS();

        public FrmNuevoDS(int? id = null)
        {
            InitializeComponent();
            Id = id;
            if (Id != null)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            var dt = repo.GetAll();
            DataRow row = dt.Rows.Find(Id.Value);
            if (row != null)
            {
                txtName.Text = row["Name"].ToString();
                txtEdad.Text = row["Age"].ToString();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int age))
            {
                MessageBox.Show("Edad inválida");
                return;
            }

            try
            {
                if (Id == null)
                {
                    repo.Add(txtName.Text, age);
                }
                else
                {
                    repo.Update(Id.Value, txtName.Text, age);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
        }
    }
}
