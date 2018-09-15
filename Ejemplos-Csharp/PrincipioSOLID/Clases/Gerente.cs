using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID.Clases
{
    class Gerente : Empleado
    {
        public override void CalcularBono()
        {
            Bono = Sueldo * 15;
            Console.WriteLine("Empleado => "+Bono);
        }
    }
}
