using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Campeonato
{
	class Partido
	{
		private int id;
		private string descripcion;
		private DateTime fecha;
		private bool isFinalizado;
		private string observacion;
		private Equipo local;
		private Equipo visitante;
		//Se asocia con clase Cancha
		private Cancha cancha;
		public Partido()
		{
			this.isFinalizado = false;
			this.id = 1;
			Random alea = new Random();
			int dia = alea.Next(1, 31);
			this.fecha = new DateTime(2019, 3, dia , 16, 0, 0);
		}
		public Partido(Equipo equipo1 , Equipo equipo2)
		{
			this.local = equipo1;
			this.visitante = equipo2;
		}
		public void addCancha(Cancha c)
		{
			this.cancha = c;
		}
		public Partido(Arbitro ar1,Arbitro ar2)
		{
			this.arbitro1 = ar1;
			this.arbitro2 = ar2;
		}
		
		
		//Se asocia con clase Arbitro
		private Arbitro arbitro1;
		private Arbitro arbitro2;
		//private Arbitro[] arvitros


		public int Id { get; set; }
		public string Descripcion { get; set; }
		public DateTime Facha { get; set; }
	}
}
