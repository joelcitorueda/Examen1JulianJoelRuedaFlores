using SistemaEmpleado.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleado.DAL
{
	public class PersonasDal
	{
		public DataTable ListarPersonasDal()
		{
			string consulta = "select * from personas";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}
		public void InsertarPersonasDal(Personas persona)
		{
			string consulta = "insert into personas values('" + persona.Nombre + "'," +
														 "'" + persona.Apellido + "'," +
														 
														 "'Activo')";
			conexion.Ejecutar(consulta);
		}
		Personas p = new Personas();
		public Personas ObtenerPersonasIdDal(int id)
		{
			string consulta = "select * from personas where idpersona=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
				p.Nombre = tabla.Rows[0]["nombre"].ToString();
				p.Apellido = tabla.Rows[0]["apellido"].ToString();
				p.Estado = tabla.Rows[0]["estado"].ToString();

			}
			return p;
		}
		public void EditarPersonasDal(Personas p)
		{
			string consulta = "update personas set nombre='" + p.Nombre + "'," +
														"apellido='" + p.Apellido + "'," +
														
												"where idpersona=" + p.IdPersona;
			conexion.Ejecutar(consulta);
		}
		public void EliminarPersonasDal(int id)
		{
			string consulta = "delete from personas where idpersona=" + id;
			conexion.Ejecutar(consulta);
		}
	}
}
