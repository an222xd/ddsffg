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
		public Jugador()
		{
			this.nombre = "Papu Lince";
			this.apelllidos = "Del campo de la via lactea";
			this.fechaNacimiento = DateTime.Today;

		}

		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string Numero { get; set; }
		public DateTime Fecha { get; set; }
	}
}
