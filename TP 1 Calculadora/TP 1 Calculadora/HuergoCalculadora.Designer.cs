
namespace TP_1_Calculadora
{
	partial class HuergoCalculadora
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxLista = new System.Windows.Forms.TextBox();
			this.TxNumero = new System.Windows.Forms.TextBox();
			this.Bu7 = new System.Windows.Forms.Button();
			this.Bu8 = new System.Windows.Forms.Button();
			this.Bu9 = new System.Windows.Forms.Button();
			this.BuDividir = new System.Windows.Forms.Button();
			this.BuMultiplicar = new System.Windows.Forms.Button();
			this.Bu6 = new System.Windows.Forms.Button();
			this.Bu5 = new System.Windows.Forms.Button();
			this.Bu4 = new System.Windows.Forms.Button();
			this.BuSuma = new System.Windows.Forms.Button();
			this.Bu3 = new System.Windows.Forms.Button();
			this.Bu2 = new System.Windows.Forms.Button();
			this.Bu1 = new System.Windows.Forms.Button();
			this.BuResta = new System.Windows.Forms.Button();
			this.BuBorrar = new System.Windows.Forms.Button();
			this.BuComa = new System.Windows.Forms.Button();
			this.Bu0 = new System.Windows.Forms.Button();
			this.lbHistorial = new System.Windows.Forms.ListBox();
			this.BuBorrarTodo = new System.Windows.Forms.Button();
			this.BuIgual = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxLista
			// 
			this.TxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxLista.Location = new System.Drawing.Point(12, 29);
			this.TxLista.Name = "TxLista";
			this.TxLista.Size = new System.Drawing.Size(367, 22);
			this.TxLista.TabIndex = 0;
			// 
			// TxNumero
			// 
			this.TxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxNumero.Location = new System.Drawing.Point(13, 57);
			this.TxNumero.Name = "TxNumero";
			this.TxNumero.Size = new System.Drawing.Size(367, 40);
			this.TxNumero.TabIndex = 20;
			// 
			// Bu7
			// 
			this.Bu7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu7.Location = new System.Drawing.Point(13, 145);
			this.Bu7.Name = "Bu7";
			this.Bu7.Size = new System.Drawing.Size(80, 80);
			this.Bu7.TabIndex = 2;
			this.Bu7.Text = "7";
			this.Bu7.UseVisualStyleBackColor = false;
			this.Bu7.Click += new System.EventHandler(this.Bu7_Click);
			// 
			// Bu8
			// 
			this.Bu8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu8.Location = new System.Drawing.Point(99, 145);
			this.Bu8.Name = "Bu8";
			this.Bu8.Size = new System.Drawing.Size(80, 80);
			this.Bu8.TabIndex = 3;
			this.Bu8.Text = "8";
			this.Bu8.UseVisualStyleBackColor = false;
			this.Bu8.Click += new System.EventHandler(this.Bu8_Click);
			// 
			// Bu9
			// 
			this.Bu9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu9.Location = new System.Drawing.Point(185, 145);
			this.Bu9.Name = "Bu9";
			this.Bu9.Size = new System.Drawing.Size(80, 80);
			this.Bu9.TabIndex = 4;
			this.Bu9.Text = "9";
			this.Bu9.UseVisualStyleBackColor = false;
			this.Bu9.Click += new System.EventHandler(this.Bu9_Click);
			// 
			// BuDividir
			// 
			this.BuDividir.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.BuDividir.Location = new System.Drawing.Point(283, 145);
			this.BuDividir.Name = "BuDividir";
			this.BuDividir.Size = new System.Drawing.Size(80, 80);
			this.BuDividir.TabIndex = 5;
			this.BuDividir.Text = "/";
			this.BuDividir.UseVisualStyleBackColor = false;
			this.BuDividir.Click += new System.EventHandler(this.BuDividir_Click);
			// 
			// BuMultiplicar
			// 
			this.BuMultiplicar.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.BuMultiplicar.Location = new System.Drawing.Point(283, 231);
			this.BuMultiplicar.Name = "BuMultiplicar";
			this.BuMultiplicar.Size = new System.Drawing.Size(80, 80);
			this.BuMultiplicar.TabIndex = 9;
			this.BuMultiplicar.Text = "*";
			this.BuMultiplicar.UseVisualStyleBackColor = false;
			this.BuMultiplicar.Click += new System.EventHandler(this.BuMultiplicar_Click);
			// 
			// Bu6
			// 
			this.Bu6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu6.Location = new System.Drawing.Point(185, 231);
			this.Bu6.Name = "Bu6";
			this.Bu6.Size = new System.Drawing.Size(80, 80);
			this.Bu6.TabIndex = 8;
			this.Bu6.Text = "6";
			this.Bu6.UseVisualStyleBackColor = false;
			this.Bu6.Click += new System.EventHandler(this.Bu6_Click);
			// 
			// Bu5
			// 
			this.Bu5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu5.Location = new System.Drawing.Point(99, 231);
			this.Bu5.Name = "Bu5";
			this.Bu5.Size = new System.Drawing.Size(80, 80);
			this.Bu5.TabIndex = 7;
			this.Bu5.Text = "5";
			this.Bu5.UseVisualStyleBackColor = false;
			this.Bu5.Click += new System.EventHandler(this.Bu5_Click);
			// 
			// Bu4
			// 
			this.Bu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu4.Location = new System.Drawing.Point(13, 231);
			this.Bu4.Name = "Bu4";
			this.Bu4.Size = new System.Drawing.Size(80, 80);
			this.Bu4.TabIndex = 6;
			this.Bu4.Text = "4";
			this.Bu4.UseVisualStyleBackColor = false;
			this.Bu4.Click += new System.EventHandler(this.Bu4_Click);
			// 
			// BuSuma
			// 
			this.BuSuma.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.BuSuma.Location = new System.Drawing.Point(283, 317);
			this.BuSuma.Name = "BuSuma";
			this.BuSuma.Size = new System.Drawing.Size(80, 80);
			this.BuSuma.TabIndex = 13;
			this.BuSuma.Text = "+";
			this.BuSuma.UseVisualStyleBackColor = false;
			this.BuSuma.Click += new System.EventHandler(this.BuSuma_Click);
			// 
			// Bu3
			// 
			this.Bu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu3.Location = new System.Drawing.Point(185, 317);
			this.Bu3.Name = "Bu3";
			this.Bu3.Size = new System.Drawing.Size(80, 80);
			this.Bu3.TabIndex = 12;
			this.Bu3.Text = "3";
			this.Bu3.UseVisualStyleBackColor = false;
			this.Bu3.Click += new System.EventHandler(this.Bu3_Click);
			// 
			// Bu2
			// 
			this.Bu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu2.Location = new System.Drawing.Point(99, 317);
			this.Bu2.Name = "Bu2";
			this.Bu2.Size = new System.Drawing.Size(80, 80);
			this.Bu2.TabIndex = 11;
			this.Bu2.Text = "2";
			this.Bu2.UseVisualStyleBackColor = false;
			this.Bu2.Click += new System.EventHandler(this.Bu2_Click);
			// 
			// Bu1
			// 
			this.Bu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu1.Location = new System.Drawing.Point(13, 317);
			this.Bu1.Name = "Bu1";
			this.Bu1.Size = new System.Drawing.Size(80, 80);
			this.Bu1.TabIndex = 10;
			this.Bu1.Text = "1";
			this.Bu1.UseVisualStyleBackColor = false;
			this.Bu1.Click += new System.EventHandler(this.Bu1_Click);
			// 
			// BuResta
			// 
			this.BuResta.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.BuResta.Location = new System.Drawing.Point(283, 403);
			this.BuResta.Name = "BuResta";
			this.BuResta.Size = new System.Drawing.Size(80, 80);
			this.BuResta.TabIndex = 17;
			this.BuResta.Text = "-";
			this.BuResta.UseVisualStyleBackColor = false;
			this.BuResta.Click += new System.EventHandler(this.BuResta_Click);
			// 
			// BuBorrar
			// 
			this.BuBorrar.BackColor = System.Drawing.Color.RosyBrown;
			this.BuBorrar.Location = new System.Drawing.Point(186, 403);
			this.BuBorrar.Name = "BuBorrar";
			this.BuBorrar.Size = new System.Drawing.Size(80, 80);
			this.BuBorrar.TabIndex = 16;
			this.BuBorrar.Text = "<--";
			this.BuBorrar.UseVisualStyleBackColor = false;
			this.BuBorrar.Click += new System.EventHandler(this.BuBorrar_Click);
			// 
			// BuComa
			// 
			this.BuComa.BackColor = System.Drawing.Color.DarkGray;
			this.BuComa.Location = new System.Drawing.Point(99, 403);
			this.BuComa.Name = "BuComa";
			this.BuComa.Size = new System.Drawing.Size(80, 80);
			this.BuComa.TabIndex = 15;
			this.BuComa.Text = ",";
			this.BuComa.UseVisualStyleBackColor = false;
			this.BuComa.Click += new System.EventHandler(this.BuComa_Click);
			// 
			// Bu0
			// 
			this.Bu0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Bu0.Location = new System.Drawing.Point(13, 403);
			this.Bu0.Name = "Bu0";
			this.Bu0.Size = new System.Drawing.Size(80, 80);
			this.Bu0.TabIndex = 14;
			this.Bu0.Text = "0";
			this.Bu0.UseVisualStyleBackColor = false;
			this.Bu0.Click += new System.EventHandler(this.Bu0_Click);
			// 
			// lbHistorial
			// 
			this.lbHistorial.FormattingEnabled = true;
			this.lbHistorial.Location = new System.Drawing.Point(509, 29);
			this.lbHistorial.Name = "lbHistorial";
			this.lbHistorial.Size = new System.Drawing.Size(172, 446);
			this.lbHistorial.TabIndex = 18;
			// 
			// BuBorrarTodo
			// 
			this.BuBorrarTodo.BackColor = System.Drawing.Color.LightCoral;
			this.BuBorrarTodo.Location = new System.Drawing.Point(395, 145);
			this.BuBorrarTodo.Name = "BuBorrarTodo";
			this.BuBorrarTodo.Size = new System.Drawing.Size(80, 80);
			this.BuBorrarTodo.TabIndex = 21;
			this.BuBorrarTodo.Text = "C";
			this.BuBorrarTodo.UseVisualStyleBackColor = false;
			this.BuBorrarTodo.Click += new System.EventHandler(this.BuBorrarTodo_Click);
			// 
			// BuIgual
			// 
			this.BuIgual.BackColor = System.Drawing.Color.Tan;
			this.BuIgual.Location = new System.Drawing.Point(395, 231);
			this.BuIgual.Name = "BuIgual";
			this.BuIgual.Size = new System.Drawing.Size(80, 244);
			this.BuIgual.TabIndex = 22;
			this.BuIgual.Text = "=";
			this.BuIgual.UseVisualStyleBackColor = false;
			this.BuIgual.Click += new System.EventHandler(this.BuIgual_Click);
			// 
			// HuergoCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cornsilk;
			this.ClientSize = new System.Drawing.Size(693, 496);
			this.Controls.Add(this.BuIgual);
			this.Controls.Add(this.BuBorrarTodo);
			this.Controls.Add(this.lbHistorial);
			this.Controls.Add(this.BuResta);
			this.Controls.Add(this.BuBorrar);
			this.Controls.Add(this.BuComa);
			this.Controls.Add(this.Bu0);
			this.Controls.Add(this.BuSuma);
			this.Controls.Add(this.Bu3);
			this.Controls.Add(this.Bu2);
			this.Controls.Add(this.Bu1);
			this.Controls.Add(this.BuMultiplicar);
			this.Controls.Add(this.Bu6);
			this.Controls.Add(this.Bu5);
			this.Controls.Add(this.Bu4);
			this.Controls.Add(this.BuDividir);
			this.Controls.Add(this.Bu9);
			this.Controls.Add(this.Bu8);
			this.Controls.Add(this.Bu7);
			this.Controls.Add(this.TxNumero);
			this.Controls.Add(this.TxLista);
			this.MaximizeBox = false;
			this.Name = "HuergoCalculadora";
			this.ShowIcon = false;
			this.Text = "Calculadora";
			this.Load += new System.EventHandler(this.HuergoCalculadora_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxLista;
		private System.Windows.Forms.TextBox TxNumero;
		private System.Windows.Forms.Button Bu7;
		private System.Windows.Forms.Button Bu8;
		private System.Windows.Forms.Button Bu9;
		private System.Windows.Forms.Button BuDividir;
		private System.Windows.Forms.Button BuMultiplicar;
		private System.Windows.Forms.Button Bu6;
		private System.Windows.Forms.Button Bu5;
		private System.Windows.Forms.Button Bu4;
		private System.Windows.Forms.Button BuSuma;
		private System.Windows.Forms.Button Bu3;
		private System.Windows.Forms.Button Bu2;
		private System.Windows.Forms.Button Bu1;
		private System.Windows.Forms.Button BuResta;
		private System.Windows.Forms.Button BuBorrar;
		private System.Windows.Forms.Button BuComa;
		private System.Windows.Forms.Button Bu0;
		private System.Windows.Forms.ListBox lbHistorial;
		private System.Windows.Forms.Button BuBorrarTodo;
		private System.Windows.Forms.Button BuIgual;
	}
}

