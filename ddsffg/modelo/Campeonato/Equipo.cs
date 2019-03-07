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


	}
}
