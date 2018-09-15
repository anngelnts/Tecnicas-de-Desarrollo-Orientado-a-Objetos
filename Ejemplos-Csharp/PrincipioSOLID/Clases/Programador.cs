using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSOLID.Clases
{
    class Programador : Empleado
    {
        public override void CalcularBono()
        {
            Bono = Sueldo * 2;
            Console.WriteLine("Programador => " + Bono);
        }
    }
}
