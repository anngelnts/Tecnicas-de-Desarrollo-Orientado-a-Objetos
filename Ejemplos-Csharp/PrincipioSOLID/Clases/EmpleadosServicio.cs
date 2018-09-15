using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID.Clases
{
    class EmpleadosServicio
    {
        public List<Empleado> Empleados = new List<Empleado>();
        public void CalcularBonos()
        {
            foreach(var empleado in Empleados)
            {
                empleado.CalcularBono();
            }
        }
    }
}
