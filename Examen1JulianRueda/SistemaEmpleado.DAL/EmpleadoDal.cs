using SistemaEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleado.DAL
{
	public  class EmpleadoDal
	{
		public DataTable ListarEmpleadosDal()
		{
			string consulta = "select * from empleado";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}

		public void InsertarEmpleadoDal(Empleado empleado)
		{
			string consulta = "insert into Empleado (idpersona, puesto, salario, fechacontratacion) values(" +
								empleado.IdPersona + ",'" +
								empleado.Puesto + "'," +
								empleado.Salario.ToString().Replace(",", ".") + ",'" + 
								empleado.FechaContratacion.ToString("yyyy-MM-dd") + "')"; 
			conexion.Ejecutar(consulta);
		}

		public Empleado ObtenerEmpleadoIdDal(int id)
		{
			string consulta = "select * from empleado where idempleado=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			Empleado empleado = new Empleado();
			if (tabla.Rows.Count > 0)
			{
				empleado.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
				empleado.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
				empleado.Puesto = tabla.Rows[0]["puesto"].ToString();
				empleado.Salario = Convert.ToDecimal(tabla.Rows[0]["salario"]);
				empleado.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["fechacontratacion"]);
			}
			return empleado;
		}

		public void EditarEmpleadoDal(Empleado empleado)
		{
			string consulta = "update empleado set idpersona=" + empleado.IdPersona + "," +
													"puesto='" + empleado.Puesto + "'," +
													"salario=" + empleado.Salario.ToString().Replace(",", ".") + "," +
													"fechacontratacion='" + empleado.FechaContratacion.ToString("yyyy-MM-dd") + "'" +
													"where idempleado=" + empleado.IdEmpleado;
			conexion.Ejecutar(consulta);
		}

		public void EliminarEmpleadoDal(int id)
		{
			string consulta = "delete from empleado where idempleado=" + id;
			conexion.Ejecutar(consulta);
		}

	}
}
