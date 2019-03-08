using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class nombre
	{ 
		private int id;
		private string nombre1;
		private string ubicacion;
		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				if(value >= 0 )
				this.id = value;
			}
		}
		public string Nombre1
		{
			get
			{
				return this.nombre1;

			}
			set
			{
				{
					if (value != null || (value.Length >= 3 && value.Length <= 30))
					{
						this.nombre1 = value;
					}
				}
			}
		}
		public string Ubicacion
		{
			get
			{
				return this.ubicacion;
			}
			set
			{
				if(value!=null || (value.Length>= 3 && value.Length <=30))
				{
					this.ubicacion = value;
				}
			}
		}
	}
}
