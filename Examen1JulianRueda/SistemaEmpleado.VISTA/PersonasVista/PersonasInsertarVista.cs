using SistemaEmpleado.BSS;
using SistemaEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEmpleado.VISTA.PersonasVista
{
	public partial class PersonasInsertarVista : Form
	{
		public PersonasInsertarVista()
		{
			InitializeComponent();
		}
		PersonasBss bss = new PersonasBss();
		private void button1_Click(object sender, EventArgs e)
		{
			Personas p = new Personas();
			p.Nombre = textBox1.Text;
			p.Apellido = textBox2.Text;
			
			bss.InsertarPersonaBss(p);
			MessageBox.Show("Se guardó correctamente a Persona");

		}
	}
}
