using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class Jugador
	{
		private int id;
		private string nombre;
		private string apelllidos;
		private DateTime fechaNacimiento;
		private byte numero;
		private Equipo idequpo;
		public Jugador()
		{
			this.nombre = "Papu Lince";
			this.apelllidos = "Del campo de la via lactea";
			this.fechaNacimiento = DateTime.Today;

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
		public string Apellidos
		{
			get
			{
				return this.apelllidos;

			}
			set
			{
				{
					if (value != null || (value.Length >= 3 && value.Length <= 30))
					{
						this.apelllidos = value;
					}
				}
			}
		}
		public byte Numero
		{
			get
			{
				return this.numero;
			}
			set
			{
				if (value > 0)
				{
					this.numero = value;
				}
			}
		}
		public DateTime Fecha
		{
			get
			{
				return this.fechaNacimiento;
			}
			set
			{
				if(value != null)
				{
					this.fechaNacimiento = value;
				}
			}
		}
		public Equipo Idequipo
		{
			get
			{
				return this.Idequipo;
			}
			set
			{
				if(value!=null || !((Equipo)value).Nombre.ToLower().Equals("Irapuato"))
				this.Idequipo = value;
			}

		}
	}
}
