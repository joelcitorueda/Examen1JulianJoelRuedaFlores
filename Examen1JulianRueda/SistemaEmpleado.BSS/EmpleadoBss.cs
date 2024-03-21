using SistemaEmpleado.MODELOS;
using SistemaEmpleado.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleado.BSS
{
	public class EmpleadoBss
	{
		EmpleadoDal dal = new EmpleadoDal();
		public DataTable ListarEmpleadosBss()
		{
			return dal.ListarEmpleadosDal();
		}
		public void InsertarEmpleadoBss(Empleado empleado)
		{
			dal.InsertarEmpleadoDal(empleado);
		}
		public Empleado ObtenerEmpleadoIdBss(int id)
		{
			return dal.ObtenerEmpleadoIdDal(id);
		}
		public void EditarEmpleadoBss(Empleado e)
		{
			dal.EditarEmpleadoDal(e);
		}
		public void EliminarEmpleadoBss(int id)
		{
			dal.EliminarEmpleadoDal(id);
		}

	}
}
