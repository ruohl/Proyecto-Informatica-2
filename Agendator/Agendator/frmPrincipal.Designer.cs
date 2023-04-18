
namespace Agendator
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.gvEventos = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gvEventos)).BeginInit();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(11, 66);
			this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 4;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// gvEventos
			// 
			this.gvEventos.AllowUserToAddRows = false;
			this.gvEventos.AllowUserToDeleteRows = false;
			this.gvEventos.AllowUserToOrderColumns = true;
			this.gvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Prioridad,
            this.ID_Persona,
            this.FechaHora});
			this.gvEventos.Location = new System.Drawing.Point(273, 66);
			this.gvEventos.Margin = new System.Windows.Forms.Padding(2);
			this.gvEventos.Name = "gvEventos";
			this.gvEventos.ReadOnly = true;
			this.gvEventos.RowHeadersWidth = 51;
			this.gvEventos.RowTemplate.Height = 24;
			this.gvEventos.Size = new System.Drawing.Size(584, 402);
			this.gvEventos.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Personas";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(273, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 30);
			this.button2.TabIndex = 7;
			this.button2.Text = "Nuevo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(436, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 30);
			this.button3.TabIndex = 8;
			this.button3.Text = "Modificar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "Id";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "descripcion";
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Prioridad
			// 
			this.Prioridad.DataPropertyName = "prioridad";
			this.Prioridad.HeaderText = "Prioridad";
			this.Prioridad.Name = "Prioridad";
			this.Prioridad.ReadOnly = true;
			// 
			// ID_Persona
			// 
			this.ID_Persona.DataPropertyName = "IdPersona";
			this.ID_Persona.HeaderText = "ID_Persona";
			this.ID_Persona.Name = "ID_Persona";
			this.ID_Persona.ReadOnly = true;
			// 
			// FechaHora
			// 
			this.FechaHora.DataPropertyName = "FechaHora";
			this.FechaHora.HeaderText = "FechaHora";
			this.FechaHora.Name = "FechaHora";
			this.FechaHora.ReadOnly = true;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 479);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gvEventos);
			this.Controls.Add(this.monthCalendar1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmPrincipal";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvEventos)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView gvEventos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Persona;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
	}
}

