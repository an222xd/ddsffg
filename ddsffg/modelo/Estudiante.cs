using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsffg.modelo
{
    class Estudiante
    {
    public byte edad { get; set; }
    public string nombre { get; set; }
    public char genero { get; set; }
    public long numeroControl { get; set; }

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
    }
}
