using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class Jornada
	{
		private int id;
		private string nombre;
		private DateTime fechaInicio;
		private DateTime fechaFin;
		private bool isConcluida;

		public Jornada()
		{
			this.fechaInicio = DateTime.Today;
			this.isConcluida = false;
			
			
		}
		public Jornada(int i)
		{
		  
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
		{
			get
			{
				return this.nombre;

			}
			set
			{
				{
					if (value != null || (value.Length >= 3 && value.Length <= 30))
					{
						this.nombre = value;
					}
				}
			}
		}
		public DateTime FechaInicio
		{
			get
			{ return this.fechaInicio; }
			set
			{
				if (value > DateTime.Today)
				{
					this.fechaInicio = value;
				}
			}
		}
		public DateTime FechaFin
		{
			get
			{ return this.FechaFin; }
			set
			{
				DateTime fin = new DateTime(2019, 4, 8);
				if (value > DateTime.Today)
				{
					this.fechaFin = value;
				}
			}
		}
		public bool IsConcluida { get; set; }
	}

}
