using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace _3_CrudWindowsFormsDataSet.Repositorios
{
    using System;
    using System.Data;
    using Microsoft.Data.SqlClient;

    namespace _3_CrudWindowsFormsDataSet.Repositorios
    {
        public class RepositorioPeopleDS
        {
            private string connectionString = @"Data Source=PCGABY\SQLEXPRESS;Initial Catalog=CrudWindowsForm;Integrated Security=True;TrustServerCertificate=True";
            private SqlDataAdapter adapter;
            private DataTable table;

            private void EnsureTable()
            {
                if (table == null)
                {
                    adapter = new SqlDataAdapter("SELECT * FROM People", connectionString);
                    new SqlCommandBuilder(adapter);

                    table = new DataTable();
                    adapter.Fill(table);

                    table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };

                    DataColumn idCol = table.Columns["Id"];
                    idCol.AutoIncrement = true;
                    idCol.AutoIncrementSeed = -1;
                    idCol.AutoIncrementStep = -1;
                }
            }

            public DataTable GetAll()
            {
                EnsureTable();
                table.Clear();
                adapter.Fill(table);
                return table;
            }

            public void Add(string name, int age)
            {
                EnsureTable();
                DataRow newRow = table.NewRow();
                newRow["Name"] = name;
                newRow["Age"] = age;
                table.Rows.Add(newRow);
                adapter.Update(table);
                table.Clear();
                adapter.Fill(table);
            }

            public void Update(int id, string name, int age)
            {
                EnsureTable();
                DataRow row = table.Rows.Find(id);
                if (row != null)
                {
                    row["Name"] = name;
                    row["Age"] = age;
                    adapter.Update(table);
                    table.Clear();
                    adapter.Fill(table);
                }
            }

            public void Delete(int id)
            {
                EnsureTable();
                DataRow row = table.Rows.Find(id);
                if (row != null)
                {
                    row.Delete();
                    adapter.Update(table);
                    table.Clear();
                    adapter.Fill(table);
                }
            }
        }
    }
}