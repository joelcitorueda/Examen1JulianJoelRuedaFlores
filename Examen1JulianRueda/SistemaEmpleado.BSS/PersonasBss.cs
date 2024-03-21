using SistemaEmpleado.DAL;
using SistemaEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleado.BSS
{
	public class PersonasBss
	{
		PersonasDal dal = new PersonasDal();
		public DataTable ListarPersonasBss()
		{
			return dal.ListarPersonasDal();
		}
		public void InsertarPersonaBss(Personas persona)
		{
			dal.InsertarPersonasDal(persona);
		}
		public Personas ObtenerPersonasIdBss(int id)
		{
			return dal.ObtenerPersonasIdDal(id);
		}
		public void EditarPersonasBss(Personas p)
		{
			dal.EditarPersonasDal(p);
		}
		public void EliminarPersonasBss(int id)
		{
			dal.EliminarPersonasDal(id);
		}
	}
}
