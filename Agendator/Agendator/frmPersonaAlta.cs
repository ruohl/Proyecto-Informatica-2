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
    public partial class frmPersonaAlta : Form
    {
        public frmPersonaAlta()
        {
            InitializeComponent();
        }

        public void CargarPersona(int id)
        {
            //Me voy al SQL, obtengo a la persona segun su ID
            //Lleno los controles

            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter da =
                new System.Data.SqlClient.SqlDataAdapter(
                    $"SELECT * FROM Personas WHERE Id={id}",
                    "Data Source=SQL5070.site4now.net;Initial Catalog=db_9cf8b6_huergo2023;User Id=db_9cf8b6_huergo2023_admin;Password=huergo2023");
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string nombre = Convert.ToString(dt.Rows[0]["Nombre"]);
                string apellido = Convert.ToString(dt.Rows[0]["Apellido"]);
                DateTime fNacimiento = Convert.ToDateTime(dt.Rows[0]["FNacimiento"]);

                txId.Text = id.ToString();
                txApellido.Text = apellido;
                txNombre.Text = nombre;
                dpFNacimiento.Value = fNacimiento;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txNombre.Text)) //(txNombre.Text == "")
                {
                    MessageBox.Show("Nombre es obligatorio", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (string.IsNullOrWhiteSpace(txApellido.Text)) //(txNombre.Text == "")
                {
                    MessageBox.Show("Apellido es obligatorio", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                bool esInsert = string.IsNullOrWhiteSpace(txId.Text);

                string insert = string.Empty;
                if (esInsert)
                {
                    insert = $"INSERT INTO Personas (Id, FNacimiento, Nombre, Apellido) VALUES ((SELECT MAX(Id)+1 FROM Personas), '{dpFNacimiento.Value.ToString("yyyy-MM-dd")}', '{txNombre.Text}', '{txApellido.Text}');";
                }
                else
                {
                    insert = $"UPDATE Personas SET FNacimiento='{dpFNacimiento.Value.ToString("yyyy-MM-dd")}', Nombre='{txNombre.Text}', Apellido='{txApellido.Text}' WHERE Id={txId.Text}";
                }

                //-------------------------------------------------------------------
                System.Data.SqlClient.SqlConnection variableConexion = new System.Data.SqlClient.SqlConnection();
                variableConexion.ConnectionString = "Data Source=SQL5070.site4now.net;Initial Catalog=db_9cf8b6_huergo2023;User Id=db_9cf8b6_huergo2023_admin;Password=huergo2023";
                variableConexion.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandText = insert;
                cmd.Connection = variableConexion;
                cmd.ExecuteNonQuery();


                this.Close();
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("Log.txt", $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} | {ex.Message}" + Environment.NewLine);
                MessageBox.Show("Error inesperado intente nuevamente o comuníquese con soporte, EXCEPTO QUE NO HAY JAJAJAJAJ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
