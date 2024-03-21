using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpleado.BSS;
using SistemaEmpleado.VISTA;



namespace SistemaEmpleado.VISTA.PersonasVista
{
	public partial class PersonasListarVista : Form
	{
		public PersonasListarVista()
		{
			InitializeComponent();
		}
		PersonasBss bss = new PersonasBss();

		private void PersonasListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarPersonasBss();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int idPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

			//EmpleadoVistas.UsuarioInsertarVista.IdPersonaSeleccionada = idPersonaSeleccionada;
			//EmpleadoVistas.UsuarioEditarVista.IdPersonaSeleccionada = idPersonaSeleccionada;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			PersonasInsertarVista fr = new PersonasInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPersonasBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdPersonasSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			PersonasEditarVsita fr = new PersonasEditarVsita(IdPersonasSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPersonasBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Persona?", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarPersonasBss(IdPersonaSeleccionada);
				dataGridView1.DataSource = bss.ListarPersonasBss();
			}
		}
	}
}
