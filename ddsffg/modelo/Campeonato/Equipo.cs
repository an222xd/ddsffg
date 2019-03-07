using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class Equipo
	{
		private int id;
		private string nombre;
		private string comunidad;
		private string entrenador;

		public Equipo()
		{
			this.nombre = "Deportivo 'EL MERO MERO' ";
		}
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				if (value > 0)
				{
					this.id = value;
				}  
			}
		}
		public string Nombre
		{ get
			{
				return this.nombre;
			}
			set
			{
				if(value != null || (value.Length >= 3 && value.Length <= 30))
				{
					this.nombre = value;
				}
			}
		}
		public string Comunidad
		{
			get
			{
				return this.comunidad;
			}
			set
			{
				if(value != null || (value.Length >= 3 && value.Length <= 50))
				{
					this.comunidad = value;
				}
			}
		}
		public string Entrenador
		{
			get
			{
				return this.entrenador;
			}
			set
			{
				if(value != null || (value.Length > 3 && value.Length <= 30))
				{
					this.entrenador = value;
				}
			}
		}


	}
}
