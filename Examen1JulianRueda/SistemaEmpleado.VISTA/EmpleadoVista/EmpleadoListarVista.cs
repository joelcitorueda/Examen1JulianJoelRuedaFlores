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

namespace SistemaEmpleado.VISTA.EmpleadoVista
{
	public partial class EmpleadoListarVista : Form
	{
		public EmpleadoListarVista()
		{
			InitializeComponent();
		}
		EmpleadoBss bss = new EmpleadoBss();

		private void EmpleadoListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarEmpleadosBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarEmpleadosBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			EmpleadoEditarVista fr = new EmpleadoEditarVista(IdSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarEmpleadosBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este empleado", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarEmpleadoBss(IdSeleccionada);
				dataGridView1.DataSource = bss.ListarEmpleadosBss();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
