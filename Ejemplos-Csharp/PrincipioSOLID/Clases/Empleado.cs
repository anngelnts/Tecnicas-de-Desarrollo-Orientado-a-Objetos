using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID.Clases
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public double Sueldo { get; set; }
        public double Bono { get; set; }

        public abstract void CalcularBono();
    }
}
