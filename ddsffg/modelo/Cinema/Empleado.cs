using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo.Cinema
{
	class Empleado : Persona
	{

		public override string ToString()
		{
			return base.ToString() + "|Numero Empleado" ;
		}
	}
}
