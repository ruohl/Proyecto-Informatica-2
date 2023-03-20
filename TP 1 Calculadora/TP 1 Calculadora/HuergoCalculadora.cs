using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_Calculadora
{
	public partial class HuergoCalculadora : Form
	{
		public HuergoCalculadora()
		{
			InitializeComponent();
		}

		public enum eOperacion
		{
			SUMAR,
			RESTAR,
			MULTIPLICAR,
			DIVIDIR
		}
		bool operacionIngresada = false;
		double numero1 = 0d;

		eOperacion operacion;

		private void IngresarNumero(int numero)
		{
			if (operacionIngresada)
			{
				operacionIngresada = false;
				TxNumero.Text = "";
			}
			TxNumero.Text += Convert.ToString(numero);
		}
		private void BuIgual_Click(object sender, EventArgs e)
		{
			if (TxNumero.Text == "") 
			{
				TxNumero.Text = "0";
			}
			double numero2 = Convert.ToDouble(TxNumero.Text);

			//
			double resultado = 0;
			if (operacion == eOperacion.SUMAR) //SUMAR)
			{
				resultado = numero1 + numero2;
				TxLista.Text = Convert.ToString(numero1) + "+" + Convert.ToString(numero2) + "=";
			}
			if (operacion == eOperacion.RESTAR) //RESTAR)
			{
				resultado = numero1 - numero2;
				TxLista.Text = Convert.ToString(numero1) + "-" + Convert.ToString(numero2) + "=";
			}
			if (operacion == eOperacion.DIVIDIR)
			{
				resultado = numero1 / numero2;
				TxLista.Text = Convert.ToString(numero1) + "/" + Convert.ToString(numero2) + "=";
			}
			if (operacion == eOperacion.MULTIPLICAR)
			{
				resultado = numero1 * numero2;
				TxLista.Text = Convert.ToString(numero1) + "*" + Convert.ToString(numero2) + "=";
			}
			operacionIngresada = true;
			TxNumero.Text = Convert.ToString(resultado);

			lbHistorial.Items.Add(TxLista.Text + TxNumero.Text);
			//123+1=
		}
		private void BuResta_Click(object sender, EventArgs e)
		{
			//ToDo: Mejorar llamando a una funcion.
			numero1 = Convert.ToDouble(TxNumero.Text);

			operacionIngresada = true;
			TxLista.Text = TxNumero.Text + "-";

			operacion = eOperacion.RESTAR; //RESTAR;
		}
		private void BuSuma_Click(object sender, EventArgs e)
		{
			//ToDo: Mejorar llamando a una funcion.
			numero1 = Convert.ToDouble(TxNumero.Text);

			operacionIngresada = true;
			TxLista.Text = TxNumero.Text + "+";

			operacion = eOperacion.SUMAR; //SUMAR;
		}
		private void BuDividir_Click(object sender, EventArgs e)
		{
			//ToDo: Mejorar llamando a una funcion.
			numero1 = Convert.ToDouble(TxNumero.Text);

			operacionIngresada = true;
			TxLista.Text = TxNumero.Text + "/";

			operacion = eOperacion.DIVIDIR;
		}
		private void BuMultiplicar_Click(object sender, EventArgs e)
		{
			//ToDo: Mejorar llamando a una funcion.
			numero1 = Convert.ToDouble(TxNumero.Text);

			operacionIngresada = true;
			TxLista.Text = TxNumero.Text + "*";

			operacion = eOperacion.MULTIPLICAR;
		}
		private void Bu0_Click(object sender, EventArgs e)
		{
			IngresarNumero(0);
		}
		private void Bu1_Click(object sender, EventArgs e)
		{
			IngresarNumero(1);
		}
		private void Bu2_Click(object sender, EventArgs e)
		{
			IngresarNumero(2);
		}
		private void Bu3_Click(object sender, EventArgs e)
		{
			IngresarNumero(3);
		}
		private void Bu4_Click(object sender, EventArgs e)
		{
			IngresarNumero(4);
		}
		private void Bu5_Click(object sender, EventArgs e)
		{
			IngresarNumero(5);
		}
		private void Bu6_Click(object sender, EventArgs e)
		{
			IngresarNumero(6);
		}
		private void Bu7_Click(object sender, EventArgs e)
		{
			IngresarNumero(7);
		}
		private void Bu8_Click(object sender, EventArgs e)
		{
			IngresarNumero(8);
		}
		private void Bu9_Click(object sender, EventArgs e)
		{
			IngresarNumero(9);
		}
		private void BuComa_Click(object sender, EventArgs e)
		{
			if (operacionIngresada)
			{
				operacionIngresada = false;
				TxNumero.Text = "";
			}
			TxNumero.Text += ",";
		}
		private void BuBorrar_Click(object sender, EventArgs e)
		{
			if (operacionIngresada == false)
			{
				if (TxNumero.Text != "")
				{
					TxNumero.Text = TxNumero.Text.Remove(TxNumero.Text.Length - 1);
				}
			}		
		}
		private void BuBorrarTodo_Click(object sender, EventArgs e)
		{
				operacionIngresada = false;
				TxLista.Text = "";
				TxNumero.Text = "";
		}
		private void HuergoCalculadora_Load(object sender, EventArgs e)
		{

		}

		
	}
}
