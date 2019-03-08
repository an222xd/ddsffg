using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class campeonato1
	{

		private int id;
		private string nombre;
		private DateTime fechaInicio;
		private DateTime fechaFin;

		//Constructor default
		public campeonato1()
		{
			this.nombre = "Campeonato de la segunda divicion Doleondres";
			this.id = 1;
			for (int i = 1; i <= 20; i++)
			{
				Jornada jornada1 = new Jornada();
				jornadas.Add(jornada1);
			}
		}
		//Resultado de la asociacion entre campeonato y jornada
		private List<Jornada> jornadas = new List<Jornada>();

		public int Id { get; set; }
		public string Nombre { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FecaFin { get; set; }

	}
}
