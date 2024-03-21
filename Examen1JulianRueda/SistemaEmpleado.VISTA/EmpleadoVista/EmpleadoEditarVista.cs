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
	public partial class EmpleadoEditarVista : Form
	{
		int idx = 0;
		Empleado p = new Empleado();
		EmpleadoBss bss = new EmpleadoBss();
		public EmpleadoEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Empleado empleado = new Empleado();
			empleado.IdPersona = IdPersonaSeleccionada;
			empleado.Puesto = textBox2.Text;
			empleado.Salario = decimal.Parse(textBox3.Text);
			empleado.FechaContratacion = DateTime.Now;

			bss.EditarEmpleadoBss(empleado);
			MessageBox.Show("Datos del empleado actualizados correctamente");

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

		private void EmpleadoEditarVista_Load(object sender, EventArgs e)
		{
			Empleado emp = bss.ObtenerEmpleadoIdBss(idx); 

			textBox1.Text = emp.IdPersona.ToString();
			textBox2.Text = emp.Puesto;
			textBox3.Text = emp.Salario.ToString();

		}
	}
}
