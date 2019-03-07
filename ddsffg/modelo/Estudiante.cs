using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo
{
    class Estudiante
    {
		public byte edad;
		public string nombre;
		public char genero;
		public long numeroControl;

        public long NuumeroControl
        {
            get
            {
                return this.numeroControl;
            }
            set
            {
                if (value > 0)
                {
                    this.numeroControl = value;
                }
            }
        }
		public byte Edad
		{
			get
			{
				return this.edad;
			}
			set
			{
				if(value >= 0 || value <= 100)
				{
					this.edad = value;
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
				if (value != null || (value.Length >= 3 && value.Length <= 30))
				{
					this.nombre = value;
				}
			}
		}
		public char Genero
		{
			get
			{
				return this.genero;
			}
			set
			{
				if( value == 'h'|| value == 'H'|| value == 'm' || value == 'M' )
				{
					this.genero = value;
				}
			}
		}
	}
}
