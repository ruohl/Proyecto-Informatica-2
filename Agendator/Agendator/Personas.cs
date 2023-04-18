using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agendator
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DataTable dt = new DataTable();
                System.Data.SqlClient.SqlDataAdapter da =
                    new System.Data.SqlClient.SqlDataAdapter(
                        "SELECT * FROM Personas",
                        "Data Source=SQL5070.site4now.net;Initial Catalog=db_9cf8b6_huergo2023;User Id=db_9cf8b6_huergo2023_admin;Password=huergo2023");
                da.Fill(dt);

                gvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvPersonas.AutoGenerateColumns = false;
                gvPersonas.DataSource = dt;
            }
            else
            {
                string query = $"select * from Personas WHERE Nombre LIKE '%{textBox1.Text}%' or Apellido LIKE '%{textBox1.Text}%' ";
                DataTable dt = new DataTable();
                System.Data.SqlClient.SqlDataAdapter da =
                    new System.Data.SqlClient.SqlDataAdapter(
                    query,
                    "Data Source=SQL5070.site4now.net;Initial Catalog=db_9cf8b6_huergo2023;User Id=db_9cf8b6_huergo2023_admin;Password=huergo2023");
                da.Fill(dt);

                gvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvPersonas.AutoGenerateColumns = false;
                gvPersonas.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPersonaAlta personaAlta = new frmPersonaAlta();
            if (gvPersonas.SelectedRows.Count > 0)
            {
                object valor = gvPersonas.SelectedRows[0].Cells[0].Value;

                int id = Convert.ToInt32(valor);

                personaAlta.CargarPersona(id);
                personaAlta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ninguna persona seleccionada", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersonaAlta personaAlta = new frmPersonaAlta();
            personaAlta.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
