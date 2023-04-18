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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            DateTime fechaSiguente = fechaSeleccionada.AddDays(1);

            string fechaStrDesde = fechaSeleccionada.ToString("yyyy-MM-dd");
            string fechaStrHasta = fechaSiguente.ToString("yyyy-MM-dd");

            //string query = "SELECT * FROM Eventos where FechaHora >= '" + fechaStrDesde + "' AND FechaHora < '" + fechaStrHasta + "'";
            string query = $"SELECT * FROM Eventos where FechaHora >= '{fechaStrDesde}' AND FechaHora < '{fechaStrHasta}'";
            
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter da =
                new System.Data.SqlClient.SqlDataAdapter(
                    query,
                    "Data Source=SQL5070.site4now.net;Initial Catalog=db_9cf8b6_huergo2023;User Id=db_9cf8b6_huergo2023_admin;Password=huergo2023");
            da.Fill(dt);

            gvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvEventos.AutoGenerateColumns = false;
            gvEventos.DataSource = dt;

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Evento fmevento = new Evento();
            fmevento.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personas fmPersonas = new Personas();
            fmPersonas.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Evento eventoalta = new Evento();
            if (gvEventos.SelectedRows.Count > 0)
            {
                object valor = gvEventos.SelectedRows[0].Cells[0].Value;

                int id = Convert.ToInt32(valor);

                eventoalta.CargarEvento(id);
                eventoalta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningun evento seleccionado", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
    
}
