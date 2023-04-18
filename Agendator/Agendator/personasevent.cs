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
    public partial class personasevent : Form
    {
        public int messi { get; set; }

        public personasevent()
        {
            InitializeComponent();
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

        public void button2_Click(object sender, EventArgs e)
        {
            if (gvPersonas.SelectedRows.Count > 0)
            {
                object valor = gvPersonas.SelectedRows[0].Cells[0].Value;

                int id = Convert.ToInt32(valor);
                int messi =  id;
                Evento Evento = (Evento)Application.OpenForms["Evento"];
                Evento.CargarPersona(messi);
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ninguna persona seleccionada", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void AgarrarID()
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
