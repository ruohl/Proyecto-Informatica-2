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
    public partial class Evento : Form
    {
        public int messi { get; set; }

        public Evento()
        {
            InitializeComponent();
        }
        public void CargarPersona(int ID)
        {
            txApellido.Text = ID.ToString();

        }

        public void CargarEvento(int id)
        {

            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter da =
                new System.Data.SqlClient.SqlDataAdapter(
                    $"SELECT * FROM Eventos WHERE Id={id}",
                    "Data Source=SQL5070.site4now.net;Initial Catalog=db_9cf8b6_huergo2023;User Id=db_9cf8b6_huergo2023_admin;Password=huergo2023");
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string descripcion = Convert.ToString(dt.Rows[0]["Descripcion"]);
                string idPersona = Convert.ToString(dt.Rows[0]["IdPersona"]);
                int opcion = Convert.ToInt16(dt.Rows[0]["Prioridad"]);
                DateTime fechaHora = Convert.ToDateTime(dt.Rows[0]["FechaHora"]);
                DateTime fecha = fechaHora.Date;
                TimeSpan hora = fechaHora.TimeOfDay;
                txId.Text = id.ToString();
                txNombre.Text = descripcion;
                dpFNacimiento.Value = fecha;
                txApellido.Text = idPersona;
                dateTimePicker1.Value = fecha.Date + hora;
                switch (opcion)
                    {
                    case 1:
                        radioButton1.Checked = true;
                        break;
                    case 2:
                        radioButton2.Checked = true;
                        break;
                    case 3:
                        radioButton3.Checked = true;
                        break;
                }

            }
        }
        private void Evento_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            // HICE EL METODO YANDERE DEV, ASI QUE SI ANDA MAL, FIXEADO CON CHATGPT, SON LAS 4 AM FLACO 

            if (string.IsNullOrWhiteSpace(txNombre.Text)) //(txNombre.Text == "")
            {
                MessageBox.Show("La Descripcion es obligatoria", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            int opcion = 0;

            if (!radioButton1.Checked)
            {
                if (!radioButton2.Checked)
                {
                    if (!radioButton3.Checked)
                    {
                        MessageBox.Show("Ponga una prioridad", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        opcion = 3;
                    }
                }
                else
                {
                    opcion = 2;
                }
            }
            else
            {
                opcion = 1;
            }

            bool esInsert = string.IsNullOrWhiteSpace(txId.Text);

            string insert = string.Empty;
            if (esInsert)
            {
                insert = $"INSERT INTO Eventos (Id, FechaHora, Descripcion, Prioridad, idPersona) VALUES ((SELECT MAX(Id)+1 FROM Eventos), '{dpFNacimiento.Value.ToString("yyyy-MM-dd")} {dateTimePicker1.Value.ToString("HH:mm:ss")}', '{txNombre.Text}', '{opcion}', '{txApellido.Text}');";
            }
            else
            {
                // Terminar esto
                insert = $"UPDATE Eventos SET FechaHora = '{dpFNacimiento.Value.ToString("yyyy-MM-dd")} {dateTimePicker1.Value.ToString("HH:mm:ss")}', Descripcion = '{txNombre.Text}', Prioridad = '{opcion}', idPersona = '{txApellido.Text}' WHERE Id = {txId.Text};";
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

        private void button1_Click(object sender, EventArgs e)
        {

            personasevent eventosaltaper = new personasevent();
            eventosaltaper.ShowDialog();
        }

    }
}
