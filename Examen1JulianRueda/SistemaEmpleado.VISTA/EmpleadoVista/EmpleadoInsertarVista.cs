using SistemaEmpleado.BSS;
using SistemaEmpleado.MODELOS;
using SistemaEmpleado.VISTA.PersonasVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleado.VISTA.EmpleadoVista
{
	public partial class EmpleadoInsertarVista : Form
	{
		public EmpleadoInsertarVista()
		{
			InitializeComponent();
		}
		public static int IdPersonaSeleccionada = 0;
		PersonasBss bssper = new PersonasBss();
		private void button3_Click(object sender, EventArgs e)
		{
			PersonasListarVista fr = new PersonasListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Personas persona = bssper.ObtenerPersonasIdBss(IdPersonaSeleccionada);
				textBox1.Text = persona.Nombre + " " + persona.Apellido;
			}
		}
		EmpleadoBss bss = new EmpleadoBss();
		private void button1_Click(object sender, EventArgs e)
		{
			Empleado empleado = new Empleado();
			empleado.IdPersona = IdPersonaSeleccionada;
			empleado.Puesto = textBox2.Text;
			empleado.Salario = decimal.Parse(textBox3.Text);
			empleado.FechaContratacion = DateTime.Now; 

			bss.InsertarEmpleadoBss(empleado);
			MessageBox.Show("Se guardó correctamente al empleado");

		}
	}
}
