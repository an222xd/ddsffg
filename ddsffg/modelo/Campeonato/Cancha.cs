using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class Cancha
	{
		private int id;
		private string nombre;
		private string ubicacion;
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
		public string Nom
		{
			get
			{
				return this.nombre;
			}
			set
			{
				if(value != null || (value.Length > 2 && value.Length <= 30))
				{
					this.nombre = value;
				}
			}
		}
		public string ubi
		{
			get
			{
				return this.nombre;
			}
			set
			{

			}
		}
	}

}
