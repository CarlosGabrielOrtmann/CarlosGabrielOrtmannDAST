using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_CrudWindowsFormsEntityF.Models;

namespace _2_CrudWindowsFormsEntityF
{
    public partial class FrmNuevo : Form
    {

        private int? Id;
        public FrmNuevo(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            RepositorioPeople oPeopleDB = new RepositorioPeople();
            Person oPeople = oPeopleDB.Get(Id);
            txtName.Text = oPeople.Name;
            txtEdad.Text = oPeople.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepositorioPeople oPeopleDB = new RepositorioPeople();

            if (!int.TryParse(txtEdad.Text, out int age))
            {
                MessageBox.Show("Edad inválida.");
                return;
            }

            try
            {
                if (Id == null)
                {

                    oPeopleDB.Add(txtName.Text, age);
                }
                else
                {

                    oPeopleDB.Update(txtName.Text, age, Id.Value);
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
